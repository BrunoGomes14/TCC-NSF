namespace TCC.Telas
{
    partial class FrmInserirPonto
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dtpSIntervalo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpVIntervalo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.nudIDFuncionario = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudIDFuncionario)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackgroundImage = global::TCC.Properties.Resources._296082;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(330, 278);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(108, 37);
            this.btnRegistrar.TabIndex = 54;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // dtpSIntervalo
            // 
            this.dtpSIntervalo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSIntervalo.Location = new System.Drawing.Point(389, 90);
            this.dtpSIntervalo.Name = "dtpSIntervalo";
            this.dtpSIntervalo.Size = new System.Drawing.Size(151, 20);
            this.dtpSIntervalo.TabIndex = 53;
            this.dtpSIntervalo.Value = new System.DateTime(2019, 10, 12, 11, 9, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(386, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Saída do intervalo:";
            // 
            // dtpVIntervalo
            // 
            this.dtpVIntervalo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVIntervalo.Location = new System.Drawing.Point(389, 162);
            this.dtpVIntervalo.Name = "dtpVIntervalo";
            this.dtpVIntervalo.Size = new System.Drawing.Size(151, 20);
            this.dtpVIntervalo.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(386, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Volta do intervalo:";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(165, 161);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(151, 20);
            this.dtpEntrada.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(162, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "Data da entrada:";
            // 
            // dtpSaida
            // 
            this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaida.Location = new System.Drawing.Point(165, 233);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(151, 20);
            this.dtpSaida.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(162, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "Data da saída:";
            // 
            // nudIDFuncionario
            // 
            this.nudIDFuncionario.Location = new System.Drawing.Point(165, 89);
            this.nudIDFuncionario.Name = "nudIDFuncionario";
            this.nudIDFuncionario.Size = new System.Drawing.Size(151, 20);
            this.nudIDFuncionario.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(162, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "ID do funcionario:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::TCC.Properties.Resources.fundin;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.nudIDFuncionario);
            this.panel1.Controls.Add(this.dtpSIntervalo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpSaida);
            this.panel1.Controls.Add(this.dtpVIntervalo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpEntrada);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 342);
            this.panel1.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Inserir Ponto";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TCC.Properties.Resources._296082;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 366);
            this.panel2.TabIndex = 56;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TCC.Properties.Resources.Imagem21;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(726, 4);
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
            this.pictureBox4.Location = new System.Drawing.Point(761, 4);
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
            this.pictureBox2.Location = new System.Drawing.Point(11, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 21);
            this.pictureBox2.TabIndex = 177;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmInserirPonto
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
            this.Name = "FrmInserirPonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInserirPonto";
            this.Load += new System.EventHandler(this.FrmInserirPonto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudIDFuncionario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DateTimePicker dtpSIntervalo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpVIntervalo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpSaida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudIDFuncionario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}