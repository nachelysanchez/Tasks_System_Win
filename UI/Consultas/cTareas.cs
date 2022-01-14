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

namespace Tasks_System_Win.UI.Consultas
{
    public partial class cTareas : Form
    {
        
        public cTareas()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            List<Tareas> listado = new List<Tareas>();
            string criterio = CriterioTextBox.Text.Trim();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: // Todos
                        listado = TareasBLL.GetTareas();
                        break;
                    case 1: //Id
                        listado = TareasBLL.GetList(t => t.TareaId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;
                    case 2: //Nombres
                        listado = TareasBLL.GetList(t => t.Nombre.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;
                    case 3: //Descripcion
                        listado = TareasBLL.GetList(t => t.Descripcion.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;
                }
            }
            else
            {
                listado = TareasBLL.GetList(t => true);
            }
            DataGridDatos.DataSource = null;
            DataGridDatos.DataSource = listado;
        }
    }
}
