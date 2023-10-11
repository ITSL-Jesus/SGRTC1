namespace SGRTC1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pnlTask = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnClose = new Button();
            panel2 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtName = new Label();
            txtTypeUser = new Label();
            pictureBox2 = new PictureBox();
            pnlMenu = new Panel();
            btnMod = new Button();
            btnSend = new Button();
            btnDel = new Button();
            panel3 = new Panel();
            dataGV = new DataGridView();
            button7 = new Button();
            pnlTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGV).BeginInit();
            SuspendLayout();
            // 
            // pnlTask
            // 
            pnlTask.BackColor = Color.White;
            pnlTask.Controls.Add(label2);
            pnlTask.Controls.Add(pictureBox1);
            pnlTask.Controls.Add(label1);
            pnlTask.Controls.Add(btnClose);
            pnlTask.Dock = DockStyle.Top;
            pnlTask.ForeColor = Color.White;
            pnlTask.Location = new Point(0, 0);
            pnlTask.Name = "pnlTask";
            pnlTask.RightToLeft = RightToLeft.Yes;
            pnlTask.Size = new Size(1000, 30);
            pnlTask.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 3);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "MAGJ@";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(450, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(472, 6);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 4;
            label1.Text = "SGRTC One";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(970, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(txtTypeUser);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(181, 570);
            panel2.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackColor = Color.Gray;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleRight;
            button6.Location = new Point(0, 427);
            button6.Name = "button6";
            button6.Size = new Size(180, 60);
            button6.TabIndex = 8;
            button6.Text = "Configuracion";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(0, 364);
            button5.Name = "button5";
            button5.Size = new Size(180, 60);
            button5.TabIndex = 7;
            button5.Text = "Bitacora";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(0, 301);
            button4.Name = "button4";
            button4.Size = new Size(180, 60);
            button4.TabIndex = 6;
            button4.Text = "Clientes";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(0, 238);
            button3.Name = "button3";
            button3.Size = new Size(180, 60);
            button3.TabIndex = 5;
            button3.Text = "Personal";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(0, 175);
            button2.Name = "button2";
            button2.Size = new Size(180, 60);
            button2.TabIndex = 4;
            button2.Text = "Refacciones";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(0, 112);
            button1.Name = "button1";
            button1.Size = new Size(180, 60);
            button1.TabIndex = 3;
            button1.Text = "Celulares";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(82, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(90, 20);
            txtName.TabIndex = 2;
            txtName.Text = "Marco";
            txtName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTypeUser
            // 
            txtTypeUser.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTypeUser.Location = new Point(82, 50);
            txtTypeUser.Name = "txtTypeUser";
            txtTypeUser.Size = new Size(90, 20);
            txtTypeUser.TabIndex = 1;
            txtTypeUser.Text = "Administrador";
            txtTypeUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(12, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Gainsboro;
            pnlMenu.Controls.Add(button7);
            pnlMenu.Controls.Add(btnMod);
            pnlMenu.Controls.Add(btnSend);
            pnlMenu.Controls.Add(btnDel);
            pnlMenu.Controls.Add(panel3);
            pnlMenu.Controls.Add(dataGV);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Location = new Point(181, 30);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(819, 570);
            pnlMenu.TabIndex = 2;
            // 
            // btnMod
            // 
            btnMod.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMod.Image = (Image)resources.GetObject("btnMod.Image");
            btnMod.ImageAlign = ContentAlignment.MiddleRight;
            btnMod.Location = new Point(437, 374);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(130, 50);
            btnMod.TabIndex = 2;
            btnMod.Text = "Modificar";
            btnMod.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSend.Image = (Image)resources.GetObject("btnSend.Image");
            btnSend.ImageAlign = ContentAlignment.MiddleRight;
            btnSend.Location = new Point(603, 374);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(130, 50);
            btnSend.TabIndex = 2;
            btnSend.Text = "Actualiza Tabla";
            btnSend.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnDel
            // 
            btnDel.BackgroundImageLayout = ImageLayout.Center;
            btnDel.Cursor = Cursors.Hand;
            btnDel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.Image = (Image)resources.GetObject("btnDel.Image");
            btnDel.ImageAlign = ContentAlignment.MiddleRight;
            btnDel.Location = new Point(603, 453);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(130, 50);
            btnDel.TabIndex = 2;
            btnDel.Text = "Eliminar";
            btnDel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(36, 349);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 200);
            panel3.TabIndex = 1;
            // 
            // dataGV
            // 
            dataGV.AllowUserToAddRows = false;
            dataGV.AllowUserToDeleteRows = false;
            dataGV.BackgroundColor = Color.LightGray;
            dataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGV.GridColor = Color.White;
            dataGV.Location = new Point(36, 29);
            dataGV.Name = "dataGV";
            dataGV.ReadOnly = true;
            dataGV.RowTemplate.Height = 25;
            dataGV.Size = new Size(750, 300);
            dataGV.TabIndex = 0;
            dataGV.CellClick += dataGV_CellClick;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleRight;
            button7.Location = new Point(437, 453);
            button7.Name = "button7";
            button7.Size = new Size(130, 50);
            button7.TabIndex = 3;
            button7.Text = "Crear";
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(pnlMenu);
            Controls.Add(panel2);
            Controls.Add(pnlTask);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            pnlTask.ResumeLayout(false);
            pnlTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTask;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnClose;
        private Panel panel2;
        private Panel pnlMenu;
        private Label txtName;
        private Label txtTypeUser;
        private PictureBox pictureBox2;
        private Label label2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private DataGridView dataGV;
        private Panel panel3;
        private Button btnMod;
        private Button btnSend;
        private Button btnDel;
        private Button button7;
    }
}