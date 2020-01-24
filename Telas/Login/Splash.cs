using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Telas
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
			
            Telas.FrmLoginOtica tela = new FrmLoginOtica();
            tela.Show();

            DataBase.Entity.db_a4f62c_oticaEntities db = new DataBase.Entity.db_a4f62c_oticaEntities();
            db.tb_login.Where(x => x.id_login > 0);

			
            timer1.Stop();

            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

		private void Splash_Load(object sender, EventArgs e)
		{
			try
			{

				DataBase.TesteConexaoDatabase bd = new DataBase.TesteConexaoDatabase();
				bool teste = bd.TesteConexao();

				if (!teste)
				{
					timer1.Stop();

				    throw new ArgumentException("Conexão com o banco falhou. Por favor, Verifique sua conexão com a internet e tente novamente");
				

				
				}

			}
			catch (ArgumentException ex)
			{

				DialogResult resultado = MessageBox.Show(ex.Message);

				if (resultado == DialogResult.OK || resultado == DialogResult.Cancel)

					Application.Exit();

			}
            
		}
	}
}
