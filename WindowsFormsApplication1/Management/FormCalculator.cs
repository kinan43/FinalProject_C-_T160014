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
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            int a = int.Parse(this.txtA.Text);
            int b = int.Parse(this.txtB.Text);
            int rs = a + b;

            this.txtResult.Text = rs.ToString();
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            int a = int.Parse(this.txtA.Text);
            int b = int.Parse(this.txtB.Text);
            int rs = a - b;

            this.txtResult.Text = rs.ToString();
        }

        private void btMultiply_Click(object sender, EventArgs e)
        {
            int a = int.Parse(this.txtA.Text);
            int b = int.Parse(this.txtB.Text);
            int rs = a * b;

            this.txtResult.Text = rs.ToString();
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            int a = int.Parse(this.txtA.Text);
            int b = int.Parse(this.txtB.Text);
            int rs = a / b;

            this.txtResult.Text = rs.ToString();
        }
    }
}
