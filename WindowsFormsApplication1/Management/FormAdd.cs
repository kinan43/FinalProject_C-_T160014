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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            algorythmList al = new algorythmList();
            al.Name = this.txtName.Text;
            al.Description = this.txtDescription.Text;
            al.Syntax = this.txtSyntax.Text;
            try
            {
                var db = new AlgorythmEntities3();
                db.algorythmLists.Add(al);
                db.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
