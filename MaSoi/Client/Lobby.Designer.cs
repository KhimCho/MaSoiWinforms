using System.ComponentModel;

namespace Client
{
    partial class Lobby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.playerList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.roomChat = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.msg_text = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerList
            // 
            this.playerList.HideSelection = false;
            this.playerList.Location = new System.Drawing.Point(12, 27);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(289, 355);
            this.playerList.TabIndex = 0;
            this.playerList.UseCompatibleStateImageBehavior = false;
            this.playerList.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "PlayerList";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(33, 401);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(90, 37);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // roomChat
            // 
            this.roomChat.HideSelection = false;
            this.roomChat.Location = new System.Drawing.Point(307, 27);
            this.roomChat.Name = "roomChat";
            this.roomChat.Size = new System.Drawing.Size(338, 258);
            this.roomChat.TabIndex = 4;
            this.roomChat.UseCompatibleStateImageBehavior = false;
            this.roomChat.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "RoomChat";
            // 
            // msg_text
            // 
            this.msg_text.Location = new System.Drawing.Point(307, 311);
            this.msg_text.Name = "msg_text";
            this.msg_text.Size = new System.Drawing.Size(259, 23);
            this.msg_text.TabIndex = 6;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(572, 311);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 7;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(150, 401);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(90, 37);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.msg_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomChat);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerList);
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ListView playerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ListView roomChat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox msg_text;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Start;

        #endregion
    }
}