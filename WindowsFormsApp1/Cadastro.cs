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
    public partial class Cadastro : Form
    {
        

        SqlConnection sqlCon = null;
        private string strCon = "Your DB path goes here.";
        private string strSql = string.Empty;

        

        public Cadastro()
        {
            InitializeComponent();
            txt_id.Enabled = false;

        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LogMenu log = new LogMenu();
            this.Hide();
            log.ShowDialog();

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            strSql = "insert into Clientes (Nome, Telefone, CPF, Idade, Email) values (@Nome, @Telefone, @CPF, @Idade, @Email)";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_name.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txt_tel.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txt_cpf.Text;
            comando.Parameters.Add("@Idade", SqlDbType.VarChar).Value = txt_idade.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txt_email.Text;


            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            txt_name.Clear();
            txt_tel.Clear();
            txt_cpf.Clear();
            txt_idade.Clear();
            txt_email.Clear();

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

            strSql = "update Clientes set Nome = @Nome, Telefone = @Telefone, CPF = @CPF, Idade = @Idade, Email = @Email where ClientesID = @ClientesID";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@ClientesID", SqlDbType.VarChar).Value = txt_id.Text;
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_name.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txt_tel.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txt_cpf.Text;
            comando.Parameters.Add("@Idade", SqlDbType.VarChar).Value = txt_idade.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txt_email.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro alterado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            txt_id.Clear();
            txt_name.Clear();
            txt_tel.Clear();
            txt_cpf.Clear();
            txt_idade.Clear();
            txt_email.Clear();
        }



        private void btn_procurar_Click(object sender, EventArgs e)
        {
            strSql = "select * from Clientes where Nome like @Pesquisa";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            comando.Parameters.Add("@Pesquisa", SqlDbType.VarChar).Value = txt_procurar.Text;
            DataTable tabela = new DataTable();

            try
            {
                if (txt_procurar.Text == string.Empty)
                {
                    MessageBox.Show("É necessário inserir um item para pesquisa.");
                }
                sqlCon.Open();
                adaptador.Fill(tabela);
                dgv_busca.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            txt_procurar.Clear();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            strSql = "delete from Clientes where @ClientesID = ClientesID";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@ClientesID", SqlDbType.VarChar).Value = txt_id.Text;

            try
            {

                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuário excluido com sucesso.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            txt_id.Clear();
            txt_name.Clear();
            txt_tel.Clear();
            txt_cpf.Clear();
            txt_idade.Clear();
            txt_email.Clear();
        }

        private void dgv_busca_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            strSql = "select * from Clientes where ClientesID like @ClientesID";



            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            var row = dgv_busca.CurrentRow;

            String id = row.Cells[0].Value.ToString();

            comando.Parameters.Add("@ClientesID", SqlDbType.VarChar).Value = id;

            try
            {
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                txt_id.Text = Convert.ToString(dr["ClientesID"]);
                txt_name.Text = Convert.ToString(dr["Nome"]);
                txt_tel.Text = Convert.ToString(dr["Telefone"]);
                txt_cpf.Text = Convert.ToString(dr["CPF"]);
                txt_idade.Text = Convert.ToString(dr["Idade"]);
                txt_email.Text = Convert.ToString(dr["Email"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
