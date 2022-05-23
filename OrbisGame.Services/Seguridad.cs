using OrbisGame.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using OrbisGame.DataAccess;


namespace OrbisGame.Services
{
    
    public class Seguridad
    {
        DataAccess.ADONETAccess dataAccess = new DataAccess.ADONETAccess();

        string cadena = "Data Source=LAPTOP-8IOVNCF4; database=CaiserBot; Integrated Security=true";
        public Usuarios Login(string Usuario, string Clave)
        {
            Usuarios user = null;

            SqlConnection conexionBase = new SqlConnection(cadena);
            conexionBase.Open();
            SqlCommand cmd = new SqlCommand("contraseña", conexionBase);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Contraseña", Clave);

            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                user = new Usuarios()
                {
                    //guardo en el objeto Usuario los campos de lo que me devuelve el reader
                    IdUsuario = int.Parse(leer["IdUsuario"].ToString()),
                    NombreyApellido = leer["NombreyApellido"].ToString(),
                    Usuario = leer["Usuario"].ToString(),
                    Contraseña = leer["Contraseña"].ToString(),
                    Mail = leer["Mail"].ToString()
                };
            }
            conexionBase.Close();
            leer.Close();
            return user;
        }
      
        public Administrador LogeoAdmin(string Admin, string Contraseña)
        {
            string cadena = "Data Source=LAPTOP-8IOVNCF4; database=CaiserBot; Integrated Security=true";
            Administrador user = null;
            SqlConnection conexionBase = new SqlConnection(cadena);
            conexionBase.Open();

            SqlCommand cmd = new SqlCommand("Logueo", conexionBase);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Admin", Admin);
            cmd.Parameters.AddWithValue("@Contraseña", Contraseña);


            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                user = new Administrador()
                {
                    //guardo en el objeto Usuario los campos de lo que me devuelve el reader
                    Admin= leer["Admin"].ToString(),
                    Contraseña = leer["Contraseña"].ToString()
                    
                };
            }
            conexionBase.Close();
            leer.Close();
            return user;


        }
       
    }

    
}

    
