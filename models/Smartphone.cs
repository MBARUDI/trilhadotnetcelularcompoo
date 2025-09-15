using System;

#pragma warning disable IDE0130 // O namespace não corresponde à estrutura da pasta
namespace DesafioPOO.Models
#pragma warning restore IDE0130 // O namespace não corresponde à estrutura da pasta
{
    // A classe é abstrata e serve como um modelo base para outros tipos de smartphone.
    public abstract class Smartphone
    {
        // Propriedades para armazenar as informações do smartphone.
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }

        // Construtor para inicializar todas as propriedades.
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        // Métodos concretos, comuns a todos os smartphones.
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato que deve ser implementado nas classes filhas.
        public abstract void InstalarAplicativo(string nomeApp);
    }
}