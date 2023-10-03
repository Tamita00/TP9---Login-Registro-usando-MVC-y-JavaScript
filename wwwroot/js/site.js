function EsValida() {
    const contraseña = document.getElementById('password').value;
  
    if (/[A-Z]/.test(contraseña) && contraseña.length >= 8 && "/[!@#$%^&*()_+{}\[\]:;<>,.?~\\/-]/".test(contraseña)) {
      return true;
    }
    else {
      alert("La contraseña no es válida, por favor ingrese una contraseña que cumpla con los requerimientos.");
      return false;
    }

  }
  