namespace TCC.Telas
{
    partial class FrmInserirFalta
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
            this.lbljustificativa = new System.Windows.Forms.Label();
            this.rtxtjustificativa = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdnNop = new System.Windows.Forms.RadioButton();
            this.rdnSIm = new System.Windows.Forms.RadioButton();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dtpFalta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(12, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 365);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::TCC.Properties.Resources.fundin;
            this.panel1.Controls.Add(this.lbljustificativa);
            this.panel1.Controls.Add(this.rtxtjustificativa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rdnNop);
            this.panel1.Controls.Add(this.rdnSIm);
            this.panel1.Controls.Add(this.cboFuncionario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.dtpFalta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(14, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 337);
            this.panel1.TabIndex = 0;
            // 
            // lbljustificativa
            // 
            this.lbljustificativa.AutoSize = true;
            this.lbljustificativa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbljustificativa.Location = new System.Drawing.Point(499, 69);
            this.lbljustificativa.Name = "lbljustificativa";
            this.lbljustificativa.Size = new System.Drawing.Size(65, 13);
            this.lbljustificativa.TabIndex = 100;
            this.lbljustificativa.Text = "Justificativa:";
            this.lbljustificativa.Visible = false;
            // 
            // rtxtjustificativa
            // 
            this.rtxtjustificativa.Location = new System.Drawing.Point(499, 88);
            this.rtxtjustificativa.MaxLength = 299;
            this.rtxtjustificativa.Name = "rtxtjustificativa";
            this.rtxtjustificativa.Size = new System.Drawing.Size(214, 160);
            this.rtxtjustificativa.TabIndex = 99;
            this.rtxtjustificativa.Text = "";
            this.rtxtjustificativa.Visible = false;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(354, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 98;
            this.label4.Text = "Justificou a falta?";
            // 
            // rdnNop
            // 
            this.rdnNop.AutoSize = true;
            this.rdnNop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdnNop.Location = new System.Drawing.Point(354, 141);
            this.rdnNop.Name = "rdnNop";
            this.rdnNop.Size = new System.Drawing.Size(48, 17);
            this.rdnNop.TabIndex = 97;
            this.rdnNop.TabStop = true;
            this.rdnNop.Text = "NÃO";
            this.rdnNop.UseVisualStyleBackColor = true;
            this.rdnNop.CheckedChanged += new System.EventHandler(this.rdnNop_CheckedChanged);
            // 
            // rdnSIm
            // 
            this.rdnSIm.AutoSize = true;
            this.rdnSIm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdnSIm.Location = new System.Drawing.Point(354, 112);
            this.rdnSIm.Name = "rdnSIm";
            this.rdnSIm.Size = new System.Drawing.Size(44, 17);
            this.rdnSIm.TabIndex = 96;
            this.rdnSIm.TabStop = true;
            this.rdnSIm.Text = "SIM";
            this.rdnSIm.UseVisualStyleBackColor = true;
            this.rdnSIm.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(121, 107);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(151, 21);
            this.cboFuncionario.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 94;
            this.label3.Text = "Inserir falta";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackgroundImage = global::TCC.Properties.Resources._296082;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(126, 277);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(128, 40);
            this.btnRegistrar.TabIndex = 93;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dtpFalta
            // 
            this.dtpFalta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFalta.Location = new System.Drawing.Point(121, 186);
            this.dtpFalta.Name = "dtpFalta";
            this.dtpFalta.Size = new System.Drawing.Size(151, 20);
            this.dtpFalta.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 91;
            this.label1.Text = "Data da falta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(119, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 90;
            this.label2.Text = "Funcionário:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TCC.Properties.Resources.Imagem21;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(727, 6);
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
            this.pictureBox4.Location = new System.Drawing.Point(762, 6);
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
            this.pictureBox2.Location = new System.Drawing.Point(12, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 21);
            this.pictureBox2.TabIndex = 177;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmInserirFalta
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
            this.Name = "FrmInserirFalta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInserirFalta";
            this.Load += new System.EventHandler(this.FrmInserirFalta_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DateTimePicker dtpFalta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.Label lbljustificativa;
        private System.Windows.Forms.RichTextBox rtxtjustificativa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdnNop;
        private System.Windows.Forms.RadioButton rdnSIm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}