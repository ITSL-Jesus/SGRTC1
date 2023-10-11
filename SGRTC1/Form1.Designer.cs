namespace SGRTC1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlTask = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnClose = new Button();
            pnl_data = new Panel();
            pbxPass = new PictureBox();
            pbxUser = new PictureBox();
            lblPass = new Label();
            lblUser = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnStart = new Button();
            pnlTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnl_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxUser).BeginInit();
            SuspendLayout();
            // 
            // pnlTask
            // 
            pnlTask.BackColor = Color.White;
            pnlTask.Controls.Add(pictureBox1);
            pnlTask.Controls.Add(label1);
            pnlTask.Controls.Add(btnClose);
            pnlTask.Dock = DockStyle.Top;
            pnlTask.Location = new Point(0, 0);
            pnlTask.Name = "pnlTask";
            pnlTask.Size = new Size(750, 30);
            pnlTask.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 30);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(33, 7);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 1;
            label1.Text = "SGRTC One";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(720, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pnl_data
            // 
            pnl_data.BackColor = Color.Black;
            pnl_data.Controls.Add(pbxPass);
            pnl_data.Controls.Add(pbxUser);
            pnl_data.Controls.Add(lblPass);
            pnl_data.Controls.Add(lblUser);
            pnl_data.Controls.Add(label2);
            pnl_data.Controls.Add(txtUser);
            pnl_data.Controls.Add(txtPass);
            pnl_data.Controls.Add(btnStart);
            pnl_data.Location = new Point(27, 91);
            pnl_data.Name = "pnl_data";
            pnl_data.Size = new Size(276, 342);
            pnl_data.TabIndex = 1;
            // 
            // pbxPass
            // 
            pbxPass.BackColor = Color.Transparent;
            pbxPass.BackgroundImage = (Image)resources.GetObject("pbxPass.BackgroundImage");
            pbxPass.BackgroundImageLayout = ImageLayout.Zoom;
            pbxPass.Location = new Point(15, 160);
            pbxPass.Name = "pbxPass";
            pbxPass.Size = new Size(30, 30);
            pbxPass.TabIndex = 7;
            pbxPass.TabStop = false;
            // 
            // pbxUser
            // 
            pbxUser.BackColor = Color.Transparent;
            pbxUser.BackgroundImage = (Image)resources.GetObject("pbxUser.BackgroundImage");
            pbxUser.BackgroundImageLayout = ImageLayout.Zoom;
            pbxUser.Location = new Point(15, 103);
            pbxUser.Name = "pbxUser";
            pbxUser.Size = new Size(30, 30);
            pbxUser.TabIndex = 6;
            pbxUser.TabStop = false;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = Color.Transparent;
            lblPass.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.ForeColor = Color.White;
            lblPass.Location = new Point(108, 145);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(66, 17);
            lblPass.TabIndex = 5;
            lblPass.Text = "Password";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(108, 90);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(69, 17);
            lblUser.TabIndex = 4;
            lblUser.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(108, 13);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 3;
            label2.Text = "Log In ";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.Gray;
            txtUser.Location = new Point(51, 110);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(200, 23);
            txtUser.TabIndex = 2;
            txtUser.Text = "Type here!";
            txtUser.DoubleClick += txtUser_DoubleClick;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(51, 165);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.Size = new Size(200, 25);
            txtPass.TabIndex = 1;
            txtPass.Text = "Secret";
            txtPass.DoubleClick += txtPass_DoubleClick;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Transparent;
            btnStart.BackgroundImageLayout = ImageLayout.None;
            btnStart.Cursor = Cursors.Hand;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btnStart.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(99, 263);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 30);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Visible = false;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(750, 500);
            Controls.Add(pnl_data);
            Controls.Add(pnlTask);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlTask.ResumeLayout(false);
            pnlTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnl_data.ResumeLayout(false);
            pnl_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTask;
        private Button btnClose;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel pnl_data;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnStart;
        private Label lblPass;
        private Label lblUser;
        private PictureBox pbxPass;
        private PictureBox pbxUser;
    }
}