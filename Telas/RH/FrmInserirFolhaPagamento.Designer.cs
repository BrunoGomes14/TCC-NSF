namespace TCC.Telas
{
    partial class FrmInserirFolhaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInserirFolhaPagamento));
            this.label14 = new System.Windows.Forms.Label();
            this.dtpMes = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIR = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFalta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDescontoTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVT = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPLR = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.lblBeneficio = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblExtra50 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBruto = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblLiquido = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPLR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(41, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 15);
            this.label14.TabIndex = 135;
            this.label14.Text = "Funcionário:";
            // 
            // dtpMes
            // 
            this.dtpMes.CustomFormat = "MM/yyy";
            this.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMes.Location = new System.Drawing.Point(44, 145);
            this.dtpMes.Name = "dtpMes";
            this.dtpMes.Size = new System.Drawing.Size(121, 20);
            this.dtpMes.TabIndex = 148;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 149;
            this.label1.Text = "Mês:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblIR);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblFalta);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblDescontoTotal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblVT);
            this.groupBox2.Controls.Add(this.lblINSS);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(324, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 210);
            this.groupBox2.TabIndex = 150;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descontos";
            // 
            // lblIR
            // 
            this.lblIR.AutoSize = true;
            this.lblIR.Location = new System.Drawing.Point(65, 116);
            this.lblIR.Name = "lblIR";
            this.lblIR.Size = new System.Drawing.Size(56, 13);
            this.lblIR.TabIndex = 7;
            this.lblIR.Text = "** Valor ** ";
            this.lblIR.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "IR:";
            // 
            // lblFalta
            // 
            this.lblFalta.AutoSize = true;
            this.lblFalta.Location = new System.Drawing.Point(65, 88);
            this.lblFalta.Name = "lblFalta";
            this.lblFalta.Size = new System.Drawing.Size(60, 13);
            this.lblFalta.TabIndex = 7;
            this.lblFalta.Text = "** Faltas ** ";
            this.lblFalta.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Faltas:";
            // 
            // lblDescontoTotal
            // 
            this.lblDescontoTotal.AutoSize = true;
            this.lblDescontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoTotal.Location = new System.Drawing.Point(118, 166);
            this.lblDescontoTotal.Name = "lblDescontoTotal";
            this.lblDescontoTotal.Size = new System.Drawing.Size(56, 13);
            this.lblDescontoTotal.TabIndex = 5;
            this.lblDescontoTotal.Text = "**Total**";
            this.lblDescontoTotal.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total de desconto:";
            // 
            // lblVT
            // 
            this.lblVT.AutoSize = true;
            this.lblVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVT.Location = new System.Drawing.Point(57, 61);
            this.lblVT.Name = "lblVT";
            this.lblVT.Size = new System.Drawing.Size(88, 13);
            this.lblVT.TabIndex = 3;
            this.lblVT.Text = "**ValorDoVT**";
            this.lblVT.Visible = false;
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINSS.Location = new System.Drawing.Point(57, 30);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(101, 13);
            this.lblINSS.TabIndex = 2;
            this.lblINSS.Text = "**ValorDoINSS**";
            this.lblINSS.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "VT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "INSS:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblFamilia);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.nudPLR);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.lblBeneficio);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblExtra50);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(530, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(189, 210);
            this.groupBox3.TabIndex = 151;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Benefícios";
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilia.Location = new System.Drawing.Point(88, 61);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(95, 13);
            this.lblFamilia.TabIndex = 8;
            this.lblFamilia.Text = "**ValorSalario**";
            this.lblFamilia.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 158;
            this.label4.Text = "S. Família:";
            // 
            // nudPLR
            // 
            this.nudPLR.DecimalPlaces = 2;
            this.nudPLR.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudPLR.Location = new System.Drawing.Point(91, 88);
            this.nudPLR.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPLR.Name = "nudPLR";
            this.nudPLR.Size = new System.Drawing.Size(72, 20);
            this.nudPLR.TabIndex = 157;
            this.nudPLR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudPLR_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(39, 90);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "PLR:";
            // 
            // lblBeneficio
            // 
            this.lblBeneficio.AutoSize = true;
            this.lblBeneficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficio.Location = new System.Drawing.Point(127, 166);
            this.lblBeneficio.Name = "lblBeneficio";
            this.lblBeneficio.Size = new System.Drawing.Size(56, 13);
            this.lblBeneficio.TabIndex = 5;
            this.lblBeneficio.Text = "**Total**";
            this.lblBeneficio.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Total De Beneficios:";
            // 
            // lblExtra50
            // 
            this.lblExtra50.AutoSize = true;
            this.lblExtra50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtra50.Location = new System.Drawing.Point(88, 28);
            this.lblExtra50.Name = "lblExtra50";
            this.lblExtra50.Size = new System.Drawing.Size(85, 13);
            this.lblExtra50.TabIndex = 2;
            this.lblExtra50.Text = "**ValorExtra**";
            this.lblExtra50.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "H.Extra :";
            // 
            // lblBruto
            // 
            this.lblBruto.AutoSize = true;
            this.lblBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBruto.ForeColor = System.Drawing.Color.White;
            this.lblBruto.Location = new System.Drawing.Point(139, 205);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(86, 13);
            this.lblBruto.TabIndex = 153;
            this.lblBruto.Text = "**TotalBruto**";
            this.lblBruto.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(41, 238);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 13);
            this.label19.TabIndex = 154;
            this.label19.Text = "Salário Líquido:";
            // 
            // lblLiquido
            // 
            this.lblLiquido.AutoSize = true;
            this.lblLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiquido.ForeColor = System.Drawing.Color.White;
            this.lblLiquido.Location = new System.Drawing.Point(143, 238);
            this.lblLiquido.Name = "lblLiquido";
            this.lblLiquido.Size = new System.Drawing.Size(97, 13);
            this.lblLiquido.TabIndex = 155;
            this.lblLiquido.Text = "**TotalLiquido**";
            this.lblLiquido.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::TCC.Properties.Resources._296082;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 379);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TCC.Properties.Resources.fundin;
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.lblLiquido);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.cboFuncionario);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblBruto);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtpMes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 362);
            this.panel1.TabIndex = 157;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(523, 315);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(92, 23);
            this.btnImprimir.TabIndex = 158;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(621, 315);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(92, 23);
            this.btnSalvar.TabIndex = 157;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Items.AddRange(new object[] {
            "--Selecione--"});
            this.cboFuncionario.Location = new System.Drawing.Point(44, 83);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(121, 21);
            this.cboFuncionario.TabIndex = 156;
            this.cboFuncionario.SelectedIndexChanged += new System.EventHandler(this.CboFuncionario_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCC.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(171, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 147;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(41, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 152;
            this.label9.Text = "Salário Bruto:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TCC.Properties.Resources.Imagem21;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(715, 0);
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
            this.pictureBox4.Location = new System.Drawing.Point(750, 0);
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
            this.pictureBox3.Location = new System.Drawing.Point(12, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 21);
            this.pictureBox3.TabIndex = 177;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // FrmInserirFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 417);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInserirFolhaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInserirFolhaPagamento";
            this.Load += new System.EventHandler(this.FrmInserirFolhaPagamento_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPLR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDescontoTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVT;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblBeneficio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblExtra50;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblLiquido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudPLR;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFalta;
        private System.Windows.Forms.Label lblFamilia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}