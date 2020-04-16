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
    public partial class LogMenu : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = "Your DB path goes here.";
        private string strSql = string.Empty;

        public LogMenu()
        {
            InitializeComponent();


        }



        private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Crud add = new Crud();
            add.ShowDialog();

        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            strSql = "select * from Usuarios where Login like @Login and Senha = @Senha";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@Login", SqlDbType.VarChar).Value = txt_login.Text;
            comando.Parameters.AddWithValue("@Senha", SqlDbType.VarChar).Value = txt_senha.Text;
            comando.Connection = sqlCon;
            sqlCon.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            sqlCon.Close();

            bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

            if (loginSuccessful)
            {
                MessageBox.Show("Login efetuado com sucesso!");

                Cadastro cad = new Cadastro();
                LogMenu log = new LogMenu();
                this.Hide();
                cad.ShowDialog();

            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorretos!");
            }
        }

        private void aLTERARSENHAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LogMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
