namespace Server
{
    partial class FormServer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbActivityHis = new System.Windows.Forms.RichTextBox();
            this.btOpenServ = new System.Windows.Forms.Button();
            this.btCloseServ = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Red;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.tbActivityHis);
            this.groupBox1.Controls.Add(this.btOpenServ);
            this.groupBox1.Controls.Add(this.btCloseServ);
            this.groupBox1.Location = new System.Drawing.Point(3, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(439, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tbActivityHis
            // 
            this.tbActivityHis.BackColor = System.Drawing.Color.Khaki;
            this.tbActivityHis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbActivityHis.Location = new System.Drawing.Point(8, 170);
            this.tbActivityHis.Margin = new System.Windows.Forms.Padding(4);
            this.tbActivityHis.Name = "tbActivityHis";
            this.tbActivityHis.Size = new System.Drawing.Size(423, 143);
            this.tbActivityHis.TabIndex = 0;
            this.tbActivityHis.Text = "";
            // 
            // btOpenServ
            // 
            this.btOpenServ.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenServ.Location = new System.Drawing.Point(115, 73);
            this.btOpenServ.Margin = new System.Windows.Forms.Padding(4);
            this.btOpenServ.Name = "btOpenServ";
            this.btOpenServ.Size = new System.Drawing.Size(174, 46);
            this.btOpenServ.TabIndex = 0;
            this.btOpenServ.Text = "Open Server";
            this.btOpenServ.UseVisualStyleBackColor = true;
            this.btOpenServ.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCloseServ
            // 
            this.btCloseServ.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btCloseServ.Location = new System.Drawing.Point(115, 73);
            this.btCloseServ.Margin = new System.Windows.Forms.Padding(4);
            this.btCloseServ.Name = "btCloseServ";
            this.btCloseServ.Size = new System.Drawing.Size(174, 46);
            this.btCloseServ.TabIndex = 2;
            this.btCloseServ.Text = "Close Server";
            this.btCloseServ.UseVisualStyleBackColor = true;
            this.btCloseServ.Visible = false;
            this.btCloseServ.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::Server.Properties.Resources.ava;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Location = new System.Drawing.Point(533, 51);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(101, 94);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btClose.Location = new System.Drawing.Point(502, 221);
            this.btClose.Margin = new System.Windows.Forms.Padding(4);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(172, 46);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Exit";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(739, 351);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormServer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox tbActivityHis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btOpenServ;
        private System.Windows.Forms.Button btCloseServ;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

