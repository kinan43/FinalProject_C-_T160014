using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Management
{
    public partial class FormChoose : Form
    {
        public FormChoose()
        {
            InitializeComponent();
        }

        private void btCalculator_Click(object sender, EventArgs e)
        {
            var form = new FormCalculator();
            form.ShowDialog();
        }

        private void btAlgorythm_Click(object sender, EventArgs e)
        {
            var form = new FormAlgorythm();
            form.ShowDialog();
        }
    }
}
