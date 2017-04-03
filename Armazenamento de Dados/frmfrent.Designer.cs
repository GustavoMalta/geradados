namespace Armazenamento_de_Dados
{
    partial class frmfrent
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
            this.dgvtipo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtipo
            // 
            this.dgvtipo.AllowUserToAddRows = false;
            this.dgvtipo.AllowUserToDeleteRows = false;
            this.dgvtipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome});
            this.dgvtipo.Location = new System.Drawing.Point(2, -1);
            this.dgvtipo.Name = "dgvtipo";
            this.dgvtipo.ReadOnly = true;
            this.dgvtipo.Size = new System.Drawing.Size(281, 264);
            this.dgvtipo.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "FRENTID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "FRENTNOME";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // frmfrent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dgvtipo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmfrent";
            this.Text = "frmfrent";
            this.Load += new System.EventHandler(this.frmfrent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}