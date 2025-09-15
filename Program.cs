using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
// Cria um novo objeto Nokia.
Nokia nokia = new Nokia(numero: "123456789", modelo: "Tijolão", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n-------------------------------\n");

Console.WriteLine("Smartphone iPhone:");
// Cria um novo objeto Iphone.
Iphone iphone = new Iphone(numero: "987654321", modelo: "Modelo X", imei: "222222222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");