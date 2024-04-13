using System.Threading.Channels;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

 Console.WriteLine("Aparelho Nokia:");
 Nokia nokia = new Nokia("123321123", "nokia 720", "1111-01", 8);
 nokia.Ligar();
 nokia.InstalarAplicativo("Arknights");

 Console.WriteLine("");
 
 Console.WriteLine("Aparelho Iphone:");
 Iphone iphone = new Iphone("00123213", "Iphone X", "12223-02", 16);
iphone.ReceberLigacao();
 iphone.InstalarAplicativo("Blue Archive");