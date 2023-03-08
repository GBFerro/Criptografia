string original, criptografada;
char letra;

string LerString()
{
    Console.WriteLine("Digite uma frase: \n");
    return Console.ReadLine();
}

char LerChar()
{
    Console.WriteLine("Digite um caractere: \n");
    return char.Parse(Console.ReadLine());
}

string CriptografaTexto(string texto, char l)
{
    char[] aux = new char[original.Length * 2];
    string alterada = "";

    char[] aux2 = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    for (int i = 0, j = 0; i < texto.Length; i++)
    {
        if ((texto[i] != 'a') && (texto[i] != 'e') && (texto[i] != 'i') && (texto[i] != 'o')
            && (texto[i] != 'u') && (texto[i] != 'A') && (texto[i] != 'E')
            && (texto[i] != 'I') && (texto[i] != 'O') && (texto[i] != 'U'))
        {
            aux[j + 1] = texto[i];
            aux[j] = l;
            j += 2;
        }
        else
        {
            aux[j] = texto[i];
            j += 1;
        }
    }

    for (int k = 0; k < aux.Length; k++)
    {
        alterada += aux[k];
    }

    return alterada;
}

original = LerString();
letra = LerChar();
criptografada = CriptografaTexto(original, letra);
Console.WriteLine(criptografada);

