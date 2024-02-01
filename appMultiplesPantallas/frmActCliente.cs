﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appMultiplesPantallas
{
    public partial class frmActCliente : Form
    {
        public string strConn = "Data Source=(local); Initial Catalog=facturacion; Integrated Security=SSPI";

        public frmActCliente()
        {
            InitializeComponent();
            LlenarCmbClientes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                SqlDataAdapter da = new SqlDataAdapter("SELECT nombre_cli FROM Clientes ", conn);
                da.Fill(ds, "Clientes");
                cmbClientes.DataSource = ds.Tables[0].DefaultView;
                cmbClientes.ValueMember = "nombre_cli";
                conn.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            object itemSeleccionado = cmbClientes.SelectedItem;
            string user = ((DataRowView)itemSeleccionado)["nombre_cli"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string commUser = "SELECT id_cliente, nombre_cli, dir_cli, tel_cli, fecha_nac FROM Clientes WHERE nombre_cli = '"+user+"'";
                using (SqlCommand comm = new SqlCommand(commUser,conn))
                {
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        txtID.AppendText(reader["id_cliente"].ToString());
                        txtNombre.AppendText(reader["nombre_cli"].ToString());
                        txtDireccion.AppendText(reader["dir_cli"].ToString());
                        txtTelefono.AppendText(reader["tel_cli"].ToString());
                        txtFecha.AppendText(reader["fecha_nac"].ToString());
                    }
                    ActivarEdicion();


                }
            }

        }

        public void ActivarEdicion()
        {
            btnGuardar.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtFecha.Enabled = true;
            txtNombre.Enabled = true;
        }
        public void LimpiarTxt()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtFecha.Clear();
        }
        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarTxt();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            object itemSeleccionado = cmbClientes.SelectedItem;
            string user = ((DataRowView)itemSeleccionado)["nombre_cli"].ToString();
            string commUser = "SELECT id_cliente, nombre_cli, dir_cli, tel_cli, fecha_nac FROM Clientes WHERE nombre_cli = '"+user+"'";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                conn.Close();

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                object itemSeleccionado = cmbClientes.SelectedItem;
                string user = ((DataRowView)itemSeleccionado)["nombre_cli"].ToString();
                //Updates a realizar
                string commUpdateDir = "UPDATE Clientes SET dir_cli=@direccion WHERE nombre_cli=@nombre";
                string commUpdateNom = "UPDATE Clientes SET nombre_cli=@nombre_cli WHERE nombre_cli=@nombre";
                //string commUpdateTel = "UPDATE Clientes SET tel_cli=@telefono WHERE nombre_cli=@nombre";
                string commUpdateTel = "UPDATE Clientes SET tel_cli=@telefono WHERE nombre_cli=@nombre AND (tel_cli <> @telefono OR tel_cli IS NULL OR @telefono IS NULL)";
                string commUpdateFec = "UPDATE Clientes SET fecha_nac=@fecha WHERE nombre_cli=@nombre";

                //Conexion a BD

                using (SqlCommand comm = new SqlCommand(commUpdateDir, conn))
                {
                    comm.CommandType = CommandType.Text;
                    comm.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    comm.Parameters.AddWithValue("@nombre", user);
                    int rowAffect = comm.ExecuteNonQuery();
                    Console.WriteLine(rowAffect);
                }
                
                using (SqlCommand comm = new SqlCommand(commUpdateNom, conn))
                {
                    comm.CommandType = CommandType.Text;
                    comm.Parameters.AddWithValue("@nombre_cli", txtNombre.Text);
                    comm.Parameters.AddWithValue("@nombre", user);
                    int rowAffect = comm.ExecuteNonQuery();
                    Console.WriteLine(rowAffect);
                }

                using (SqlCommand comm = new SqlCommand(commUpdateTel, conn))
                {
                    comm.CommandType = CommandType.Text;
                    comm.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    comm.Parameters.AddWithValue("@nombre", user);
                    int rowAffect = comm.ExecuteNonQuery();
                    Console.WriteLine(rowAffect);
                }

                using (SqlCommand comm = new SqlCommand(commUpdateFec, conn))
                {
                    comm.CommandType = CommandType.Text;
                    if (DateTime.TryParseExact(txtFecha.Text, "d/M/yyyy H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fecha))
                    {
                        comm.Parameters.AddWithValue("@fecha", fecha);
                        comm.Parameters.AddWithValue("@nombre", user);
                        int rowAffect = comm.ExecuteNonQuery();
                        Console.WriteLine(rowAffect);
                    }
                    else
                    {
                        Console.WriteLine("Formato de fecha no válido. El formato debe ser 'd/M/yyyy H:mm:ss'.");
                        // Tratar el caso en el que la fecha no es válida.
                    }
                }
                


                conn.Close();
            }
        }
    }
    }
    

