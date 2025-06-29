using DesafioPOO.Models;

Nokia nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "123456789012345", memoria: 64);
nokia.ExibirInformacoes();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.Desligar();
nokia.InstalarAplicativo("WhatsApp");

Iphone iphone = new Iphone(numero: "987654321", modelo: "IPhone 12", imei: "987654321098765", memoria: 128);
iphone.ExibirInformacoes();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.Desligar();
iphone.InstalarAplicativo("Instagram");