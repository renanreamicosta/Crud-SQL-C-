using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cadastro : Form
    {

        Bitmap bmp;
        SqlConnection sqlCon = null;
        private string strCon = @"Data Source=DESKTOP-PV2UP24;Initial Catalog=CADASTRO;Integrated Security=True";
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
            strSql = "insert into CLIENTE (Nome,Email,Logotipo) values (@Nome,@Email,@logotipo)";


            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            MemoryStream memory = new MemoryStream();
            bmp.Save(memory, ImageFormat.Bmp);
           var  foto = memory.ToArray();

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_name.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txt_email.Text;
            comando.Parameters.Add("@logotipo", SqlDbType.VarBinary).Value = foto;
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

        private void btn_alterar_Click(object sender, EventArgs e)
        {

            strSql = "update Clientes set Nome = @Nome, Email = @Email , Logotipo = @logotipo where ID_Cli = @ID_Cli";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            MemoryStream memory = new MemoryStream();
            bmp.Save(memory, ImageFormat.Bmp);
            var foto = memory.ToArray();

            comando.Parameters.Add("@ID_Cli", SqlDbType.VarChar).Value = txt_id.Text;
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_name.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txt_email.Text;
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
            strSql = "select l.COD_Cli,c.Nome,c.Email,c.Logotipo,l.Logradouro from LOGRADOURO as l" +
                " inner join CLIENTE as c " +
                "on c.ID_Cli = l.COD_Cli  where Nome like @Pesquisa";

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
            strSql = "delete from CLIENTE where @ID_Cli = ID_Cli";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@ID_cli", SqlDbType.VarChar).Value = txt_id.Text;

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
            
            strSql = "select * from CLIENTE where ID_Cli like @ID_Cli";



            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            var row = dgv_busca.CurrentRow;

            String id = row.Cells[0].Value.ToString();

            comando.Parameters.Add("@ID_Cli", SqlDbType.VarChar).Value = id;

            try
            {
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                txt_id.Text = Convert.ToString(dr["ID_Cli"]);
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

      
    }
}
