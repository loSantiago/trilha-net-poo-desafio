namespace DesafioPOO.Models
{ 
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Baixando... 10%");
            Console.WriteLine("Baixando... 50%");
            Console.WriteLine("Baixando... 100%");
            Console.WriteLine("----------------------------- // -----------------------------");
            Console.WriteLine($"Instalando... {nomeApp}");
            Console.WriteLine($"{nomeApp} foi instalado com sucesso!");
        }
    }
}