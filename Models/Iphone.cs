namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp, int memoria)
        {
            if(memoria > this.Memoria)
            {
                Console.WriteLine($"Memória insuficiente. O espaço dispinível é: {this.Memoria}. \n" + 
                    $"Necessário liberar {memoria - this.Memoria} de memória para instalar o aplicativo {nomeApp}. \n" +
                    $"A instalação será pausada e prosseguirá quando existir memória suficiente.");
                return;
            }
            this.Memoria -= memoria;
            Console.WriteLine($"O aplicativo {nomeApp} foi instalado no {this.Modelo}");
        }
    }
}