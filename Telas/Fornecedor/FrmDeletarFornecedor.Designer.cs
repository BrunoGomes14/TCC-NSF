namespace TCC.Telas
{
    partial class FrmDeletarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeletarFornecedor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTPFornecimento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNomeForncedor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.id_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nr_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nr_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nr_celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TCC.Properties.Resources.Imagem21;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(729, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 21);
            this.pictureBox1.TabIndex = 178;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::TCC.Properties.Resources.Imagem11;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(764, 9);
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
            this.pictureBox2.Location = new System.Drawing.Point(14, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 21);
            this.pictureBox2.TabIndex = 177;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TCC.Properties.Resources._296082;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 361);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::TCC.Properties.Resources.fundin;
            this.panel1.Controls.Add(this.dgvFornecedor);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtResponsavel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTelefone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTPFornecimento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCNPJ);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboNomeForncedor);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 337);
            this.panel1.TabIndex = 12;
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_fornecedor,
            this.nm_fornecedor,
            this.tp_fornecedor,
            this.nm_responsavel,
            this.nr_cnpj,
            this.nr_tel,
            this.nr_celular});
            this.dgvFornecedor.Location = new System.Drawing.Point(29, 65);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.Size = new System.Drawing.Size(707, 119);
            this.dgvFornecedor.TabIndex = 166;
            this.dgvFornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellClick_1);
            this.dgvFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellContentClick);
            // 
            // btnRemover
            // 
            this.btnRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemover.BackgroundImage")));
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.Red;
            this.btnRemover.Location = new System.Drawing.Point(523, 282);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(105, 42);
            this.btnRemover.TabIndex = 165;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(634, 282);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 42);
            this.btnSalvar.TabIndex = 164;
            this.btnSalvar.Text = "Salvar alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::TCC.Properties.Resources._296082;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(413, 282);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 42);
            this.btnCancelar.TabIndex = 163;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(601, 241);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(144, 22);
            this.txtCelular.TabIndex = 161;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(549, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 162;
            this.label6.Text = "Celular";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(385, 213);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(144, 22);
            this.txtResponsavel.TabIndex = 159;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(295, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 160;
            this.label5.Text = "Responsável";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(601, 210);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(144, 22);
            this.txtTelefone.TabIndex = 157;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(540, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 158;
            this.label4.Text = "Telefone ";
            // 
            // txtTPFornecimento
            // 
            this.txtTPFornecimento.Location = new System.Drawing.Point(140, 244);
            this.txtTPFornecimento.Name = "txtTPFornecimento";
            this.txtTPFornecimento.Size = new System.Drawing.Size(144, 22);
            this.txtTPFornecimento.TabIndex = 155;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 156;
            this.label3.Text = "Tipo Fornecimento ";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(385, 244);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(144, 22);
            this.txtCNPJ.TabIndex = 153;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(341, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 154;
            this.label7.Text = "CNPJ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(140, 213);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(144, 22);
            this.txtNome.TabIndex = 151;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 152;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 150;
            this.label2.Text = "Nome Fornecedor :";
            // 
            // cboNomeForncedor
            // 
            this.cboNomeForncedor.FormattingEnabled = true;
            this.cboNomeForncedor.Location = new System.Drawing.Point(156, 35);
            this.cboNomeForncedor.Name = "cboNomeForncedor";
            this.cboNomeForncedor.Size = new System.Drawing.Size(121, 24);
            this.cboNomeForncedor.TabIndex = 149;
            this.cboNomeForncedor.SelectedIndexChanged += new System.EventHandler(this.cboNomeForncedor_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Deletar/Alterar Fornecedor";
            // 
            // id_fornecedor
            // 
            this.id_fornecedor.DataPropertyName = "id_fornecedor";
            this.id_fornecedor.HeaderText = "ID";
            this.id_fornecedor.Name = "id_fornecedor";
            this.id_fornecedor.Visible = false;
            // 
            // nm_fornecedor
            // 
            this.nm_fornecedor.DataPropertyName = "nm_fornecedor";
            this.nm_fornecedor.HeaderText = "Fornecedor";
            this.nm_fornecedor.Name = "nm_fornecedor";
            this.nm_fornecedor.ReadOnly = true;
            // 
            // tp_fornecedor
            // 
            this.tp_fornecedor.DataPropertyName = "tp_fornecimento";
            this.tp_fornecedor.HeaderText = "Tipo";
            this.tp_fornecedor.Name = "tp_fornecedor";
            // 
            // nm_responsavel
            // 
            this.nm_responsavel.DataPropertyName = "nm_responsavel";
            this.nm_responsavel.HeaderText = "Responsável";
            this.nm_responsavel.Name = "nm_responsavel";
            // 
            // nr_cnpj
            // 
            this.nr_cnpj.DataPropertyName = "nr_cnpj";
            this.nr_cnpj.HeaderText = "CNPJ";
            this.nr_cnpj.Name = "nr_cnpj";
            // 
            // nr_tel
            // 
            this.nr_tel.DataPropertyName = "nr_tel";
            this.nr_tel.HeaderText = "Tel";
            this.nr_tel.Name = "nr_tel";
            // 
            // nr_celular
            // 
            this.nr_celular.DataPropertyName = "nr_celular";
            this.nr_celular.HeaderText = "Cel";
            this.nr_celular.Name = "nr_celular";
            // 
            // FrmDeletarFornecedor
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
            this.Name = "FrmDeletarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDeletarFornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTPFornecimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNomeForncedor;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tp_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr_celular;
    }
}