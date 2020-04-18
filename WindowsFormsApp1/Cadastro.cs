using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cadastro : Form
    {

        Bitmap bmp;
        SqlConnection sqlCon = null;
        //string de conexao com o banco de dados
        private string strCon = @"Data Source=DESKTOP-PV2UP24;Initial Catalog=CADASTRO;Integrated Security=True";
        private string strSql = string.Empty;
        private string email;

       
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
            
                strSql = "EXEC verificaEmail @Email = @email";

                sqlCon = new SqlConnection(strCon);

                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = txt_email.Text;
                comando.Connection = sqlCon;

            try
            {
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();

                dr.Read();
               
            

                    email = Convert.ToString(dr["Email"]);
                
            }
           
            catch (Exception)
            {
                sqlCon.Close();
            }
            
            // valida se ja existe o email
            bool Emailiguais = (txt_email.Text == email); ;

                if (Emailiguais)
                {
                MessageBox.Show("Email que esta tentando registrar ja existe");

            }
                else
                {
                string query = "EXEC AddCliente @Nome = @nome, @Email = @email, @Logotipo= @logotipo ";


                SqlCommand comando1 = new SqlCommand(query, sqlCon);

                MemoryStream memory = new MemoryStream();
                bmp.Save(memory, ImageFormat.Bmp);
                var foto = memory.ToArray();

                comando1.Parameters.Add("@nome", SqlDbType.VarChar).Value = txt_name.Text;
                comando1.Parameters.Add("@email", SqlDbType.VarChar).Value = txt_email.Text;
                comando1.Parameters.Add("@logotipo", SqlDbType.VarBinary).Value = foto;
                try
                {
                    sqlCon.Open();

                    comando1.ExecuteNonQuery();
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
                txt_email.Clear();
            }






        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

            strSql = "EXEC AlteraCliente @Nome=@nome , @Email = @email, @Logotipo = @logotipo , @ID_Cli = @id_Cli";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            MemoryStream memory = new MemoryStream();
            bmp.Save(memory, ImageFormat.Bmp);
            var foto = memory.ToArray();

            comando.Parameters.Add("@id_Cli", SqlDbType.VarChar).Value = txt_id.Text;
            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txt_name.Text;
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = txt_email.Text;
            comando.Parameters.Add("@logotipo", SqlDbType.VarBinary).Value = foto;


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
  
            txt_email.Clear();
        }



        private void btn_procurar_Click(object sender, EventArgs e)
        {
            if (txt_procurar.Text == string.Empty)
            {
                strSql = "EXEC selectAllCliente";

                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                comando.Parameters.Add("@Pesquisa", SqlDbType.VarChar).Value = txt_procurar.Text;
                DataTable tabela = new DataTable();

                try
                {

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
            }
            else
            {
                strSql = "EXEC select_Cliente @Nome = @pesquisa";

                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                comando.Parameters.Add("@Pesquisa", SqlDbType.VarChar).Value = txt_procurar.Text;
                DataTable tabela = new DataTable();

                try
                {

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
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            strSql = "EXEC ExcluirAllLogradouro @COD_Cli = @id_cli " +
                "EXEC Deletecliente @ID_Cli = @id_cli";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@id_cli", SqlDbType.VarChar).Value = txt_id.Text;

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
  
            txt_email.Clear();
        }

        private void dgv_busca_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            strSql = "EXEC selectclienteOne @ID_Cli = @id_Cli";



            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            var row = dgv_busca.CurrentRow;

            String id = row.Cells[0].Value.ToString();

            comando.Parameters.Add("@id_Cli", SqlDbType.VarChar).Value = id;

            try
            {
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                txt_id.Text = Convert.ToString(dr["ID_Cli"]);
                txt_id_Cli.Text = Convert.ToString(dr["ID_Cli"]);
                txt_name.Text = Convert.ToString(dr["Nome"]);
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

        private void btn_addimage_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string logotipo = openFileDialog1.FileName;

                bmp = new Bitmap(logotipo);
                LogoTipo.Image = bmp;

            }

        }

        private void btn_inserir_logra_Click(object sender, EventArgs e)
        {
            strSql = "EXEC ADDLogradouro @Logradouro = @logradouro , @COD_Cli = @cod_cli";


            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@logradouro", SqlDbType.VarChar).Value = txt_Logra.Text;
            comando.Parameters.Add("@cod_Cli", SqlDbType.VarChar).Value = txt_id_Cli.Text;
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
            txt_email.Clear();

        
    }

        private void btn_excluir_logra_Click(object sender, EventArgs e)
        {

            strSql = "EXEC deleteLogradouro @COD_Log = @cod_log";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@cod_log", SqlDbType.VarChar).Value = txt_id_log.Text;

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
            txt_id_log.Clear();

        
    }

        private void btn_alterar_logra_Click(object sender, EventArgs e)
        {
            strSql = "EXEC AlteraLogradouro @COD_Log= @cod_log , @Logradouro = @logradouro";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);


            comando.Parameters.Add("@cod_log", SqlDbType.VarChar).Value = txt_id_log.Text;
            comando.Parameters.Add("@logradouro", SqlDbType.VarChar).Value = txt_Logra.Text;


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

            txt_email.Clear();
        }
    }
}
