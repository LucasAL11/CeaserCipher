string Encipher(string input, int key)
{
    return input.Aggregate(string.Empty, (current, ch) => current + Cipher(ch, key));
}

string Decipher(string input, int key)
{
    return Encipher(input, 26 - key);
}

char Cipher(char ch, int key)
{
    var d = char.IsUpper(ch) ? 'A' : 'a';
    
    return !char.IsLetter(ch)
        ? ch
        : (char) (((ch + key - d) % 26) + d);
}


Console.WriteLine("Digite o texto a ser criptogrado:");
var UserString = Console.ReadLine();

Console.WriteLine("\n");

Console.Write("entre com sua chave");
var key = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");


Console.WriteLine("Texto criptografado: ");

var cipherText = Encipher(UserString, key);
Console.WriteLine(cipherText);
Console.Write("\n");

Console.WriteLine("Texto Decifrad: ");

var t = Decipher(cipherText, key);
Console.WriteLine(t);
Console.Write("\n");


Console.ReadKey();
