public class ValidaString {

  public static string ValidarNomeUsuario(string nomeUsuarioSolicitado) {

    if(nomeUsuarioSolicitado.Length < 4 || nomeUsuarioSolicitado.Length > 25) 
    {
      return "Quantidade de catacteres inválido !!";
    }

    if (!char.IsLetter(nomeUsuarioSolicitado[0]))
    {
        return "O primeiro caracter precisa ser uma letra !!";
    }

    foreach (char c in nomeUsuarioSolicitado)
    {
        if (!char.IsLetterOrDigit(c) && c != '_')
        {
            return "Utilize apenas letras, números e underline !!";
        }
    }

    if(nomeUsuarioSolicitado.EndsWith("_"))
    {
        return "Não é possível terminar o nome com underline !!";
    }
    
    return "true";

  }

}