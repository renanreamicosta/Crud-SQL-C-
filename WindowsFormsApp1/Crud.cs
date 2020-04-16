using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Crud : Form
    {
        public Crud()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;
        private string strCon = "Your DB path goes here.";
        private string strSql = string.Empty;

        private void Crud_Load(object sender, EventArgs e)
        {

        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            strSql = "insert into Usuarios (Login, Senha) values (@Login, @Senha)";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Login", SqlDbType.VarChar).Value = txt_login_cad.Text;
            comando.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txt_senha_cad.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            txt_login_cad.Clear();
            txt_senha_cad.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
