using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using Banco;
using System.IO;

namespace Armazenamento_de_Dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //timemax. = false;
            Conexao.Active(true);
            try
            {
                FbCommand da = new FbCommand("SELECT max(f.frentid)as fmax, max(b.bombaid)as bmax, max(t.pagid)as tmax, min (f.frentid)as fmin, min (b.bombaid)as bmin, min(t.pagid)as tmin  FROM frentista f, bomba b, tipo_pagamento t ", Conexao.FbCnn);

                FbDataReader dr = da.ExecuteReader();
                if (dr.Read())
                {
                    txtFrentMax.Text = dr["fmax"].ToString();
                    txtFrentMin.Text = dr["fmin"].ToString();
                    txtBombMax.Text = dr["bmax"].ToString();
                    txtBombMin.Text = dr["bmin"].ToString();
                    txttipomax.Text = dr["tmax"].ToString();
                    txttipomin.Text = dr["tmin"].ToString();
                }
            }
            finally
            {
                Conexao.Active(false);
            }

            Total();
        }


        //----------------------------BOTOES--------------------------------------------------------
       
        private void btngera_Click(object sender, EventArgs e)
        {
            
            if ((txtreg.TextLength > 0) && (Convert.ToInt32(txtreg.Text)>0 ) )
            {
                if ((chkmanha.Checked) || (chktarde.Checked) || (chknoite.Checked))
                {
                    if (!(chksegunda.Checked) && !(chkterca.Checked) && !(chkquarta.Checked) && !(chkquinta.Checked) && !(chksexta.Checked) && !(chksabado.Checked) && !(chkdomingo.Checked))
                    {
                        GeraDados();
                        CarregaDados();
                        Total();
                    }
                    else
                    {
                        MessageBox.Show("Escolha ao menos um Dia da Semana!!!");
                        chksegunda.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Escolha ao menos um Turno!!!");
                    chkmanha.Focus();
                }
            }
            else
            {
                MessageBox.Show("Digite um valor Maior que Zero, no campo Registro !!!");
                txtreg.Focus();
            }
        
        }

        private void btncarrega_Click(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void btnapaga_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Apagar\nTodos os Registros?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Conexao.Active(true);
                try
                {
                    FbCommand cmd = new FbCommand("delete from abastecimento", Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    // MessageBox.Show("Registros incluído com sucesso !!!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                MessageBox.Show("Registros excluídos com sucesso !!!");
                Conexao.Active(false);
                dgvabast.DataSource = null;
                Total();
            }
            

        }
        
        //--------------------------METODOS---------------------------------------------------------
        
        private void Total()
        {
            Conexao.Active(true);
            try
            {

                FbCommand da = new FbCommand("SELECT max(abastid)as amax FROM abastecimento", Conexao.FbCnn);

                FbDataReader dr = da.ExecuteReader();
                if (dr.Read())
                {
                label4.Text = dr["amax"].ToString();
                    if (dr["amax"].GetType().ToString().Contains("Null"))
                        {
                            label4.Text = "0";
                        }
                   
                }
            }
            finally
            {
                Conexao.Active(false);

            }
        }
        
        private void GeraDados()
        {

            Conexao.Active(true);

                int x = Convert.ToInt32(label4.Text);
                int y = 0;

                Random aleatorio = new Random();
                int frentista;
                int bomba;
                int tipo;
                int turno;

                string strIncluir = "EXECUTE BLOCK AS BEGIN\n";


                while (x < (int.Parse(txtreg.Text) + Convert.ToInt32(label4.Text)))
                {
                    x++;
                    y++;
                    frentista = aleatorio.Next(Convert.ToInt32(txtFrentMin.Text), Convert.ToInt32(txtFrentMax.Text)+1);
                    bomba = aleatorio.Next(Convert.ToInt32(txtBombMin.Text), Convert.ToInt32(txtBombMax.Text)+1);
                    tipo = aleatorio.Next(Convert.ToInt32(txttipomin.Text),Convert.ToInt32(txttipomax.Text)+1);




                    strIncluir = strIncluir + "INSERT INTO abastecimento VALUES(" + x + ",'" +
                                              tipo.ToString() + "', '" +
                                              tipo.ToString() + "'," +
                                              bomba.ToString() + ", " +
                                              frentista.ToString() + ", " +
                                              tipo.ToString() + ");\n";

                  //  MessageBox.Show(strIncluir);


                    if ((y == 255) || (x == (int.Parse(txtreg.Text) + Convert.ToInt32(label4.Text)))) //esse passo é poque o firebird nao 
                    {
                        y = 0;
                        strIncluir = strIncluir + "end";
                        //MessageBox.Show(strIncluir);
                      
                        try
                        {
                            FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                            cmd.ExecuteNonQuery();
                       //        MessageBox.Show( y+"Registros incluído com sucesso !!!");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        strIncluir = "EXECUTE BLOCK AS BEGIN\n";
                       
                        
                    }
                }

                Conexao.Active(false);
                MessageBox.Show("Registros incluído com sucesso !!!");
                txtreg.Clear();
               
            }
       
        private void CarregaDados()
        {
            Conexao.Active(true);
            try
            {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM ABASTECIMENTO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvabast.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Tabela Vazia!!");
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "DADOS.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Assim que os dados forem exportados, voce será notificado.");
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Não foi possivel exportar os dados neste disco!!!" + ex.Message);
                    }
                }
                int columnCount = dgvabast.ColumnCount;
                string columnNames = "";
                string[] output = new string[dgvabast.RowCount + 1];
                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += dgvabast.Columns[i].Name.ToString() + ";";
                }
                output[0] += columnNames;
                for (int i = 1; (i - 1) < dgvabast.RowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        output[i] += dgvabast.Rows[i - 1].Cells[j].Value.ToString().Replace(" 00:00:00","") + ";";
                    }
                }
                System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
                MessageBox.Show("Seus dados foram exportados com sucesso.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmbombas bombas = new frmbombas();
            bombas.ShowDialog();
        }


        private void lblfrent_Click(object sender, EventArgs e)
        {
            frmfrent frent = new frmfrent();
            frent.ShowDialog();
        }
        
        private void lbltipo_Click(object sender, EventArgs e)
        {
            frmtipo tipo = new frmtipo();
            tipo.ShowDialog();
        }

        

        
    }
}
