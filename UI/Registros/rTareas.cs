using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tasks_System_Win.Entidades;

namespace Tasks_System_Win.UI.Registros
{
    public partial class rTareas : Form
    {
        public rTareas()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdTextBox.Clear();
            NombreTextBox.Clear();
            DescripcionTextBox.Clear();

        }

        private void LlenaCampos(Tareas tarea)
        {
            //IdTextBox.Text = tarea.TareaId;
            NombreTextBox.Text = tarea.Nombre;
            DescripcionTextBox.Text = tarea.Descripcion;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
