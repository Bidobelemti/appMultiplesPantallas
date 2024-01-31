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
            LlenarLstFacturas();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void LlenarLstFacturas()
        {
            lstFacturas.Items.Clear();
            lstFacturas.Items.Add("Numero de factura\t\tTotal\t\tFecha");
        }
        public void LlenarCmbClientes()
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("SELECT nombre_cli FROM Clientes ", conn);
                da.Fill(ds, "Clientes");
                cmbClientes.DataSource = ds.Tables[0].DefaultView;
                cmbClientes.ValueMember = "nombre_cli";
                conn.Close();
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            int userIndex = cmbClientes.SelectedIndex;
            string user;
            object itemSeleccionado = cmbClientes.SelectedItem;
            user = ((DataRowView)itemSeleccionado)["nombre_cli"].ToString();
            
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand("SELECT num_factura, total, fecha_fact From Clientes C, Facturas F WHERE nombre_cli = '" + user+"' and C.id_cliente = F.id_cliente", conn))
                {
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        lstFacturas.Items.Add("\t" + "\t\t" + reader["total"].ToString() + "\t\t" + reader["fecha_fact"].ToString());
                    }
                }
            }
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarLstFacturas();
        }
    }

  
    }

