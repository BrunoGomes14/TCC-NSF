namespace TCC.Telas.Funcionario
{
    partial class FrmConsultarFuncionario
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Funcionário = new System.Windows.Forms.Label();
            this.pcbBuscar = new System.Windows.Forms.PictureBox();
            this.dtpFuncionario = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TCC.Properties.Resources._296082;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 363);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::TCC.Properties.Resources.fundin;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.Funcionário);
            this.panel1.Controls.Add(this.pcbBuscar);
            this.panel1.Controls.Add(this.dtpFuncionario);
            this.panel1.Location = new System.Drawing.Point(13, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 340);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(53, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Funcionário
            // 
            this.Funcionário.AutoSize = true;
            this.Funcionário.BackColor = System.Drawing.Color.Transparent;
            this.Funcionário.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Funcionário.Location = new System.Drawing.Point(53, 19);
            this.Funcionário.Name = "Funcionário";
            this.Funcionário.Size = new System.Drawing.Size(62, 13);
            this.Funcionário.TabIndex = 3;
            this.Funcionário.Text = "Funcionário";
            // 
            // pcbBuscar
            // 
            this.pcbBuscar.Image = global::TCC.Properties.Resources.search;
            this.pcbBuscar.Location = new System.Drawing.Point(180, 36);
            this.pcbBuscar.Name = "pcbBuscar";
            this.pcbBuscar.Size = new System.Drawing.Size(37, 36);
            this.pcbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBuscar.TabIndex = 2;
            this.pcbBuscar.TabStop = false;
            this.pcbBuscar.Click += new System.EventHandler(this.pcbBuscar_Click);
            // 
            // dtpFuncionario
            // 
            this.dtpFuncionario.BackgroundColor = System.Drawing.Color.White;
            this.dtpFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtpFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dtpFuncionario.Location = new System.Drawing.Point(29, 98);
            this.dtpFuncionario.Name = "dtpFuncionario";
            this.dtpFuncionario.Size = new System.Drawing.Size(702, 162);
            this.dtpFuncionario.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TCC.Properties.Resources.Imagem21;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(726, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 21);
            this.pictureBox1.TabIndex = 178;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::TCC.Properties.Resources.Imagem11;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(761, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 21);
            this.pictureBox4.TabIndex = 179;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TCC.Properties.Resources.reply;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::TCC.Properties.Resources.reply;
            this.pictureBox2.Location = new System.Drawing.Point(11, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 21);
            this.pictureBox2.TabIndex = 177;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_login";
            this.Column1.HeaderText = "ID Login";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nm_usuario";
            this.Column2.HeaderText = "Nome Usuário";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "pw_senha";
            this.Column3.HeaderText = "Senha";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nm_dica";
            this.Column4.HeaderText = "Dica Senha";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "cd_recuperacao";
            this.Column5.HeaderText = "Código De Rec";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tp_hierarquia";
            this.Column6.HeaderText = "Hierarquia";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "nm_email";
            this.Column7.HeaderText = "E-mail";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "id_funcionario";
            this.Column8.HeaderText = "ID Funcionário";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "nr_telefone";
            this.Column9.HeaderText = "Telefone";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "nr_celular";
            this.Column10.HeaderText = "Celular";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "nr_cep";
            this.Column11.HeaderText = "CEP";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "nm_rua";
            this.Column12.HeaderText = "Endereço";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "nr_moradia";
            this.Column13.HeaderText = "Nº Moradia";
            this.Column13.Name = "Column13";
            // 
            // FrmConsultarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultarFuncionario";
            this.Load += new System.EventHandler(this.FrmConsultarFuncionario_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Funcionário;
        private System.Windows.Forms.PictureBox pcbBuscar;
        private System.Windows.Forms.DataGridView dtpFuncionario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}