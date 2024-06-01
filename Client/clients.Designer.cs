namespace Client
{
    partial class clients
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_conect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_send = new System.Windows.Forms.Button();
            this.rtb_notify = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.tb_countdown = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_point = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_conect
            // 
            this.bt_conect.Location = new System.Drawing.Point(293, 402);
            this.bt_conect.Name = "bt_conect";
            this.bt_conect.Size = new System.Drawing.Size(75, 23);
            this.bt_conect.TabIndex = 17;
            this.bt_conect.Text = "CONECT";
            this.bt_conect.UseVisualStyleBackColor = true;
            this.bt_conect.Click += new System.EventHandler(this.bt_conect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "NOTIFY";
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(374, 402);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(75, 23);
            this.bt_send.TabIndex = 15;
            this.bt_send.Text = "SEND";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // rtb_notify
            // 
            this.rtb_notify.Location = new System.Drawing.Point(88, 50);
            this.rtb_notify.Name = "rtb_notify";
            this.rtb_notify.Size = new System.Drawing.Size(625, 290);
            this.rtb_notify.TabIndex = 14;
            this.rtb_notify.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "GUESS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "NAME";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(214, 346);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(436, 22);
            this.tb_user.TabIndex = 11;
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(214, 374);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(436, 22);
            this.tb_num.TabIndex = 10;
            // 
            // tb_countdown
            // 
            this.tb_countdown.Location = new System.Drawing.Point(613, 27);
            this.tb_countdown.Name = "tb_countdown";
            this.tb_countdown.Size = new System.Drawing.Size(100, 22);
            this.tb_countdown.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "RANDOM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_point
            // 
            this.tb_point.Location = new System.Drawing.Point(88, 25);
            this.tb_point.Name = "tb_point";
            this.tb_point.Size = new System.Drawing.Size(100, 22);
            this.tb_point.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "POINT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "COUNT DOWN";
            // 
            // clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_point);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_countdown);
            this.Controls.Add(this.bt_conect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.rtb_notify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.tb_num);
            this.Name = "clients";
            this.Text = "clients";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.clients_FormClosed);
            this.Load += new System.EventHandler(this.clients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_conect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.RichTextBox rtb_notify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.TextBox tb_countdown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_point;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}