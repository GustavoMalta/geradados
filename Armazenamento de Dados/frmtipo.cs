using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco;
using FirebirdSql.Data.FirebirdClient;

namespace Armazenamento_de_Dados
{
    public partial class frmtipo : Form
    {
        public frmtipo()
        {
            InitializeComponent();
        }

        private void frmtipo_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void CarregaDados()
        {
            Conexao.Active(true);
            try
            {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM TIPO_PAGAMENTO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvtipo.DataSource = dt;
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
    }
}
