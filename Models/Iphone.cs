namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Baixando... {nomeApp}");
            Console.WriteLine($"Baixando... 100%");
            Console.WriteLine("----------------------------- // -----------------------------");
            Console.WriteLine($"Instalando... {nomeApp}");
            Console.WriteLine($"Instalação concluida: {nomeApp}");
            Console.WriteLine($"{nomeApp} foi instalado com sucesso!");
        }
    }
}