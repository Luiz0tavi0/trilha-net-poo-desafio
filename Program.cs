// Program.cs
using DesafioPOO.Models;
Nokia nokia = new("111234-5679");
Iphone iponey = new Iphone("192023-4678");

nokia.InstalarAplicativo("Youtube");
nokia.InstalarAplicativo("WhatsApp");


iponey.InstalarAplicativo("DuoLingo");

iponey.Ligar();
nokia.ReceberLigacao();