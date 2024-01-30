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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appMultiplesPantallas
{
    public partial class frmCliFacturas : Form
    {
        public String strConn = "Data Source=(local); Initial Catalog=facturacion; Integrated Security=SSPI";
        //consultar clientes
        public String strComm = "SELECT nombre_cli From Clientes C, Facturas F WHERE nombre_cli = 'Nancy Erazo' and C.id_cliente = F.id_cliente";

        public frmCliFacturas()
        {
            InitializeComponent();
            LlenarCmbClientes();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void LlenarCmbClientes()
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                DataSet ds = new DataSet();
                //endicamos la consulta en SQL
                SqlDataAdapter da = new SqlDataAdapter("SELECT nombre_cli FROM Clientes ", conn);
                //se indica el nombre de la tabla
                da.Fill(ds, "Clientes");
                cmbClientes.DataSource = ds.Tables[0].DefaultView;
                //se especifica el campo de la tabla
                cmbClientes.ValueMember = "nombre_cli";
                conn.Close();
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            int userIndex = cmbClientes.SelectedIndex;
            String userName = cmbClientes.GetItemText(userIndex);
            Console.WriteLine(userName);
        }
    }

  
    }

