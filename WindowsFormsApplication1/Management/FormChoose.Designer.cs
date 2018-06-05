namespace WindowsFormsApplication1.Management
{
    partial class FormChoose
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btCalculator = new System.Windows.Forms.Button();
            this.btAlgorythm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(284, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // btCalculator
            // 
            this.btCalculator.Location = new System.Drawing.Point(45, 136);
            this.btCalculator.Name = "btCalculator";
            this.btCalculator.Size = new System.Drawing.Size(75, 23);
            this.btCalculator.TabIndex = 1;
            this.btCalculator.Text = "Calculator";
            this.btCalculator.UseVisualStyleBackColor = true;
            this.btCalculator.Click += new System.EventHandler(this.btCalculator_Click);
            // 
            // btAlgorythm
            // 
            this.btAlgorythm.Location = new System.Drawing.Point(164, 136);
            this.btAlgorythm.Name = "btAlgorythm";
            this.btAlgorythm.Size = new System.Drawing.Size(75, 23);
            this.btAlgorythm.TabIndex = 2;
            this.btAlgorythm.Text = "Algorythm";
            this.btAlgorythm.UseVisualStyleBackColor = true;
            this.btAlgorythm.Click += new System.EventHandler(this.btAlgorythm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome, Choose one !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAlgorythm);
            this.Controls.Add(this.btCalculator);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormChoose";
            this.Text = "DinhLeHoangTai";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btCalculator;
        private System.Windows.Forms.Button btAlgorythm;
        private System.Windows.Forms.Label label1;
    }
}