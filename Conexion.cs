using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; /*Imports agregados para el uso de sql*/
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

/* 1.- Server Explorer, 2. Connect to Database, 3.Choose Server Name, Choose DB, Click on the DB, Select Properties,Copy Connection String*/

namespace IPN1
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        SqlDataAdapter da;
        DataRow drow;

        /*****************************************************************CREACION DE CONEXION SQL*******************************************************/
        public Conexion()
        {

            try
            {
                //Importante poner el uso de "@" para no tener conflicto con "\"
                cn = new SqlConnection(@"Data Source=MANO-PC;Initial Catalog=kenpo;Integrated Security=True");
                cn.Open();//La direccion de arriba es la fuente de la base de datos, importante a la hora de utilizarla
                //MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }
        /********************************************************************************INSERTAR SQL**************************************************/
        public string Insertar(String NombreUsuario, String Contrasenia, String Nombre, String Apellido1, String Apellido2, int Edad, String Correo, float Peso, float Estatura, String Genero, PictureBox Imagen)
        {
            string salida = "Se inserto";

            try
            {
                cmd = new SqlCommand("Insert into USUARIO (NombreUsuario,Contrasenia,Nombre,ApellidoPaterno,ApellidoMaterno,Edad,CorreoElectronico,Peso,Estatura,Genero,Foto) values ('" + NombreUsuario + "','" + Contrasenia + "','" + Nombre + "','" + Apellido1 + "','" + Apellido2 + "'," + Edad + ",'" + Correo + "'," + Peso + "," + Estatura + ",'" + Genero + "',@Imagen)", cn);


                cmd.Parameters.Add("@Imagen", SqlDbType.Image);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@Imagen"].Value = ms.GetBuffer();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }

            return salida;
        }
        /*******************************************************************VALIDACION NOMBREUSUARIO******************************************************/
        public int Validacion(String NombreUsuario)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from USUARIO where NombreUsuario like '" + NombreUsuario + "' ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;//Si existe el usuario manda '1' en caso contrario '0'
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontrar" + ex.ToString());
            }

            return contador;
        }
        /*******************************************************************VALIDACION USUARIO Y CONTRASEÑA**********************************/
        public int ValidacionUsuarioContrasenia(String NombreUsuario, String Contrasenia)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from USUARIO where NombreUsuario like '" + NombreUsuario + "' AND Contrasenia collate latin1_general_cs_as like'" + Contrasenia + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;//Si existe el usuario manda '1' en caso contrario '0'
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontrar" + ex.ToString());
            }

            return contador;
        }
        /************************************VER IMAGEN RECUPERAR CONTRASEÑA*************************************************/
        public void verImagen(PictureBox pbFoto, String UsuarioID)
        {
            try
            {

                da = new SqlDataAdapter("Select Foto from USUARIO where NombreUsuario like '" + UsuarioID + "' ", cn);
                ds = new DataSet();
                da.Fill(ds, "USUARIO");
                byte[] datos = new byte[0];
                drow = ds.Tables["USUARIO"].Rows[0];
                datos = (byte[])drow["Foto"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pbFoto.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la Imagen: " + ex.ToString());
            }
        }
        /***************************************RECUPERAR INFORMACION****************************************************/
        public void Consulta(String UsuarioID, TextBox NombreUsuario, TextBox Nombre, TextBox ApellidoPaterno, TextBox ApellidoMaterno, TextBox Edad, TextBox CorreoElectronico, TextBox Peso, TextBox Estatura, TextBox Genero)
        {

            try
            {
                cmd = new SqlCommand("Select NombreUsuario,Nombre,ApellidoPaterno,ApellidoMaterno,Edad,CorreoElectronico,Peso,Estatura,Genero from USUARIO where NombreUsuario like '" + UsuarioID + "' ", cn);
                dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    NombreUsuario.Text = dr["NombreUsuario"].ToString();
                    Nombre.Text = dr["Nombre"].ToString();
                    ApellidoPaterno.Text = dr["ApellidoPaterno"].ToString();
                    ApellidoMaterno.Text = dr["ApellidoMaterno"].ToString();
                    Edad.Text = dr["Edad"].ToString();
                    CorreoElectronico.Text = dr["CorreoElectronico"].ToString();
                    Peso.Text = dr["Peso"].ToString();
                    Estatura.Text = dr["Estatura"].ToString();
                    Genero.Text = dr["Genero"].ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontrar" + ex.ToString());
            }

        }

        /***************************************************CONTEO DE USUARIOS EXISTENTES********************************************************/

        public int Conteo()
        {
            Int32 count = 0;

            try
            {
                cmd = new SqlCommand("Select count (*) as NumUsuarios from USUARIO",cn);
                count = (Int32)cmd.ExecuteScalar();
                //MessageBox.Show("Existen "+ Convert.ToString(count)+ " usuarios, elije el tuyo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al hacer el conteo" + ex.ToString());
            }
            return count;
        }
        /************************************VER IMAGEN RECUPERAR CONTRASEÑA*************************************************/
        public void verImagen1(PictureBox pbFoto, int ID, Label Usuario)
        {
            try
            {

                da = new SqlDataAdapter("Select Foto from USUARIO where ID = "+ ID +" ", cn);
                ds = new DataSet();
                da.Fill(ds, "USUARIO");
                byte[] datos = new byte[0];
                drow = ds.Tables["USUARIO"].Rows[0];
                datos = (byte[])drow["Foto"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pbFoto.Image = System.Drawing.Bitmap.FromStream(ms);


                cmd = new SqlCommand("Select NombreUsuario from USUARIO where ID = " + ID + " ", cn);
                dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                   Usuario.Text = dr["NombreUsuario"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la Imagen: " + ex.ToString());
            }
        }

    }
}
