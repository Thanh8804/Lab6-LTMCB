namespace Game_Lab6
{
    partial class Server
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.TextBox();
            this.tb_count_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_count_submit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_start_game = new System.Windows.Forms.Button();
            this.rtb_notify = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(249, 387);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(116, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "RUN SERVER";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(397, 387);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(127, 23);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "TURN OFF";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(13, 12);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(232, 22);
            this.Number.TabIndex = 3;
            // 
            // tb_count_user
            // 
            this.tb_count_user.Location = new System.Drawing.Point(371, 12);
            this.tb_count_user.Name = "tb_count_user";
            this.tb_count_user.Size = new System.Drawing.Size(153, 22);
            this.tb_count_user.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "COUNT PLAYER";
            // 
            // tb_count_submit
            // 
            this.tb_count_submit.Location = new System.Drawing.Point(660, 12);
            this.tb_count_submit.Name = "tb_count_submit";
            this.tb_count_submit.Size = new System.Drawing.Size(128, 22);
            this.tb_count_submit.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "COUNT MESSAGE";
            // 
            // btn_start_game
            // 
            this.btn_start_game.Location = new System.Drawing.Point(309, 415);
            this.btn_start_game.Name = "btn_start_game";
            this.btn_start_game.Size = new System.Drawing.Size(135, 23);
            this.btn_start_game.TabIndex = 8;
            this.btn_start_game.Text = "START GAME";
            this.btn_start_game.UseVisualStyleBackColor = true;
            this.btn_start_game.Click += new System.EventHandler(this.btn_start_game_Click);
            // 
            // rtb_notify
            // 
            this.rtb_notify.Location = new System.Drawing.Point(13, 41);
            this.rtb_notify.Name = "rtb_notify";
            this.rtb_notify.Size = new System.Drawing.Size(775, 340);
            this.rtb_notify.TabIndex = 9;
            this.rtb_notify.Text = "";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_notify);
            this.Controls.Add(this.btn_start_game);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_count_submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_count_user);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox tb_count_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_count_submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_start_game;
        private System.Windows.Forms.RichTextBox rtb_notify;
    }
}