public class Usuario{
    public string UserName{get;set;}
    public string Contraseña {get;set;}
    public string Nombre {get;set;}
    public int Telefono {get;set;}
    public string Genero {get;set;}

public Usuario(){}

public Usuario(string pUserName, string pContraseña, string pNombre, int pTelefono, string pGenero){
    UserName=pUserName;
    Contraseña=pContraseña;
    Nombre=pNombre;
    Telefono=pTelefono;
    Genero=pGenero;
}
}