using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OrbisGame.DataAccess;
using OrbisGame.Entidades;
using System.Data;

namespace OrbisGame.Services
{
    public class Usuario
    {

        DataAccess.ADONETAccess dataAccess = new DataAccess.ADONETAccess();

        string cadena = "Data Source=LAPTOP-8IOVNCF4; database=CaiserBot; Integrated Security=true";

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



            var insertResult = dataAccess.Delete(SQLdelete, lstParameters);

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
                        IdUsuario = int.Parse(row["IdUsuario"].ToString()),
                        NombreyApellido = row["NombreyApellido"].ToString(),
                        Usuario = row["Usuario"].ToString(),
                        Mail = row["Mail"].ToString(),
                        Contraseña = row["Contraseña"].ToString()
                    });
                }
            }
            return users;
        }
    }
}
