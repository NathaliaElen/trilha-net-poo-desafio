using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 64);
nokia.ExibirInformacoes();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.Desligar();
nokia.InstalarAplicativo("WhatsApp");

Iphone iphone = new Iphone("987654321", "iPhone 12", "987654321098765", 128);
iphone.ExibirInformacoes();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.Desligar();
iphone.InstalarAplicativo("Instagram");