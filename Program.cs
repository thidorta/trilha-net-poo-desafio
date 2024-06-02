using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new("1212", "Nokia-98", "101010", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");
nokia.Desligar();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new("1515", "Iphone 14", "111111110", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");
iphone.Desligar();