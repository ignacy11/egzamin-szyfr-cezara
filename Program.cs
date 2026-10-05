namespace szyfr_cezara;

class Cipher
{
    // private int cipherKey;
    // private string cipherText;
    
    public string encryptedText;
    public string[] letters =
    [
        "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
    ];

    public string GenerateCipher(string text, int key)
    { 
        List<string> charsList = new();
        
        foreach (var item in text)
        {
            charsList.Add(item.ToString());
        }

        List<int> letterIndexes = new();
        for (int i = 0; i < charsList.Count; i++)
        {
            letterIndexes.Add(letters.IndexOf(charsList[i]));
        }
        
        List<string> cipheredList = new();
        for(int i = 0; i < charsList.Count; i++)
        {
            var letterToAdd = "";
            var currentLetterIndex = letterIndexes[i];
            
            if (Array.FindIndex(letters, letter => letter == charsList[i]) + 1 + key > letters.Length)
            {
                int newIndex = Array.FindIndex(letters, letter => letter == charsList[i]) + key % letters.Length;
                letterToAdd = letters[newIndex];
            }
            else
            {
                letterToAdd = letters[currentLetterIndex + key];
            }
            cipheredList.Add(letterToAdd);
            // cipheredList.RemoveAt(0);
        }
        
        for (int i = 0; i < cipheredList.Count; i++)
        {
            encryptedText += cipheredList[i];
        }

        return encryptedText;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Cipher cipher = new Cipher();
        cipher.GenerateCipher("aaaaa", 20);
        Console.WriteLine(cipher.encryptedText);
        
        // TODO: if letter index equals -1, treat it as a space
    }
}