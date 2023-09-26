using System.Data.SqlClient;
using Dapper;
namespace TP9;

public class BD{
    private static string ConnectionString = @"Server=localhost;DataBase=TP9;Trusted_Connection=True;";
    public static void AgregarUsuario(string UserName, string Contraseña, int Telefono, string Nombre, string Genero){
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "INSERT INTO Usuario(UserName, Contraseña, Telefono, Nombre, Genero) VALUES (@pUserName, @pContraseña, @pTelefono, @pNombre, @pGenero)";
            db.Execute(sql, new { pUserName = UserName, pContraseña = Contraseña, @pTelefono = Telefono, @pNombre = Nombre, @pGenero = Genero});

        }   
    }

    public static Usuario MostrarInfo(string UserName, string Contraseña){
        Usuario usuario = null;
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Usuario WHERE UserName = @pUserName AND Contraseña = @pContraseña";
            usuario = db.QueryFirstOrDefault<Usuario>(sql, new { pUserName = UserName, pContraseña = Contraseña});
        }
        return usuario;
    }

    public static void CambiarContra(string UserName, string Contraseña){
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "UPDATE Usuario SET Contraseña = @pcontraseña WHERE UserName = @pUserName";
            db.Execute(sql, new { pUserName = UserName, pcontraseña = Contraseña});
        }    
    }


}