namespace TCC.Telas
{
    partial class FrmInserirVenda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.nudqtd = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Valor = new System.Windows.Forms.Label();
            this.lblvalordavenda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudrecb = new System.Windows.Forms.NumericUpDown();
            this.lbltroco = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.qtd_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_preco_unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudqtd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudrecb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::TCC.Properties.Resources.fundin;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.nudqtd);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.dgvProd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 358);
            this.panel1.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(74, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "Qtd.";
            // 
            // nudqtd
            // 
            this.nudqtd.Location = new System.Drawing.Point(74, 50);
            this.nudqtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudqtd.Name = "nudqtd";
            this.nudqtd.Size = new System.Drawing.Size(49, 20);
            this.nudqtd.TabIndex = 0;
            this.nudqtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::TCC.Properties.Resources._296082;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(570, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Finalizar Venda";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Valor);
            this.groupBox1.Controls.Add(this.lblvalordavenda);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudrecb);
            this.groupBox1.Controls.Add(this.lbltroco);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(450, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 185);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infomações da Venda";
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Valor.Location = new System.Drawing.Point(18, 38);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(118, 16);
            this.Valor.TabIndex = 2;
            this.Valor.Text = "Valor da venda:";
            // 
            // lblvalordavenda
            // 
            this.lblvalordavenda.AutoSize = true;
            this.lblvalordavenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalordavenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblvalordavenda.Location = new System.Drawing.Point(153, 38);
            this.lblvalordavenda.Name = "lblvalordavenda";
            this.lblvalordavenda.Size = new System.Drawing.Size(36, 16);
            this.lblvalordavenda.TabIndex = 3;
            this.lblvalordavenda.Text = "0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(225, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(83, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Troco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(225, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(56, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Recebido:";
            // 
            // nudrecb
            // 
            this.nudrecb.DecimalPlaces = 2;
            this.nudrecb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudrecb.Location = new System.Drawing.Point(156, 77);
            this.nudrecb.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudrecb.Name = "nudrecb";
            this.nudrecb.Size = new System.Drawing.Size(96, 21);
            this.nudrecb.TabIndex = 2;
            this.nudrecb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudrecb_KeyPress);
            // 
            // lbltroco
            // 
            this.lbltroco.AutoSize = true;
            this.lbltroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltroco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbltroco.Location = new System.Drawing.Point(153, 121);
            this.lbltroco.Name = "lbltroco";
            this.lbltroco.Size = new System.Drawing.Size(36, 16);
            this.lbltroco.TabIndex = 7;
            this.lbltroco.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(126, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Código De Barras";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(129, 51);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(191, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qtd_venda,
            this.nm_modelo,
            this.nm_marca,
            this.pr_preco_unidade});
            this.dgvProd.Location = new System.Drawing.Point(35, 89);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(377, 150);
            this.dgvProd.TabIndex = 80;
            // 
            // qtd_venda
            // 
            this.qtd_venda.DataPropertyName = "qtd_venda";
            this.qtd_venda.HeaderText = "Qtd.";
            this.qtd_venda.Name = "qtd_venda";
            this.qtd_venda.Width = 50;
            // 
            // nm_modelo
            // 
            this.nm_modelo.DataPropertyName = "nm_modelo";
            this.nm_modelo.HeaderText = "Modelo";
            this.nm_modelo.Name = "nm_modelo";
            // 
            // nm_marca
            // 
            this.nm_marca.DataPropertyName = "nm_marca";
            this.nm_marca.HeaderText = "Marca";
            this.nm_marca.Name = "nm_marca";
            // 
            // pr_preco_unidade
            // 
            this.pr_preco_unidade.DataPropertyName = "pr_preco_unidade";
            this.pr_preco_unidade.HeaderText = "Preço";
            this.pr_preco_unidade.Name = "pr_preco_unidade";
            this.pr_preco_unidade.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 79;
            this.label1.Text = "Inserir Venda";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TCC.Properties.Resources._296082;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 364);
            this.panel2.TabIndex = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TCC.Properties.Resources.Imagem21;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(726, 6);
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
            this.pictureBox4.Location = new System.Drawing.Point(761, 6);
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
            this.pictureBox2.Location = new System.Drawing.Point(11, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 21);
            this.pictureBox2.TabIndex = 177;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmInserirVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInserirVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInserirVenda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudqtd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudrecb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudqtd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.Label lblvalordavenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudrecb;
        private System.Windows.Forms.Label lbltroco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_preco_unidade;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}