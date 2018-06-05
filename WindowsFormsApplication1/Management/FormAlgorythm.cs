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
    public partial class FormAlgorythm : Form
    {
        public FormAlgorythm()
        {
            InitializeComponent();
        }

        private void FormAlgorythm_Load(object sender, EventArgs e)
        {
            this.ShowAlgorythmList();
        }

        public void ShowAlgorythmList()
        {
            AlgorythmEntities3 db = new AlgorythmEntities3();
            var list = db.algorythmLists.ToList();
            this.lstAlgorythm.DataSource = list;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var form = new FormAdd();
            form.ShowDialog();
            this.ShowAlgorythmList();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            this.ShowAlgorythmList();
        }

        private void lstAlgorythm_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstAlgorythm.SelectedRows.Count == 1)
            {
                var row = this.lstAlgorythm.SelectedRows[0];
                var item = (algorythmList)row.DataBoundItem;

                var form = new FormEdit(item);
                form.ShowDialog();
                this.ShowAlgorythmList();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            var db = new AlgorythmEntities3();
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < this.lstAlgorythm.SelectedRows.Count; i++)
                {
                    var row = this.lstAlgorythm.SelectedRows[i];
                    var item = (algorythmList)row.DataBoundItem;
                    try
                    {
                        algorythmList al = db.algorythmLists.Find(item.Id);
                        db.algorythmLists.Remove(al);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot delete student" + item);
                    }
                }
            }
            this.ShowAlgorythmList();
        }
    }
}
