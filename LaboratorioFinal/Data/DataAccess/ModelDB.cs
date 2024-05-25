using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioFinal.Data.DataAccess
{
    internal class ModelDB
    {
        string connectionString = "server=localhost;database=LaboratorioCRUD;user=root;password=";
        MySqlConnection connection;

        //constructor
        public ModelDB()
        {
            connection = new MySqlConnection(connectionString);
        }

            public void Insertar(int id_consola, string nombre_consola, string compania, string anio_lanzamiento, int generacion)
            {
                try
                {
                    string query = "INSERT INTO catalogo_consolas (id_consola, nombre_consola, compania, anio_lanzamiento, generacion) VALUES (@id_consola, @nombre_consola, @compania, @anio_lanzamiento, @generacioin)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id_consola", id_consola);
                    cmd.Parameters.AddWithValue("@nombre_consola", nombre_consola);
                    cmd.Parameters.AddWithValue("@compania", compania);
                    cmd.Parameters.AddWithValue("@anio_lanzamiento", generacion);
                    cmd.Parameters.AddWithValue("@generacion", generacion); 

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el registro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

      












        }
}
