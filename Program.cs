using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "999774521", modelo: "Nokia C2", imei: "987654321", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

string line = new string('-', 50);
Console.WriteLine(line);

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "999482316", modelo: "iPhone 15 Pro Max", imei: "654789321", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");