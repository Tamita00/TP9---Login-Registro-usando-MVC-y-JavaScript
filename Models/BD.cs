using System.Data.SqlClient;
using Dapper;
namespace TP6;

public class BD{
    private static string ConnectionString = @"Server=localhost;DataBase=TP9;Trusted_Connection=True;";
    public static void AgregarUsuario(Usuario user){
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "INSERT INTO Usuario(UserName, Contraseña, Telefono, Nombre, Genero) VALUES (@pUserName, @pContraseña, @pTelefono, @pNombre, @pGenero)";
            db.Execute(sql, new { pUserName = user.userName, pContraseña = user.contraseña, @pTelefono = user.Telefono, @pNombre = user.Nombre, @pGenero = user.Genero});
        }    
    }

    public static List<Usuario> MostrarInfo(){
        List <Usuario> InfoUsuario = new List<Usuario>();
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Usuario";
            InfoUsuario = db.Query<Usuario>(sql).ToList();
        }
        return InfoUsuario;
    }

    public static void CambiarContra(Usuario user){
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "UPDATE Usuario SET Contraseña = @pcontraseña WHERE UserName = @pUserName";
            db.Execute(sql, new { pUserName = user.userName, pContraseña = user.contraseña});
        }    
    }


}