using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tasks_System_Win.UI.Registros;

namespace Tasks_System_Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void registroDeTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTareas tareas = new rTareas();
            tareas.Show();
        }

        private void consultaDeTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
