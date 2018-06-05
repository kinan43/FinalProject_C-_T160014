namespace WindowsFormsApplication1.Management
{
    partial class FormAlgorythm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.btDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lstAlgorythm = new System.Windows.Forms.DataGridView();
            this.algorythmListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.algorythmEntities3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstAlgorythm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.algorythmListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.algorythmEntities3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.btRefresh,
            this.btDelete});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btAdd
            // 
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(66, 20);
            this.btAdd.Text = "Add new";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(58, 20);
            this.btRefresh.Text = "Refresh";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btDelete
            // 
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(52, 20);
            this.btDelete.Text = "Delete";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // lstAlgorythm
            // 
            this.lstAlgorythm.AllowUserToAddRows = false;
            this.lstAlgorythm.AllowUserToDeleteRows = false;
            this.lstAlgorythm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstAlgorythm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAlgorythm.Location = new System.Drawing.Point(0, 24);
            this.lstAlgorythm.Name = "lstAlgorythm";
            this.lstAlgorythm.ReadOnly = true;
            this.lstAlgorythm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstAlgorythm.Size = new System.Drawing.Size(744, 237);
            this.lstAlgorythm.TabIndex = 1;
            this.lstAlgorythm.DoubleClick += new System.EventHandler(this.lstAlgorythm_DoubleClick);
            // 
            // algorythmListBindingSource
            // 
            this.algorythmListBindingSource.DataSource = typeof(WindowsFormsApplication1.algorythmList);
            // 
            // algorythmEntities3BindingSource
            // 
            this.algorythmEntities3BindingSource.DataSource = typeof(WindowsFormsApplication1.AlgorythmEntities3);
            // 
            // FormAlgorythm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 261);
            this.Controls.Add(this.lstAlgorythm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAlgorythm";
            this.Text = "Algorythm";
            this.Load += new System.EventHandler(this.FormAlgorythm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstAlgorythm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.algorythmListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.algorythmEntities3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btAdd;
        private System.Windows.Forms.ToolStripMenuItem btRefresh;
        private System.Windows.Forms.ToolStripMenuItem btDelete;
        private System.Windows.Forms.DataGridView lstAlgorythm;
        private System.Windows.Forms.BindingSource algorythmListBindingSource;
        private System.Windows.Forms.BindingSource algorythmEntities3BindingSource;
    }
}