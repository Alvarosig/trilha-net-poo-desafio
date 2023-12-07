using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n = new Nokia("9999", "Moto G3", "ABC-123", 16);
Console.WriteLine(n.Numero);
n.InstalarAplicativo("Spotify");
n.Ligar();
Console.WriteLine("-------");

Iphone i = new Iphone("8888", "Iphone 11", "SSS-000", 64);
Console.WriteLine(i.Numero);
i.InstalarAplicativo("Instagram");
i.ReceberLigacao();