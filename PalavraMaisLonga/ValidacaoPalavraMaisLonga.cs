
public class ValidacaoPalavraMaisLonga
{

    public static string ValidarPalavraMaisLonga(string stringSolicitada)
    {

        int index = 0;
        string  palavraMaisLonga = "";
        string[] words = stringSolicitada.Split();

        foreach (var word in words)
        {
            var text = word.Where(c => char.IsLetterOrDigit(c)).ToArray();
            if (index < text.Length)
            {
                palavraMaisLonga = word;
                index = text.Length;
            }
        }

        return palavraMaisLonga;
    }

}