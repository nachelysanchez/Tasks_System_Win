using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tasks_System_Win.BLL;
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
            IdTextBox.Text = tarea.TareaId.ToString();
            NombreTextBox.Text = tarea.Nombre;
            DescripcionTextBox.Text = tarea.Descripcion;
        }

        private Tareas LlenaClase()
        {
            Tareas tarea = new Tareas();

            tarea.TareaId = Utilidades.ToInt(IdTextBox.Text);
            tarea.Nombre = NombreTextBox.Text;
            tarea.Descripcion = DescripcionTextBox.Text;

            return tarea;
        }

        private bool Validar()
        {
            bool esValido = true;
            if (NombreTextBox.Text.Length == 0)
            {
                MessageBox.Show("Debe de completar el campo 'Nombre'");
                NombreTextBox.Focus();
                esValido = false;
            }
            else if (DescripcionTextBox.Text.Length == 0)
            {
                MessageBox.Show("Debe de completar el campo 'Descripcion'");
                DescripcionTextBox.Focus();
                esValido = false;
            }
            return esValido;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var tarea = TareasBLL.Buscar(Utilidades.ToInt(IdTextBox.Text));
            if (tarea != null)
            {
                LlenaCampos(tarea);
            }
            else
            {
                MessageBox.Show("Tarea no encontrada", "Error");
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Tareas tarea;
            if (!Validar())
            {
                return;
            }
            if (TareasBLL.ExisteNombre(NombreTextBox.Text))
            {
                MessageBox.Show("Ya existe esta tarea. Ingrese otra", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            tarea = LlenaClase();
            var paso = TareasBLL.Guardar(tarea);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("La tarea ha sido guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("La tarea no ha sido guardado con exito", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (TareasBLL.Eliminar(Utilidades.ToInt(IdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Tarea eliminada", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La tarea no se logro eliminar", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
