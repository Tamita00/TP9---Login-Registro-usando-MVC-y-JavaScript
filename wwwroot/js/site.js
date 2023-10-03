function caracteresEspeciales (cadena){
    var expresionRegular = /[!@#$%^&*()_+{}\[\]:;<>,.?~\\/-]/;
    return expresionRegular.test(cadena)
}
function EsValida(){
const contraseña = document.getElementById('password');
if(contraseña === contraseña.toLowerCase || contraseña.length<8 || caracteresEspeciales(contraseña)){
    contraseña.innerHTML = "La contraseña no es valida, por favor ingrese una contraseña que cumpla con los requerimientos.";
return false;
}
else return true;
}