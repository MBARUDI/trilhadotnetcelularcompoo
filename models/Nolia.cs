using System;

#pragma warning disable IDE0130 // O namespace não corresponde à estrutura da pasta
namespace DesafioPOO.Models
#pragma warning restore IDE0130 // O namespace não corresponde à estrutura da pasta
{
    // A classe Nokia herda de Smartphone.
    public class Nokia : Smartphone
    {
        // O construtor da classe filha chama o construtor da classe pai (base).
        public Nokia(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // Implementação do método abstrato "InstalarAplicativo".
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' na loja da Nokia.");
        }
    }
}