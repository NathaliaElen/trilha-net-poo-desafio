namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} via App Store no iPhone.");
            System.Threading.Thread.Sleep(2000); // Simula o tempo de instalação
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso.");
        }
    }
}