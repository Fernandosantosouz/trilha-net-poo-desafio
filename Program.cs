using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "81594037", modelo: "Nokia Lumia", imei: "123456", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "85875057", modelo: "Iphone 11", imei: "654321", memoria: 500);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");