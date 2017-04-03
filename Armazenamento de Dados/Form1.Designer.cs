namespace Armazenamento_de_Dados
{
    partial class Form1
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
            this.dgvabast = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bomba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frentista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btngera = new System.Windows.Forms.Button();
            this.txtFrentMin = new System.Windows.Forms.TextBox();
            this.txtFrentMax = new System.Windows.Forms.TextBox();
            this.txtBombMax = new System.Windows.Forms.TextBox();
            this.txtBombMin = new System.Windows.Forms.TextBox();
            this.lblbomba = new System.Windows.Forms.Label();
            this.lblfrent = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.txttipomax = new System.Windows.Forms.TextBox();
            this.txttipomin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtreg = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbldia = new System.Windows.Forms.Label();
            this.lblturno = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnapaga = new System.Windows.Forms.Button();
            this.btncarreg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkmanha = new System.Windows.Forms.CheckBox();
            this.chktarde = new System.Windows.Forms.CheckBox();
            this.chknoite = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkterca = new System.Windows.Forms.CheckBox();
            this.chkquarta = new System.Windows.Forms.CheckBox();
            this.chksexta = new System.Windows.Forms.CheckBox();
            this.chkdomingo = new System.Windows.Forms.CheckBox();
            this.chksabado = new System.Windows.Forms.CheckBox();
            this.chksegunda = new System.Windows.Forms.CheckBox();
            this.chkquinta = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvabast)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvabast
            // 
            this.dgvabast.AllowUserToAddRows = false;
            this.dgvabast.AllowUserToDeleteRows = false;
            this.dgvabast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvabast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Data,
            this.Hora,
            this.Bomba,
            this.Frentista,
            this.TipoPagamento});
            this.dgvabast.Location = new System.Drawing.Point(8, 99);
            this.dgvabast.Name = "dgvabast";
            this.dgvabast.ReadOnly = true;
            this.dgvabast.Size = new System.Drawing.Size(786, 428);
            this.dgvabast.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ABASTID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "ABASTDATA";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "ABASTHORA";
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Bomba
            // 
            this.Bomba.DataPropertyName = "ABASTBOMBA";
            this.Bomba.HeaderText = "Bomba";
            this.Bomba.Name = "Bomba";
            this.Bomba.ReadOnly = true;
            // 
            // Frentista
            // 
            this.Frentista.DataPropertyName = "ABASTFRENT";
            this.Frentista.HeaderText = "Frentista";
            this.Frentista.Name = "Frentista";
            this.Frentista.ReadOnly = true;
            // 
            // TipoPagamento
            // 
            this.TipoPagamento.DataPropertyName = "ABASTTIPO";
            this.TipoPagamento.HeaderText = "Tipo de Pagamento";
            this.TipoPagamento.Name = "TipoPagamento";
            this.TipoPagamento.ReadOnly = true;
            // 
            // btngera
            // 
            this.btngera.Location = new System.Drawing.Point(8, 56);
            this.btngera.Name = "btngera";
            this.btngera.Size = new System.Drawing.Size(151, 37);
            this.btngera.TabIndex = 1;
            this.btngera.Text = "Gerar Dados";
            this.btngera.UseVisualStyleBackColor = true;
            this.btngera.Click += new System.EventHandler(this.btngera_Click);
            // 
            // txtFrentMin
            // 
            this.txtFrentMin.Location = new System.Drawing.Point(145, 8);
            this.txtFrentMin.Name = "txtFrentMin";
            this.txtFrentMin.Size = new System.Drawing.Size(39, 20);
            this.txtFrentMin.TabIndex = 2;
            // 
            // txtFrentMax
            // 
            this.txtFrentMax.Location = new System.Drawing.Point(145, 30);
            this.txtFrentMax.Name = "txtFrentMax";
            this.txtFrentMax.Size = new System.Drawing.Size(39, 20);
            this.txtFrentMax.TabIndex = 3;
            // 
            // txtBombMax
            // 
            this.txtBombMax.Location = new System.Drawing.Point(49, 30);
            this.txtBombMax.Name = "txtBombMax";
            this.txtBombMax.Size = new System.Drawing.Size(39, 20);
            this.txtBombMax.TabIndex = 5;
            // 
            // txtBombMin
            // 
            this.txtBombMin.Location = new System.Drawing.Point(49, 8);
            this.txtBombMin.Name = "txtBombMin";
            this.txtBombMin.Size = new System.Drawing.Size(39, 20);
            this.txtBombMin.TabIndex = 4;
            // 
            // lblbomba
            // 
            this.lblbomba.AutoSize = true;
            this.lblbomba.Location = new System.Drawing.Point(6, 23);
            this.lblbomba.Name = "lblbomba";
            this.lblbomba.Size = new System.Drawing.Size(45, 13);
            this.lblbomba.TabIndex = 6;
            this.lblbomba.Text = "Bombas";
            this.lblbomba.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblfrent
            // 
            this.lblfrent.AutoSize = true;
            this.lblfrent.Location = new System.Drawing.Point(90, 23);
            this.lblfrent.Name = "lblfrent";
            this.lblfrent.Size = new System.Drawing.Size(52, 13);
            this.lblfrent.TabIndex = 7;
            this.lblfrent.Text = "Frentistas";
            this.lblfrent.Click += new System.EventHandler(this.lblfrent_Click);
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(190, 23);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(28, 13);
            this.lbltipo.TabIndex = 12;
            this.lbltipo.Text = "Tipo";
            this.lbltipo.Click += new System.EventHandler(this.lbltipo_Click);
            // 
            // txttipomax
            // 
            this.txttipomax.Location = new System.Drawing.Point(220, 30);
            this.txttipomax.Name = "txttipomax";
            this.txttipomax.Size = new System.Drawing.Size(39, 20);
            this.txttipomax.TabIndex = 11;
            // 
            // txttipomin
            // 
            this.txttipomin.Location = new System.Drawing.Point(220, 8);
            this.txttipomin.Name = "txttipomin";
            this.txttipomin.Size = new System.Drawing.Size(39, 20);
            this.txttipomin.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Incluir:";
            // 
            // txtreg
            // 
            this.txtreg.Location = new System.Drawing.Point(103, 29);
            this.txtreg.Name = "txtreg";
            this.txtreg.Size = new System.Drawing.Size(56, 20);
            this.txtreg.TabIndex = 16;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbldia
            // 
            this.lbldia.AutoSize = true;
            this.lbldia.Location = new System.Drawing.Point(6, 0);
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(80, 13);
            this.lbldia.TabIndex = 20;
            this.lbldia.Text = "Dia da Semana";
            // 
            // lblturno
            // 
            this.lblturno.AutoSize = true;
            this.lblturno.Location = new System.Drawing.Point(6, 0);
            this.lblturno.Name = "lblturno";
            this.lblturno.Size = new System.Drawing.Size(35, 13);
            this.lblturno.TabIndex = 19;
            this.lblturno.Text = "Turno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Quantidade atual:";
            // 
            // btnapaga
            // 
            this.btnapaga.Location = new System.Drawing.Point(643, 60);
            this.btnapaga.Name = "btnapaga";
            this.btnapaga.Size = new System.Drawing.Size(151, 37);
            this.btnapaga.TabIndex = 23;
            this.btnapaga.Text = "Apagar Dados";
            this.btnapaga.UseVisualStyleBackColor = true;
            this.btnapaga.Click += new System.EventHandler(this.btnapaga_Click);
            // 
            // btncarreg
            // 
            this.btncarreg.Location = new System.Drawing.Point(165, 56);
            this.btncarreg.Name = "btncarreg";
            this.btncarreg.Size = new System.Drawing.Size(151, 37);
            this.btncarreg.TabIndex = 24;
            this.btncarreg.Text = "Carregar Dados";
            this.btncarreg.UseVisualStyleBackColor = true;
            this.btncarreg.Click += new System.EventHandler(this.btncarrega_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Exportar .CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkmanha
            // 
            this.chkmanha.AutoSize = true;
            this.chkmanha.Location = new System.Drawing.Point(6, 19);
            this.chkmanha.Name = "chkmanha";
            this.chkmanha.Size = new System.Drawing.Size(59, 17);
            this.chkmanha.TabIndex = 26;
            this.chkmanha.Text = "Manhã";
            this.chkmanha.UseVisualStyleBackColor = true;
            // 
            // chktarde
            // 
            this.chktarde.AutoSize = true;
            this.chktarde.Location = new System.Drawing.Point(6, 35);
            this.chktarde.Name = "chktarde";
            this.chktarde.Size = new System.Drawing.Size(54, 17);
            this.chktarde.TabIndex = 27;
            this.chktarde.Text = "Tarde";
            this.chktarde.UseVisualStyleBackColor = true;
            // 
            // chknoite
            // 
            this.chknoite.AutoSize = true;
            this.chknoite.Location = new System.Drawing.Point(6, 52);
            this.chknoite.Name = "chknoite";
            this.chknoite.Size = new System.Drawing.Size(51, 17);
            this.chknoite.TabIndex = 28;
            this.chknoite.Text = "Noite";
            this.chknoite.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chknoite);
            this.groupBox1.Controls.Add(this.chkmanha);
            this.groupBox1.Controls.Add(this.chktarde);
            this.groupBox1.Controls.Add(this.lblturno);
            this.groupBox1.Location = new System.Drawing.Point(322, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(68, 72);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // chkterca
            // 
            this.chkterca.AutoSize = true;
            this.chkterca.Location = new System.Drawing.Point(69, 19);
            this.chkterca.Name = "chkterca";
            this.chkterca.Size = new System.Drawing.Size(54, 17);
            this.chkterca.TabIndex = 29;
            this.chkterca.Text = "Terça";
            this.chkterca.UseVisualStyleBackColor = true;
            // 
            // chkquarta
            // 
            this.chkquarta.AutoSize = true;
            this.chkquarta.Location = new System.Drawing.Point(6, 36);
            this.chkquarta.Name = "chkquarta";
            this.chkquarta.Size = new System.Drawing.Size(58, 17);
            this.chkquarta.TabIndex = 30;
            this.chkquarta.Text = "Quarta";
            this.chkquarta.UseVisualStyleBackColor = true;
            // 
            // chksexta
            // 
            this.chksexta.AutoSize = true;
            this.chksexta.Location = new System.Drawing.Point(6, 53);
            this.chksexta.Name = "chksexta";
            this.chksexta.Size = new System.Drawing.Size(53, 17);
            this.chksexta.TabIndex = 31;
            this.chksexta.Text = "Sexta";
            this.chksexta.UseVisualStyleBackColor = true;
            // 
            // chkdomingo
            // 
            this.chkdomingo.AutoSize = true;
            this.chkdomingo.Location = new System.Drawing.Point(32, 70);
            this.chkdomingo.Name = "chkdomingo";
            this.chkdomingo.Size = new System.Drawing.Size(68, 17);
            this.chkdomingo.TabIndex = 32;
            this.chkdomingo.Text = "Domingo";
            this.chkdomingo.UseVisualStyleBackColor = true;
            // 
            // chksabado
            // 
            this.chksabado.AutoSize = true;
            this.chksabado.Location = new System.Drawing.Point(69, 53);
            this.chksabado.Name = "chksabado";
            this.chksabado.Size = new System.Drawing.Size(63, 17);
            this.chksabado.TabIndex = 33;
            this.chksabado.Text = "Sábado";
            this.chksabado.UseVisualStyleBackColor = true;
            // 
            // chksegunda
            // 
            this.chksegunda.AutoSize = true;
            this.chksegunda.Location = new System.Drawing.Point(6, 19);
            this.chksegunda.Name = "chksegunda";
            this.chksegunda.Size = new System.Drawing.Size(69, 17);
            this.chksegunda.TabIndex = 34;
            this.chksegunda.Text = "Segunda";
            this.chksegunda.UseVisualStyleBackColor = true;
            // 
            // chkquinta
            // 
            this.chkquinta.AutoSize = true;
            this.chkquinta.Location = new System.Drawing.Point(69, 36);
            this.chkquinta.Name = "chkquinta";
            this.chkquinta.Size = new System.Drawing.Size(57, 17);
            this.chkquinta.TabIndex = 35;
            this.chkquinta.Text = "Quinta";
            this.chkquinta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkterca);
            this.groupBox2.Controls.Add(this.chksegunda);
            this.groupBox2.Controls.Add(this.chkquarta);
            this.groupBox2.Controls.Add(this.chksabado);
            this.groupBox2.Controls.Add(this.chksexta);
            this.groupBox2.Controls.Add(this.chkquinta);
            this.groupBox2.Controls.Add(this.lbldia);
            this.groupBox2.Controls.Add(this.chkdomingo);
            this.groupBox2.Location = new System.Drawing.Point(396, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 89);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBombMax);
            this.groupBox3.Controls.Add(this.txtFrentMin);
            this.groupBox3.Controls.Add(this.txtFrentMax);
            this.groupBox3.Controls.Add(this.txtBombMin);
            this.groupBox3.Controls.Add(this.lblbomba);
            this.groupBox3.Controls.Add(this.lblfrent);
            this.groupBox3.Controls.Add(this.txttipomin);
            this.groupBox3.Controls.Add(this.txttipomax);
            this.groupBox3.Controls.Add(this.lbltipo);
            this.groupBox3.Location = new System.Drawing.Point(543, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 54);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 539);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncarreg);
            this.Controls.Add(this.btnapaga);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtreg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btngera);
            this.Controls.Add(this.dgvabast);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvabast)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvabast;
        private System.Windows.Forms.Button btngera;
        private System.Windows.Forms.TextBox txtFrentMin;
        private System.Windows.Forms.TextBox txtFrentMax;
        private System.Windows.Forms.TextBox txtBombMax;
        private System.Windows.Forms.TextBox txtBombMin;
        private System.Windows.Forms.Label lblbomba;
        private System.Windows.Forms.Label lblfrent;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.TextBox txttipomax;
        private System.Windows.Forms.TextBox txttipomin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtreg;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbldia;
        private System.Windows.Forms.Label lblturno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnapaga;
        private System.Windows.Forms.Button btncarreg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bomba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frentista;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPagamento;
        private System.Windows.Forms.CheckBox chkmanha;
        private System.Windows.Forms.CheckBox chktarde;
        private System.Windows.Forms.CheckBox chknoite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkterca;
        private System.Windows.Forms.CheckBox chkquarta;
        private System.Windows.Forms.CheckBox chksexta;
        private System.Windows.Forms.CheckBox chkdomingo;
        private System.Windows.Forms.CheckBox chksabado;
        private System.Windows.Forms.CheckBox chksegunda;
        private System.Windows.Forms.CheckBox chkquinta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

