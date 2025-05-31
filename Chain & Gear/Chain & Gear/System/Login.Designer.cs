namespace Chain___Gear
{
    partial class Login
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
            this.mainPnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logPnl = new System.Windows.Forms.Panel();
            this.signupBtn = new System.Windows.Forms.Button();
            this.passLbl = new System.Windows.Forms.Label();
            this.uIDLbl = new System.Windows.Forms.Label();
            this.uidTxtbox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.passTxtbox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hidePB = new System.Windows.Forms.PictureBox();
            this.aboutLbl = new System.Windows.Forms.Label();
            this.mainPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.logPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePB)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPnl
            // 
            this.mainPnl.BackColor = System.Drawing.Color.Purple;
            this.mainPnl.Controls.Add(this.panel1);
            this.mainPnl.Controls.Add(this.pictureBox1);
            this.mainPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPnl.Location = new System.Drawing.Point(0, 0);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(1264, 644);
            this.mainPnl.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logPnl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(761, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 644);
            this.panel1.TabIndex = 7;
            // 
            // logPnl
            // 
            this.logPnl.BackColor = System.Drawing.Color.Gray;
            this.logPnl.Controls.Add(this.aboutLbl);
            this.logPnl.Controls.Add(this.hidePB);
            this.logPnl.Controls.Add(this.signupBtn);
            this.logPnl.Controls.Add(this.passLbl);
            this.logPnl.Controls.Add(this.uIDLbl);
            this.logPnl.Controls.Add(this.uidTxtbox);
            this.logPnl.Controls.Add(this.cancelBtn);
            this.logPnl.Controls.Add(this.passTxtbox);
            this.logPnl.Controls.Add(this.loginBtn);
            this.logPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logPnl.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logPnl.Location = new System.Drawing.Point(0, 413);
            this.logPnl.Name = "logPnl";
            this.logPnl.Size = new System.Drawing.Size(503, 231);
            this.logPnl.TabIndex = 5;
            // 
            // signupBtn
            // 
            this.signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBtn.Location = new System.Drawing.Point(172, 181);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(98, 38);
            this.signupBtn.TabIndex = 7;
            this.signupBtn.Text = "Sign up";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLbl.Location = new System.Drawing.Point(27, 97);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(59, 16);
            this.passLbl.TabIndex = 6;
            this.passLbl.Text = "Password";
            // 
            // uIDLbl
            // 
            this.uIDLbl.AutoSize = true;
            this.uIDLbl.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uIDLbl.Location = new System.Drawing.Point(27, 34);
            this.uIDLbl.Name = "uIDLbl";
            this.uIDLbl.Size = new System.Drawing.Size(51, 16);
            this.uIDLbl.TabIndex = 5;
            this.uIDLbl.Text = "User ID";
            // 
            // uidTxtbox
            // 
            this.uidTxtbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uidTxtbox.Location = new System.Drawing.Point(104, 26);
            this.uidTxtbox.Name = "uidTxtbox";
            this.uidTxtbox.Size = new System.Drawing.Size(241, 24);
            this.uidTxtbox.TabIndex = 3;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Location = new System.Drawing.Point(225, 133);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(97, 33);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // passTxtbox
            // 
            this.passTxtbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passTxtbox.Location = new System.Drawing.Point(104, 89);
            this.passTxtbox.Name = "passTxtbox";
            this.passTxtbox.Size = new System.Drawing.Size(241, 24);
            this.passTxtbox.TabIndex = 4;
            // 
            // loginBtn
            // 
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.loginBtn.Location = new System.Drawing.Point(122, 133);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(97, 33);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chain and Gear";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(762, 644);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // hidePB
            // 
            this.hidePB.BackColor = System.Drawing.Color.Black;
            this.hidePB.Location = new System.Drawing.Point(351, 89);
            this.hidePB.Name = "hidePB";
            this.hidePB.Size = new System.Drawing.Size(23, 24);
            this.hidePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidePB.TabIndex = 8;
            this.hidePB.TabStop = false;
            // 
            // aboutLbl
            // 
            this.aboutLbl.AutoSize = true;
            this.aboutLbl.Location = new System.Drawing.Point(411, 203);
            this.aboutLbl.Name = "aboutLbl";
            this.aboutLbl.Size = new System.Drawing.Size(80, 19);
            this.aboutLbl.TabIndex = 9;
            this.aboutLbl.Text = "About us";
            this.aboutLbl.Click += new System.EventHandler(this.aboutLbl_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 644);
            this.Controls.Add(this.mainPnl);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Chain & Gear";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.mainPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.logPnl.ResumeLayout(false);
            this.logPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passTxtbox;
        private System.Windows.Forms.TextBox uidTxtbox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel logPnl;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Label uIDLbl;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox hidePB;
        private System.Windows.Forms.Label aboutLbl;
    }
}

