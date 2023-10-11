using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGRTC1
{
    public partial class Form2 : Form
    {
        SQLController sql = new SQLController();
        private bool mousePresionado = false;
        private Point posicionInicial;

        public Form2()
        {
            InitializeComponent();
            pnlTask.MouseDown += pnlTask_MouseDown;
            pnlTask.MouseMove += pnlTask_MouseMove;
            pnlTask.MouseUp += pnlTask_MouseUp;

            // Suscribe el evento SelectionChanged del DataGridView
            dataGV.SelectionChanged += new EventHandler(dataGV_SelectionChanged);
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

        private void button1_Click(object sender, EventArgs e)
        {
            sql.viewPhones(dataGV, panel3);

        }

        private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn selectedColumn = dataGV.Columns[e.ColumnIndex];

                // Crear un Label
                Label label = new Label();
                label.Text = selectedColumn.HeaderText;
                label.Location = new Point(10, 10);  // Ajusta la posición según tu diseño
                label.Parent = panel3;  // Establecer el Panel como el contenedor padre

                // Crear un TextBox
                TextBox textBox = new TextBox();
                textBox.Location = new Point(label.Location.X + label.Width + 10, 10);  // Ajusta la posición según tu diseño
                textBox.Parent = panel3;  // Establecer el Panel como el contenedor padre
            }
        }
        private void dataGV_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGV.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGV.SelectedCells[0].RowIndex;

                // Obtener los valores de las celdas para las TextBox
                foreach (DataGridViewColumn column in dataGV.Columns)
                {
                    // Encuentra el TextBox correspondiente a cada columna por su nombre
                    Control[] controls = pnlMenu.Controls.Find("textBox_" + column.Name, true);
                    if (controls.Length > 0 && controls[0] is TextBox)
                    {
                        TextBox textBox = (TextBox)controls[0];
                        textBox.Text = dataGV[column.Index, selectedRowIndex].Value.ToString();
                    }
                }
            }
        }
        public void ObtenerValoresTxAlta()
        {
            int celularID = 0;
            string marca = string.Empty;
            string modelo = string.Empty;
            string imei = string.Empty;
            string estado = string.Empty;

            // Obtener los valores de los TextBox desde la lista
            if (sql.TextBoxes.Count >= 5)  // Asegúrate de tener al menos 5 TextBoxes
            {
                celularID = int.Parse(sql.TextBoxes[0].Text);
                marca = sql.TextBoxes[1].Text;
                modelo = sql.TextBoxes[2].Text;
                imei = sql.TextBoxes[3].Text;
                estado = sql.TextBoxes[4].Text;
            }

            // Llamar a AltaCelular con los valores obtenidos
            sql.AltaCelular(celularID, marca, modelo, imei, estado);
        }
        public void ObtenerValoresTxMod()
        {
            int celularID = 0;
            string marca = string.Empty;
            string modelo = string.Empty;
            string imei = string.Empty;
            string estado = string.Empty;

            // Obtener los valores de los TextBox desde la lista
            if (sql.TextBoxes.Count >= 5)  // Asegúrate de tener al menos 5 TextBoxes
            {
                celularID = int.Parse(sql.TextBoxes[0].Text);
                marca = sql.TextBoxes[1].Text;
                modelo = sql.TextBoxes[2].Text;
                imei = sql.TextBoxes[3].Text;
                estado = sql.TextBoxes[4].Text;
            }

            // Llamar a AltaCelular con los valores obtenidos
            sql.ModificarCelular(celularID, marca, modelo, imei, estado);
        }
        public void ObtenerValoresTxDel()
        {
            int celularID = 0;

            // Obtener los valores de los TextBox desde la lista
            if (sql.TextBoxes.Count >= 5)  // Asegúrate de tener al menos 5 TextBoxes
            {
                celularID = int.Parse(sql.TextBoxes[0].Text);
            }

            // Llamar a AltaCelular con los valores obtenidos
            sql.EliminarCelular(celularID);
        }
        private void btnSend_Click(object sender, EventArgs e)
        {

            ObtenerValoresTxAlta();
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            ObtenerValoresTxMod();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            ObtenerValoresTxDel();
        }
    }
}
