using DesafioPOO.Models;

Console.WriteLine("Testando a classe Iphone");
Iphone iphone = new Iphone("16998568547", "13 Pro Max", "dfdfgergeg5448", 16000);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp", 2000);
iphone.InstalarAplicativo("FaceBook", 8000);
iphone.InstalarAplicativo("Discord", 8000);
Console.WriteLine($"Apenas o número é acessível. Número: {iphone.Numero}");
Console.WriteLine("Finalizado os testes da classe Iphone");

Console.WriteLine("Testando a classe Nokia");
Nokia nokia = new Nokia("35987584587", "K10", "sdfdgerver487r4e5fe", 32000);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp", 2000);
nokia.InstalarAplicativo("FaceBook", 8000);
nokia.InstalarAplicativo("Discord", 8000);
nokia.InstalarAplicativo("Instagram", 10000);
nokia.InstalarAplicativo("Messenger", 10000);
Console.WriteLine($"Apenas o número é acessível. Número: {nokia.Numero}");
Console.WriteLine("Finalizado os testes da classe Nokia");