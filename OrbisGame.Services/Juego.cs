using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrbisGame.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace OrbisGame.Services
{
    public class Juego
    {
        DataAccess.ADONETAccess dataAccess = new DataAccess.ADONETAccess();

        string cadena = "Data Source=LAPTOP-8IOVNCF4; database=CaiserBot; Integrated Security=true";

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
                        Id_Juego = int.Parse(row["Id_Juego"].ToString()),
                        Nom_Juego = row["Nom_Juego"].ToString(),
                        Categorias = row["Categorias"].ToString(),
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
                        Nom_Juego = row["Nom_Juego"].ToString(),
                        Categorias = row["Categorias"].ToString(),
                        Compatibilidad = row["Compatibilidad"].ToString()

                    });
                }
            }
            return download;

        }

        public bool DescargarJuego(int Iduser, int IdJuego)
        {
            bool result = true;
            string SQLinsertDescarga = "Insert into Descargas(Id_Usuario, Id_Juego) values( @IdUsuario, @IdJuego)";
            List<SqlParameter> lstParameters = new List<SqlParameter>();

            lstParameters.Add(new SqlParameter() { ParameterName = "@IdUsuario", Value = Iduser });
            lstParameters.Add(new SqlParameter() { ParameterName = "@IdJuego", Value = IdJuego });



            var insertResult = dataAccess.Insert(SQLinsertDescarga, lstParameters, true);

            if (insertResult != null)
            {

            }
            else
            {
                result = false;
            }

            return result;

        }


        public List<Juegos> SearchbyGameName(string nombrecampo, string nombre)
        {
            List<Juegos> game = new List<Juegos>();

            if (nombre!=null)
            {
                var dataResult = dataAccess.GetAll("SELECT * FROM Juegos WHERE " + nombrecampo + "=" + "'" + nombre + "'", null);

                if (dataResult != null && dataResult.Rows.Count > 0)
                {
                    foreach (DataRow row in dataResult.Rows)
                    {
                        game.Add(new Juegos()
                        {
                            Id_Juego = int.Parse(row["Id_Juego"].ToString()),
                            Nom_Juego = row["Nom_Juego"].ToString(),
                            Categorias = row["Categorias"].ToString(),
                            Compatibilidad = row["Compatibilidad"].ToString(),
                            Precio = row["Precio"].ToString()
                        });
                    }
                }

            }
            else
            {
                var dataResult = dataAccess.GetAll("SELECT * from Juegos", null);

                if (dataResult != null && dataResult.Rows.Count > 0)
                {
                    foreach (DataRow row in dataResult.Rows)
                    {
                        game.Add(new Juegos()
                        {
                            Id_Juego = int.Parse(row["Id_Juego"].ToString()),
                            Nom_Juego = row["Nom_Juego"].ToString(),
                            Categorias = row["Categorias"].ToString(),
                            Compatibilidad = row["Compatibilidad"].ToString(),
                            Precio = row["Precio"].ToString()
                        });
                    }
                }
            }
            return game;
        }
    }
}
