        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();
        Console.WriteLine(string.Join("-", palavra.ToUpper().ToCharArray()));