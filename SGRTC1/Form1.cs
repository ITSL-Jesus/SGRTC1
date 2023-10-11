using System.Drawing.Drawing2D;

namespace SGRTC1
{
    public partial class Form1 : Form
    {
        SQLController sql = new SQLController();
        private bool mousePresionado = false;
        private Point posicionInicial;

        public Form1()
        {
            InitializeComponent();
            pnl_data.BackColor = Color.FromArgb(80, Color.Black);
            pnlTask.MouseDown += pnlTask_MouseDown;
            pnlTask.MouseMove += pnlTask_MouseMove;
            pnlTask.MouseUp += pnlTask_MouseUp;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pnlTask_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePresionado = true;
                posicionInicial = new Point(e.X, e.Y);
            }
        }

        private void pnlTask_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePresionado)
            {
                // Calcula la posición nueva de la forma
                int deltaX = e.X - posicionInicial.X;
                int deltaY = e.Y - posicionInicial.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void pnlTask_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePresionado = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int reslut = sql.Login(txtUser.Text, txtPass.Text);

            if (reslut == 1)
            {
                Form2 call = new Form2();
                this.Hide();
                call.ShowDialog();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas!");
            }
        }

        private void txtUser_DoubleClick(object sender, EventArgs e)
        {
            txtUser.Text = "";
        }

        private void txtPass_DoubleClick(object sender, EventArgs e)
        {
            txtPass.Text = "";
        }

    }
}