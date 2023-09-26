class Usuario{
    public string UserName{get;set;}
    public string Contraseña {get;set;}
    public string Nombre {get;set;}
    public int Telefono {get;set;}
    public string Genero {get;set;}
}
public Usuario() {}

public Usuario(string UserName, string Contraseña, string Nombre, int Telefono, string Genero){
    UserName=username;
    Contraseña=contraseña;
    Nombre=nombre;
    Telefono=telefono;
    Genero=genero;
}