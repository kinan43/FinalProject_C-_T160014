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
    public partial class FormEdit : Form
    {
        public FormEdit(algorythmList al)
        {
            InitializeComponent();
            this.al = al;
        }

        private algorythmList al;

        private void FormEdit_Load(object sender, EventArgs e)
        {
            var db = new AlgorythmEntities3();

            this.textName.Text = this.al.Name;
            this.textDescription.Text = this.al.Description;
            this.textSyntax.Text = this.al.Syntax;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new AlgorythmEntities3();
                var newAl = db.algorythmLists.Find(this.al.Id);
                newAl.Name = this.textName.Text;
                newAl.Description = this.textDescription.Text;
                newAl.Syntax = this.textSyntax.Text;
                db.Entry(newAl).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
