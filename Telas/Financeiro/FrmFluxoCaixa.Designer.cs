namespace TCC.Telas.Financeiro
{
    partial class FrmFluxoCaixa
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboOperacao = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMes = new System.Windows.Forms.DateTimePicker();
            this.dtpFluxo = new System.Windows.Forms.DataGridView();
            this.sum_VALOR_PAGO_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_operacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_PAGAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpmes2 = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFluxo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TCC.Properties.Resources._296082;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 366);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::TCC.Properties.Resources.fundin;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpmes2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboOperacao);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpMes);
            this.panel1.Controls.Add(this.dtpFluxo);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 342);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(105, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo:";
            // 
            // cboOperacao
            // 
            this.cboOperacao.FormattingEnabled = true;
            this.cboOperacao.Items.AddRange(new object[] {
            "--Selecione--",
            "Despesa",
            "Receita",
            "Ambos"});
            this.cboOperacao.Location = new System.Drawing.Point(103, 210);
            this.cboOperacao.Name = "cboOperacao";
            this.cboOperacao.Size = new System.Drawing.Size(107, 21);
            this.cboOperacao.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCC.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(257, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(100, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "De";
            // 
            // dtpMes
            // 
            this.dtpMes.CustomFormat = "MM/yyy";
            this.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMes.Location = new System.Drawing.Point(103, 100);
            this.dtpMes.Name = "dtpMes";
            this.dtpMes.Size = new System.Drawing.Size(105, 20);
            this.dtpMes.TabIndex = 1;
            // 
            // dtpFluxo
            // 
            this.dtpFluxo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtpFluxo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sum_VALOR_PAGO_,
            this.tp_operacao,
            this.DATA_PAGAMENTO});
            this.dtpFluxo.Location = new System.Drawing.Point(349, 51);
            this.dtpFluxo.Name = "dtpFluxo";
            this.dtpFluxo.Size = new System.Drawing.Size(347, 215);
            this.dtpFluxo.TabIndex = 0;
            // 
            // sum_VALOR_PAGO_
            // 
            this.sum_VALOR_PAGO_.DataPropertyName = "sum_VALOR_PAGO_";
            this.sum_VALOR_PAGO_.HeaderText = "Valor Pago";
            this.sum_VALOR_PAGO_.Name = "sum_VALOR_PAGO_";
            // 
            // tp_operacao
            // 
            this.tp_operacao.DataPropertyName = "tp_operacao";
            this.tp_operacao.HeaderText = "Tipo";
            this.tp_operacao.Name = "tp_operacao";
            // 
            // DATA_PAGAMENTO
            // 
            this.DATA_PAGAMENTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DATA_PAGAMENTO.DataPropertyName = "DATA_PAGAMENTO";
            this.DATA_PAGAMENTO.HeaderText = "Data de pagamento";
            this.DATA_PAGAMENTO.Name = "DATA_PAGAMENTO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TCC.Properties.Resources.Imagem21;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(727, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 21);
            this.pictureBox2.TabIndex = 178;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::TCC.Properties.Resources.Imagem11;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(762, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 21);
            this.pictureBox4.TabIndex = 179;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TCC.Properties.Resources.reply;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::TCC.Properties.Resources.reply;
            this.pictureBox3.Location = new System.Drawing.Point(12, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 21);
            this.pictureBox3.TabIndex = 177;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(100, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Até";
            // 
            // dtpmes2
            // 
            this.dtpmes2.CustomFormat = "MM/yyy";
            this.dtpmes2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpmes2.Location = new System.Drawing.Point(103, 144);
            this.dtpmes2.Name = "dtpmes2";
            this.dtpmes2.Size = new System.Drawing.Size(105, 20);
            this.dtpmes2.TabIndex = 6;
            // 
            // FrmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 409);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFluxoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFluxoCaixa";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFluxo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpMes;
        private System.Windows.Forms.DataGridView dtpFluxo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum_VALOR_PAGO_;
        private System.Windows.Forms.DataGridViewTextBoxColumn tp_operacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_PAGAMENTO;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboOperacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpmes2;
    }
}