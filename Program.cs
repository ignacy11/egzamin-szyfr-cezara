namespace szyfr_cezara;

class Cipher
{
    /*public string GenerujSzyfr(string tekst, int klucz)
    {
        List<char> listaZnakow = new();
        for (int i = 0; i < tekst.Length; i++)
        {
            listaZnakow.Add(tekst[i]);
        }
        Console.WriteLine();
    }*/
    
    // private int cipherKey;
    // private string cipherText;
    public string encryptedText;
    
    string[] letters =
    [
        "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
    ];

    public string GenerateCipher(string text, int key)
    { 
        List<string> charsList = new();
        
        foreach (var item in text)
        {
            charsList.Add(text[item].ToString());
        }
        // charsList = ["a", "b", "c"]

        foreach (var letter in charsList)
        {
            var letterIndex = charsList.IndexOf(letter);
            charsList.Insert(letterIndex + key, letter);
        }
        
        // turn back into a string
        foreach (var item in charsList)
        {
            // encryptedText += charsList[item];
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("main\n");

        Cipher cipher = new Cipher();

        cipher.GenerateCipher("abc", 3);
    }
}