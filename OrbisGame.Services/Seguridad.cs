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
        public  bool DescargarJuego(int Iduser,int IdJuego)
        {
            bool result = true;
            string SQLinsertDescarga = "Insert into Descargas(Id_Usuario, Id_Juego) values( @IdUsuario, @IdJuego)";
            List<SqlParameter> lstParameters = new List<SqlParameter>();

            lstParameters.Add(new SqlParameter() { ParameterName = "@IdUsuario", Value = Iduser });
            lstParameters.Add(new SqlParameter() { ParameterName = "@IdJuego", Value = IdJuego });



            var insertResult = dataAccess.Insert(SQLinsertDescarga, lstParameters,true);

            if (insertResult != null)
            {

            }
            else
            {
                result = false;
            }

            return result;

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

        public bool Registro(Usuarios newUser)
        {
            
            bool result = true;
            string SQLInsert = "Insert into Usuarios(NombreyApellido,Usuario,Contraseña,Mail) values (@NombreyApellido,@Usuario,@Contraseña,@Mail)";
            List<SqlParameter> lstParameters = new List<SqlParameter>();

            lstParameters.Add(new SqlParameter() { ParameterName = "@NombreyApellido", Value = newUser.NombreyApellido });
            lstParameters.Add(new SqlParameter() { ParameterName = "@Usuario", Value = newUser.Usuario });
            lstParameters.Add(new SqlParameter() { ParameterName = "@Mail", Value = newUser.Mail });
            lstParameters.Add(new SqlParameter() { ParameterName = "@Contraseña", Value = newUser.Contraseña });


            var insertResult = dataAccess.Insert(SQLInsert, lstParameters, true);

            if (insertResult != null)
            {

            }
            else
            {
                result = false;
            }

            return result;

        }

        public bool eliminarUsuario(int idUser)
        {
            bool result = true;
            string SQLdelete = "Delete from Usuarios where IdUsuario=@IdUsuario";
            List<SqlParameter> lstParameters = new List<SqlParameter>();

            lstParameters.Add(new SqlParameter() { ParameterName = "@IdUsuario", Value = idUser });



            var insertResult = dataAccess.Delete(SQLdelete,lstParameters);

            if (insertResult != null)
            {

            }
            else
            {
                result = false;
            }

            return result;

        }

        public List<Usuarios> GetAllUsers()
        {
            List<Usuarios> users = new List<Usuarios>();


            var dataResult = dataAccess.GetAll("SELECT * from Usuarios", null);

            if (dataResult != null && dataResult.Rows.Count > 0)
            {
                foreach (DataRow row in dataResult.Rows)
                {
                    users.Add(new Usuarios()
                    {
                        IdUsuario= int.Parse(row["IdUsuario"].ToString()),
                        NombreyApellido= row["NombreyApellido"].ToString(),
                        Usuario = row["Usuario"].ToString(),
                        Mail = row["Mail"].ToString(),
                        Contraseña = row["Contraseña"].ToString()
                    });
                }
            }
            return users;
        }

        public bool RegistroJuego(Juegos newJuego)
        {
            bool result = true;
            string SQLInsert = "Insert into Juegos(Nom_Juego,Categorias,Precio,Compatibilidad) values (@Nom_Juego,@Categorias,@Precio,@Compatibilidad)";
            List<SqlParameter> lstParameters = new List<SqlParameter>();

            lstParameters.Add(new SqlParameter() { ParameterName = "@Nom_Juego", Value = newJuego.Nom_Juego });
            lstParameters.Add(new SqlParameter() { ParameterName = "@Categorias", Value = newJuego.Categorias });
            lstParameters.Add(new SqlParameter() { ParameterName = "@Precio", Value = newJuego.Precio });
            lstParameters.Add(new SqlParameter() { ParameterName = "@Compatibilidad", Value = newJuego.Compatibilidad });


            var insertResult = dataAccess.Insert(SQLInsert, lstParameters, true);

            if (insertResult != null)
            {

            }
            else
            {
                result = false;
            }

            return result;

        }

        public List<Juegos> GetAllGame()
        {
            List<Juegos> game = new List<Juegos>();

            var dataResult = dataAccess.GetAll("SELECT * from Juegos", null);

            if (dataResult != null && dataResult.Rows.Count > 0)
            {
                foreach (DataRow row in dataResult.Rows)
                {
                    game.Add(new Juegos()
                    {
                        Id_Juego= int.Parse(row["Id_Juego"].ToString()),
                        Nom_Juego = row["Nom_Juego"].ToString(),
                        Categorias= row["Categorias"].ToString(),
                        Compatibilidad = row["Compatibilidad"].ToString(),
                        Precio = row["Precio"].ToString()
                    });
                }
            }
            return game;
        }

        public List<Juegos> GetAllDescargas(string User)
        {


            List<SqlParameter> lstParameters = new List<SqlParameter>();
            List<Juegos> download = new List<Juegos>();
            lstParameters.Add(new SqlParameter() { ParameterName = "@id_usuario", Value = User });


            var dataResult = dataAccess.GetAll("SELECT Juegos.Nom_Juego, dbo.Juegos.Categorias, dbo.Juegos.Compatibilidad FROM dbo.Usuarios INNER JOIN dbo.Descargas ON dbo.Usuarios.IdUsuario = dbo.Descargas.id_usuario INNER JOIN dbo.Juegos ON dbo.Descargas.Id_Juego = dbo.Juegos.Id_juego where Descargas.id_usuario =@id_usuario", lstParameters);
           

            if (dataResult != null && dataResult.Rows.Count > 0)
            {
                foreach (DataRow row in dataResult.Rows)
                {
                    download.Add(new Juegos()
                    {
                        Nom_Juego=row["Nom_Juego"].ToString(),
                        Categorias= row["Categorias"].ToString(),
                        Compatibilidad= row["Compatibilidad"].ToString()

                    });
                }
            }
            return download;

        }

    }

    
}

    
