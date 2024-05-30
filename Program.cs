using DesafioPOO.Models;

Iphone pro = new Iphone("27999777888", "Pro 14", "123456789", 4);
Iphone max = new Iphone("55322566877", "Max 12", "985621478", 2);

Nokia tijolao = new Nokia("28456123789", "Tijolao V5M", "012351236", 1);
Nokia nk = new Nokia("32568479852", "Nokia C2 Relm", "0002546879", 8);

pro.Ligar();
pro.InstalarAplicativo("Whatsapp");

Console.WriteLine("//-----------------------------------------------------//");

tijolao.ReceberLigacao();
tijolao.InstalarAplicativo("Opera JX");