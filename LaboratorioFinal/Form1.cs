using LaboratorioFinal.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioFinal
{
    public partial class Form1 : Form
    {

        //definimos una variable de instancia ref a la clase personajeDB
        private ModelDB Consola;
        // Lista de razas
        private string[] CompañiaConsolas = {
            "Atari",
            "Coleco",
            "Mattel",
            "Microsoft",
            "Nintendo",
            "Ouya Inc.",
            "Sega",
            "Sony"

};

        public Form1()
        {
            InitializeComponent();
            Consola = new ModelDB();

        }



     
        private void buttonPrueba_Click(object sender, EventArgs e)
        {
            /*
            if (Consola.ProbarConexion())
            {
                MessageBox.Show("Conectado");
            }
            else
            {
                MessageBox.Show("No conectado");
            }

            */
        }
     

        private void labelID_Click(object sender, EventArgs e)
        {

        }
    }
}
