﻿using System.Windows.Forms;

namespace Client
{
    partial class FormGame
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
            this.plroom = new System.Windows.Forms.Panel();
            this.btLoadRoom = new System.Windows.Forms.Button();
            this.btLoadPlayer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPlayer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ltbListRoom = new System.Windows.Forms.ListBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btCreateRoom = new System.Windows.Forms.Button();
            this.tbYou = new System.Windows.Forms.TextBox();
            this.tbComp = new System.Windows.Forms.TextBox();
            this.btRule = new System.Windows.Forms.Button();
            this.pnlgame = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbidphong = new System.Windows.Forms.Label();
            this.rtbchat = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbcontentchat = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plroom.SuspendLayout();
            this.pnlgame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plroom
            // 
            this.plroom.BackgroundImage = global::Client.Properties.Resources.RE4wyS2;
            this.plroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plroom.Controls.Add(this.btLoadRoom);
            this.plroom.Controls.Add(this.btLoadPlayer);
            this.plroom.Controls.Add(this.label2);
            this.plroom.Controls.Add(this.lbPlayer);
            this.plroom.Controls.Add(this.label1);
            this.plroom.Controls.Add(this.ltbListRoom);
            this.plroom.Controls.Add(this.btClose);
            this.plroom.Controls.Add(this.btCreateRoom);
            this.plroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plroom.Location = new System.Drawing.Point(0, 0);
            this.plroom.Name = "plroom";
            this.plroom.Size = new System.Drawing.Size(802, 541);
            this.plroom.TabIndex = 10;
            this.plroom.Paint += new System.Windows.Forms.PaintEventHandler(this.plroom_Paint);
            // 
            // btLoadRoom
            // 
            this.btLoadRoom.Location = new System.Drawing.Point(368, 464);
            this.btLoadRoom.Name = "btLoadRoom";
            this.btLoadRoom.Size = new System.Drawing.Size(75, 23);
            this.btLoadRoom.TabIndex = 10;
            this.btLoadRoom.Text = "Load";
            this.btLoadRoom.UseVisualStyleBackColor = true;
            this.btLoadRoom.Click += new System.EventHandler(this.btLoadRoom_Click);
            // 
            // btLoadPlayer
            // 
            this.btLoadPlayer.Location = new System.Drawing.Point(657, 464);
            this.btLoadPlayer.Name = "btLoadPlayer";
            this.btLoadPlayer.Size = new System.Drawing.Size(75, 23);
            this.btLoadPlayer.TabIndex = 9;
            this.btLoadPlayer.Text = "Load";
            this.btLoadPlayer.UseVisualStyleBackColor = true;
            this.btLoadPlayer.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(630, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "PLAYER LIST";
            // 
            // lbPlayer
            // 
            this.lbPlayer.FormattingEnabled = true;
            this.lbPlayer.Location = new System.Drawing.Point(617, 90);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(173, 368);
            this.lbPlayer.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(321, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "LIST ROOM";
            // 
            // ltbListRoom
            // 
            this.ltbListRoom.FormattingEnabled = true;
            this.ltbListRoom.Location = new System.Drawing.Point(213, 90);
            this.ltbListRoom.Name = "ltbListRoom";
            this.ltbListRoom.Size = new System.Drawing.Size(367, 368);
            this.ltbListRoom.TabIndex = 5;
            this.ltbListRoom.SelectedIndexChanged += new System.EventHandler(this.ltbdanhsachphonggame_SelectedIndexChanged);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(12, 320);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(162, 44);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Thoát";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // btCreateRoom
            // 
            this.btCreateRoom.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateRoom.Location = new System.Drawing.Point(12, 166);
            this.btCreateRoom.Name = "btCreateRoom";
            this.btCreateRoom.Size = new System.Drawing.Size(162, 44);
            this.btCreateRoom.TabIndex = 0;
            this.btCreateRoom.Text = "Tạo Phòng";
            this.btCreateRoom.UseVisualStyleBackColor = true;
            this.btCreateRoom.Click += new System.EventHandler(this.btntaophongmoi_Click);
            // 
            // tbYou
            // 
            this.tbYou.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbYou.Enabled = false;
            this.tbYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYou.ForeColor = System.Drawing.SystemColors.Menu;
            this.tbYou.Location = new System.Drawing.Point(26, 337);
            this.tbYou.Multiline = true;
            this.tbYou.Name = "tbYou";
            this.tbYou.Size = new System.Drawing.Size(99, 38);
            this.tbYou.TabIndex = 12;
            this.tbYou.Text = "0";
            this.tbYou.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbComp
            // 
            this.tbComp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbComp.Enabled = false;
            this.tbComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComp.ForeColor = System.Drawing.SystemColors.Menu;
            this.tbComp.Location = new System.Drawing.Point(657, 337);
            this.tbComp.Multiline = true;
            this.tbComp.Name = "tbComp";
            this.tbComp.Size = new System.Drawing.Size(99, 38);
            this.tbComp.TabIndex = 11;
            this.tbComp.Text = "0";
            this.tbComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btRule
            // 
            this.btRule.BackColor = System.Drawing.Color.Aqua;
            this.btRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRule.ForeColor = System.Drawing.Color.Maroon;
            this.btRule.Location = new System.Drawing.Point(3, 20);
            this.btRule.Name = "btRule";
            this.btRule.Size = new System.Drawing.Size(74, 43);
            this.btRule.TabIndex = 11;
            this.btRule.Text = "Rule";
            this.btRule.UseVisualStyleBackColor = false;
            this.btRule.Click += new System.EventHandler(this.btRule_Click);
            // 
            // pnlgame
            // 
            this.pnlgame.BackgroundImage = global::Client.Properties.Resources.bgcaro;
            this.pnlgame.Controls.Add(this.pictureBox3);
            this.pnlgame.Controls.Add(this.lbidphong);
            this.pnlgame.Controls.Add(this.rtbchat);
            this.pnlgame.Controls.Add(this.panel1);
            this.pnlgame.Controls.Add(this.rtbcontentchat);
            this.pnlgame.Controls.Add(this.btRule);
            this.pnlgame.Controls.Add(this.tbYou);
            this.pnlgame.Controls.Add(this.tbComp);
            this.pnlgame.Location = new System.Drawing.Point(0, 0);
            this.pnlgame.Name = "pnlgame";
            this.pnlgame.Size = new System.Drawing.Size(802, 545);
            this.pnlgame.TabIndex = 9;
            this.pnlgame.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Client.Properties.Resources.thoa;
            this.pictureBox3.Location = new System.Drawing.Point(734, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 51);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lbidphong
            // 
            this.lbidphong.AutoSize = true;
            this.lbidphong.BackColor = System.Drawing.Color.Transparent;
            this.lbidphong.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbidphong.ForeColor = System.Drawing.Color.White;
            this.lbidphong.Location = new System.Drawing.Point(301, 32);
            this.lbidphong.Name = "lbidphong";
            this.lbidphong.Size = new System.Drawing.Size(33, 31);
            this.lbidphong.TabIndex = 9;
            this.lbidphong.Text = "0";
            // 
            // rtbchat
            // 
            this.rtbchat.BackColor = System.Drawing.Color.LightCyan;
            this.rtbchat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbchat.Location = new System.Drawing.Point(635, 516);
            this.rtbchat.Name = "rtbchat";
            this.rtbchat.Size = new System.Drawing.Size(165, 28);
            this.rtbchat.TabIndex = 7;
            this.rtbchat.Text = "";
            this.rtbchat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbchat_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(186, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 401);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // rtbcontentchat
            // 
            this.rtbcontentchat.BackColor = System.Drawing.Color.LightCyan;
            this.rtbcontentchat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbcontentchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbcontentchat.Location = new System.Drawing.Point(634, 390);
            this.rtbcontentchat.Name = "rtbcontentchat";
            this.rtbcontentchat.Size = new System.Drawing.Size(166, 123);
            this.rtbcontentchat.TabIndex = 6;
            this.rtbcontentchat.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Client.Properties.Resources.bgchat;
            this.pictureBox2.Location = new System.Drawing.Point(679, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 49);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.bgchat;
            this.pictureBox1.Location = new System.Drawing.Point(44, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 541);
            this.Controls.Add(this.plroom);
            this.Controls.Add(this.pnlgame);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGame_FormClosing);
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.plroom.ResumeLayout(false);
            this.plroom.PerformLayout();
            this.pnlgame.ResumeLayout(false);
            this.pnlgame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbcontentchat;
        private System.Windows.Forms.RichTextBox rtbchat;
        private System.Windows.Forms.Panel pnlgame;
        private System.Windows.Forms.Label lbidphong;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel plroom;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ListBox ltbListRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCreateRoom;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Button btRule;
        private Label label2;
        private ListBox lbPlayer;
        private Button btLoadPlayer;
        private Button btLoadRoom;
        private TextBox tbYou;
        private TextBox tbComp;
    }
}