using DesafioPOO.Models;

Console.WriteLine("Criando smartphones....");
Console.WriteLine();

Smartphone iPhone = new Iphone("123456789","iPhone 6S","111111111111",256);
Console.WriteLine(iPhone.ToString());
Console.WriteLine();

Smartphone nokia = new Nokia("987654321","Nokia tijolão","222222222222",1);
Console.WriteLine(nokia.ToString());
Console.WriteLine();

Console.WriteLine("Usando iPhone...");
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("Usando Nokia...");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");