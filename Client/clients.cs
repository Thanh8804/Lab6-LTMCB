using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    
    public partial class clients : Form
    {
        private bool isCountdownRunning = false;
        private TcpClient client;
        private NetworkStream stream;
        private CancellationTokenSource cts;
        private int point = 0;
        private int num_min;
        private int num_max;
        static HashSet<int> triedResults = new HashSet<int>(); // Tập hợp lưu các kết quả đã thử
        static Random random = new Random(); // Khởi tạo đối tượng Random
        
        public clients()
        {
            InitializeComponent();
        }

        private void ConnectToServer()
        {
            isCountdownRunning = false ;
            client = new TcpClient("127.0.0.1", 8080);
            stream = client.GetStream();
            cts = new CancellationTokenSource();
            _ = ReceiveMessages(cts.Token);
        }

        private async Task SendGuess(string message)
        {

            if (isCountdownRunning)
            {
                MessageBox.Show("Countdown is running, please wait.");
                return; // Không thực hiện gửi tin nhắn nếu countdown đang chạy
            }

            byte[] data = Encoding.UTF8.GetBytes(message);
            await stream.WriteAsync(data, 0, data.Length); // Sử dụng WriteAsync để tránh nghẽn giao diện

            // Đếm ngược sau khi gửi và nhận phản hồi
            await count_down(3);
        }

        private void bt_conect_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectToServer();
                MessageBox.Show("Conect success!");
            }
            catch (Exception ex) { 
                MessageBox.Show("Error: ", ex.Message);
            }
        }
        private async Task count_down(int num)
        {
            isCountdownRunning = true; // Đặt cờ hiệu khi bắt đầu countdown
            try
            {
                while (num >= 0)
                {
                    tb_countdown.Invoke((Action)(() => tb_countdown.Text = num.ToString()));
                    await Task.Delay(1000); // Dừng chương trình trong 1 giây (1000 milliseconds)
                    num--;
                }
            }
            finally
            {
                isCountdownRunning = false; // Đặt lại cờ hiệu khi countdown kết thúc
            }
        }

        private async void bt_send_Click(object sender, EventArgs e)
        {
            if (!isCountdownRunning) { 
            if(int.Parse(tb_num.Text)>=num_min && int.Parse(tb_num.Text) <= num_max)
            {
                if (triedResults.Contains(int.Parse(tb_num.Text)))
                {
                    MessageBox.Show($"so da ton tai!");
                }
                else
                {
                    rtb_notify.AppendText($"you send: {tb_num.Text} -> ");
                    int guess = int.Parse(tb_num.Text);
                    string name = tb_user.Text;
                    string message = $"{name}_.?/|/?._{guess.ToString()}";
                    SendGuess(message);
                    tb_num.Text = string.Empty;
                    MessageBox.Show("send success!");
                    triedResults.Add(guess);
                }
                
            }
            else
            {
                MessageBox.Show($"value in range {num_min} - {num_max}!");
                tb_num.Text = string.Empty;
            }
            }
            else
            {
                MessageBox.Show("count down is  runing!");
            }

        }
        private async Task ReceiveMessages(CancellationToken token)
        {
            byte[] buffer = new byte[1024];
            while (!token.IsCancellationRequested)
            {
                try
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length, token);
                    if (bytesRead == 0) break;

                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    if(response == "Game Close")
                    {
                        MessageBox.Show("Game end. click oke to close", "notify");
                        string path = "..\\Debug\\history.txt";
                        
                        using (StreamWriter writer = File.AppendText(path))
                        {
                            writer.WriteLine($"-----------------------------------------------------------------------");
                            writer.WriteLine($"User: {tb_user.Text}");
                            // Ghi nội dung vào tập tin
                            writer.WriteLine(rtb_notify.Text);
                        }
                        this.Close();
                    }
                    if (response.Contains("Game Start: "))
                    {
                        string[] parts = response.Split(new string[] { ": " }, StringSplitOptions.None);
                        string[] spl_parts2 = parts[1].Split(new string[] { " - " }, StringSplitOptions.None);
                        num_min = int.Parse( spl_parts2[0]);
                        num_max = int.Parse( spl_parts2[1]);
                         
                    }
                    if (response == "Too high!" || response == "Too low!")
                    {
                        point -= 2;
                        tb_point.Text = point.ToString();
                        
                    }
                    if (response.Contains($"{tb_user.Text} win."))
                    {
                        point += 10;
                        tb_point.Text = point.ToString();
                    }
                    Invoke((MethodInvoker)(() => rtb_notify.AppendText($"{response}\n")));
                    
                }
                catch (Exception ex)
                {
                    if (token.IsCancellationRequested) break;
                    MessageBox.Show($"Error receiving data: {ex.Message}");
                }
            }
        }
        private void autoplay(int num_min, int num_max)
        {
            if (!isCountdownRunning)
            {
                int result = GenerateUniqueRandom(num_min, num_max, triedResults);
                triedResults.Add(result);
                rtb_notify.AppendText($"you send: {result} -> ");
                int guess = result;
                string name = tb_user.Text;
                string message = $"{name}_.?/|/?._{guess.ToString()}";
                SendGuess(message);
                tb_num.Text = string.Empty;
            }
            else {
                MessageBox.Show("count down is runing");
            }

        }


        static int GenerateUniqueRandom(int minValue, int maxValue, HashSet<int> triedResults)
        {
            if (triedResults.Count >= (maxValue - minValue + 1))
            {
                throw new InvalidOperationException("All possible results have been tried.");
            }

            int result;
            do
            {
                result = random.Next(minValue, maxValue + 1);
            } while (triedResults.Contains(result));

            return result;
        }
        private async void clients_Load(object sender, EventArgs e)
        {
            tb_point.Text = point.ToString();
        }

        private void clients_FormClosed(object sender, FormClosedEventArgs e)
        {
            cts?.Cancel();
            stream?.Close();
            client?.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            autoplay(num_min, num_max);

        }
    }
}
