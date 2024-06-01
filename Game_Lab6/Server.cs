using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Net.Http;

namespace Game_Lab6
{
    
    public partial class Server : Form
    {
        private static Dictionary<string, Player> players = new Dictionary<string, Player>();
        private TcpListener listener;
        private List<TcpClient> clients = new List<TcpClient>();
        private int Num_min;
        private int Num_max;
        private int secretNumber;
        private const int minRange = 1;
        private const int maxRange = 100;
        static public int Count_user = 0;
        static public int Count_submit = 0;
        private int count_timeplay = 1;
        public Server()
        {
            InitializeComponent();
            
        }

        

        private void GenerateSecretNumber()
        {
            Random rand = new Random();
            Num_min = rand.Next(minRange, maxRange + 1);

            
            Num_max = rand.Next(Num_min + 1, maxRange + 1);

            secretNumber = rand.Next(Num_min ,Num_max + 1);
            Number.Text = $"Rand Secret Number: {Num_min} - {Num_max} ({secretNumber})";
            rtb_notify.AppendText($"Game {count_timeplay} start: Rand Secret Number: {Num_min} - {Num_max} ({secretNumber})\n");
        }

        private void StartServer()
        {
            listener = new TcpListener(IPAddress.Any, 8080);
            listener.Start();
            Thread acceptThread = new Thread(AcceptClients);
            acceptThread.Start();
        }

        private async void AcceptClients()
        {
            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                clients.Add(client);
                Thread clientThread = new Thread(() => HandleClient(client));
                Count_user++;
                tb_count_user.Text = Count_user.ToString();
                clientThread.Start();
            }
        }
        

        

        private async void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            while (true)
            {
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Count_submit ++;
                tb_count_submit.Text = Count_submit.ToString();
                string[] parts = message.Split(new string[] { "_.?/|/?._" }, StringSplitOptions.None);


                string part1 = parts[0];
                string part2 = parts[1];

                
                int guess = int.Parse(part2);
                string response = CheckGuess(guess);

                if (!players.ContainsKey(part1))
                {
                    players[part1] = new Player { name = part1 };
                }
                Player player = players[part1];
                
                if (response == "Correct!") {
                    player.point += 10;
                    if (count_timeplay == 2)
                    {
                        Player winner = players.Values
                        .OrderByDescending(p => p.point)
                        .First();
                        response = $"{part1} win.\n\nThe winner in this game is {winner.name} with point {winner.point}";
                        broadcast(response, clients);

                        


                        rtb_notify.AppendText($"{response}\n");
                        string message_cls = $"Game Close";
                        await broadcast(message_cls, clients);
                        break;
                    }
                        response = $"{part1} win.";
                        broadcast(response, clients);
                        rtb_notify.AppendText($"{response}\n");
                        count_timeplay++;
                        GenerateSecretNumber();
                        string messages = $"\nGame Start: {Num_min} - {Num_max}";
                        broadcast(messages, clients);
                        
                        
                        
                      
                }
                else
                {
                    player.point -= 2;
                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                    stream.Write(responseBytes, 0, responseBytes.Length);
                    string datetime = DateTime.Now.ToString();
                    rtb_notify.AppendText($"user: {part1} guess: {part2} time: {datetime}\n");
                }
                
            }
        }

        private string CheckGuess(int guess)
        {
            if (guess == secretNumber)
            {
                return "Correct!";
            }
            else if (guess < secretNumber)
            {
                return "Too low!";
            }
            else
            {
                return "Too high!";
            }
        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                StartServer();
                MessageBox.Show("Start sever success!","succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
            
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            listener.Stop();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            tb_count_user.Text = Count_user.ToString();

        }
        
        private async Task broadcast(string message, List<TcpClient> clients)
        {
            foreach (TcpClient client in clients)
            {
                NetworkStream stream = client.GetStream();
                byte[] responseBytes = Encoding.UTF8.GetBytes(message);
                stream.Write(responseBytes, 0, responseBytes.Length);
            }
        }
        private void btn_start_game_Click(object sender, EventArgs e)
        {
            GenerateSecretNumber();
            string message = $"Game Start: {Num_min} - {Num_max}";
            broadcast(message, clients);
        }
    }
    class Player : Form
    {
        public string name { get; set; }
        public int point { get; set; }
    }
}
