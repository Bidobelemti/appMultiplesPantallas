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

namespace appMultiplesPantallas
{
    public partial class frmProdPrecios : Form
    {
        public frmProdPrecios()
        {
            InitializeComponent();
            editarLstProductos();
        }
        string strConn = "Data Source=(local); Initial Catalog=facturacion; Integrated Security=SSPI";
        string strComm5caros = "SELECT TOP 5 nombre_prod, precio_unit, unidad FROM Productos ORDER BY precio_unit DESC";
        string strComm10caros = "SELECT TOP 10 nombre_prod, precio_unit, unidad FROM Productos ORDER BY precio_unit DESC";
        string strComm5baratos = "SELECT TOP 5 nombre_prod, precio_unit, unidad FROM Productos ORDER BY precio_unit";
        string strComm10baratos = "SELECT TOP 10 nombre_prod, precio_unit, unidad FROM Productos ORDER BY precio_unit";
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void editarLstProductos()
        {
            lstProductos.Items.Clear();
            lstProductos.Items.Add("Nombre\tPrecio unitario\tUnidades");
        }
        private void btnCincoCaros_Click(object sender, EventArgs e)
        {
            editarLstProductos();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(strComm5caros,conn))
                {
                    SqlDataReader reader = comm.ExecuteReader();

                    while (reader.Read())
                    {
                        lstProductos.Items.Add(reader["nombre_prod"] + "\t" + reader["precio_unit"].ToString() + "\t\t" + reader["unidad"].ToString());
                    }

                }
                conn.Close();
            } 
        }

        private void btnDiezCaros_Click(object sender, EventArgs e)
        {
            editarLstProductos();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(strComm10caros, conn))
                {
                    SqlDataReader reader = comm.ExecuteReader();

                    while (reader.Read())
                    {
                        lstProductos.Items.Add(reader["nombre_prod"] + "\t" + reader["precio_unit"].ToString() + "\t\t" + reader["unidad"].ToString());
                    }

                }
                conn.Close();
            }
        }

        private void btnCincoBaratos_Click(object sender, EventArgs e)
        {
            editarLstProductos();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(strComm5baratos, conn))
                {
                    SqlDataReader reader = comm.ExecuteReader();

                    while (reader.Read())
                    {
                        lstProductos.Items.Add(reader["nombre_prod"] + "\t" + reader["precio_unit"].ToString() + "\t\t" + reader["unidad"].ToString());
                    }

                }
                conn.Close();
            }
        }

        private void btnDiezBaratos_Click(object sender, EventArgs e)
        {
            editarLstProductos();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(strComm10baratos, conn))
                {
                    SqlDataReader reader = comm.ExecuteReader();

                    while (reader.Read())
                    {
                        lstProductos.Items.Add(reader["nombre_prod"] + "\t" + reader["precio_unit"].ToString() + "\t\t" + reader["unidad"].ToString());
                    }

                }
                conn.Close();
            }
        }
    }
}
