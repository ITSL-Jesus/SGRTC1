using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SGRTC1
{
    internal class SQLController
    {
        private SqlConnection con = new SqlConnection(@"Server=SYSTEM\SQLEXPRESS;Database=SGRTC1;Integrated Security=True;");
        public List<TextBox> TextBoxes { get; private set; } = new List<TextBox>();

        public int Login(string user, string pass)
        {
            int personalID = -1;  // Valor por defecto en caso de que no se encuentre un resultado

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("IniciarSesionPersonal", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", user);
                cmd.Parameters.AddWithValue("@Contraseña", pass);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    personalID = dr.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return personalID;  // Retornar el valor obtenido (puede ser -1 si no se encontró un resultado)
        }

        public void viewPhones(DataGridView dataGridView, Panel panel)
        {
            try
            {
                // Limpiar el DataGridView y el Panel
                dataGridView.Columns.Clear();
                panel.Controls.Clear();

                // Abrir la conexión a la base de datos.
                if (con.State == ConnectionState.Closed)
                    con.Open();

                // Crear un nuevo objeto SqlCommand y pasar la consulta SQL como parámetro al constructor.
                SqlCommand cmd = new SqlCommand("SELECT * FROM Celular;", con);

                // Ejecutar la consulta SQL.
                SqlDataReader reader = cmd.ExecuteReader();

                // Obtener los nombres de las columnas
                if (reader.HasRows)
                {
                    // Agregar columnas al DataGridView
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataGridView.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    // Crear TextBox y Label para cada columna en el Panel
                    CrearControlesEnPanel(dataGridView,panel);
                }

                List<string[]> rows = new List<string[]>();

                // Llenar el DataGridView con los datos de la consulta SQL.
                while (reader.Read())
                {
                    // Obtener los datos de la consulta SQL.
                    string[] rowValues = new string[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        rowValues[i] = reader[i].ToString();
                    }

                    // Agregar los datos a la lista de filas
                    rows.Add(rowValues);
                }

                // Cerrar el lector de datos.
                reader.Close();

                // Llenar el DataGridView con las filas obtenidas
                FillDataGridView(dataGridView, rows);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Cerrar la conexión a la base de datos si está abierta.
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void CrearControlesEnPanel(DataGridView dataGridView, Panel panel)
        {
            int labelX = 10;
            int labelY = 10;
            int textBoxX = labelX + 100;
            int textBoxY = 10;
            int spacing = 30;

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                // Crear y agregar la etiqueta al panel
                Label label = CrearEtiqueta(dataGridView.Columns[i].HeaderText, new Point(labelX, labelY));
                panel.Controls.Add(label);

                // Crear y agregar el cuadro de texto al panel
                System.Windows.Forms.TextBox textBox = CrearTextBox("textBox_" + dataGridView.Columns[i].HeaderText, new Point(textBoxX, textBoxY));
                panel.Controls.Add(textBox);

                // Agregar el TextBox a la lista
                TextBoxes.Add(textBox);

                // Ajustar las posiciones para el siguiente par Label-TextBox
                labelY += spacing;
                textBoxY += spacing;
            }
        }

        private Label CrearEtiqueta(string labelText, Point location)
        {
            Label label = new Label();
            label.Text = labelText;
            label.Location = location;
            return label;
        }

        private System.Windows.Forms.TextBox CrearTextBox(string textBoxName, Point location)
        {
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            textBox.Name = textBoxName;
            textBox.Location = location;
            return textBox;
        }

        private void FillDataGridView(DataGridView dataGridView, List<string[]> rows)
        {
            foreach (var row in rows)
            {
                dataGridView.Rows.Add(row);
            }
        }

        public void AltaCelular(int celularID, string marca, string modelo, string imei, string estado)
        {
            try
            {
                // Abrir la conexión a la base de datos.
                con.Open();

                // Crear un nuevo objeto SqlCommand y pasar el nombre del procedimiento almacenado y la conexión.
                SqlCommand cmd = new SqlCommand("sp_AltaCelular", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros
                cmd.Parameters.AddWithValue("@CelularID", celularID);
                cmd.Parameters.AddWithValue("@Marca", marca);
                cmd.Parameters.AddWithValue("@Modelo", modelo);
                cmd.Parameters.AddWithValue("@IMEI", imei);
                cmd.Parameters.AddWithValue("@Estado", estado);

                // Ejecutar el comando
                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ha dado de alta un nuevo celular.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void ModificarCelular(int celularID, string marca, string modelo, string imei, string estado)
        {
            try
            {
                // Abrir la conexión a la base de datos.
                con.Open();

                // Crear un nuevo objeto SqlCommand y pasar el nombre del procedimiento almacenado y la conexión.
                SqlCommand cmd = new SqlCommand("sp_ModificarCelular", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros
                cmd.Parameters.AddWithValue("@CelularID", celularID);
                cmd.Parameters.AddWithValue("@Marca", marca);
                cmd.Parameters.AddWithValue("@Modelo", modelo);
                cmd.Parameters.AddWithValue("@IMEI", imei);
                cmd.Parameters.AddWithValue("@Estado", estado);

                // Ejecutar el comando
                cmd.ExecuteNonQuery();

                MessageBox.Show("La información del celular se ha actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void EliminarCelular(int celularID)
        {
            try
            {
                // Abrir la conexión a la base de datos.
                con.Open();

                // Crear un nuevo objeto SqlCommand y pasar el nombre del procedimiento almacenado y la conexión.
                SqlCommand cmd = new SqlCommand("sp_EliminarCelular", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros
                cmd.Parameters.AddWithValue("@CelularID", celularID);

                // Ejecutar el comando
                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ha eliminado el celular con CelularID " + celularID + ".");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
