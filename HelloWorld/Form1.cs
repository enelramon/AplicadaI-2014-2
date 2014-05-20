using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  /// <summary>
  /// Este metodo mustra el mensaje pasado como parametro.
  /// </summary>
  /// <param name="mensajeMostrar">este es el mensaje a desplegar</param>
        private void MostrarMensaje( string mensajeMostrar)
        {
            MessageBox.Show(mensajeMostrar, "saludo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
 
        }

        private void Saludarbutton_Click(object sender, EventArgs e)
        {
            
            MostrarMensaje("Hola");     
        }

        private void Salirbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes) 
            {
                 this.Close();
            }

           
       
        }
    }
}
