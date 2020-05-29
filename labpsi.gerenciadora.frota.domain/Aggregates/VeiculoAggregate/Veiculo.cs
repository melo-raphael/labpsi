using labpsi.gerenciadora.frota.domain.SeedWork;
using Newtonsoft.Json;
using System;

namespace labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate
{
    public class Veiculo : Entity, IAggregateRoot
    {
        [JsonProperty("placa")]
        public string Placa { get; set; }
        [JsonProperty("modelo")]
        public string Modelo { get; set; }
        [JsonProperty("ano")]
        public int Ano { get; set; }
        [JsonProperty("chassi")]
        public string Chassi { get; set; }
        [JsonProperty("renavam")]
        public string Renavam { get; set; }
        [JsonProperty("marca")]
        public string Marca { get; set; }
        [JsonProperty("cor")]
        public string Cor { get; set; }
        [JsonProperty("valorPago")]
        public decimal ValorPago { get; set; }
        [JsonProperty("mesIpva")]
        public int MesIpva { get; set; }
        [JsonProperty("kmAtual")]
        public string KmAtual { get; set; }
        //private int _combustivelId;
        //public Combustivel Combustivel { get; private set; }
        public Km _km { get; private set; }

        public Veiculo(string placa,
                       string modelo,
                       int ano,
                       string chassi,
                       string renavam,
                       string marca,
                       string cor,
                       //string combustivel,
                       decimal valorPago,
                       int mesIpva,
                       string kmAtual
                       )
        {
            Placa = placa;
            Modelo = modelo;
            Ano = ano;
            Chassi = chassi;
            Renavam = renavam;
            Marca = marca;
            Cor = cor;
            //_combustivelId = Combustivel.FromName(combustivel).Id;
            ValorPago = valorPago;
            MesIpva = mesIpva;
            KmAtual = kmAtual;
        }


        public void AtualizaKm(string kmAtual, DateTime dateSaida, DateTime dataEntrada, string destino)
        {
            _km = new Km(kmAtual, dateSaida, dataEntrada, destino);

            this.KmAtual += kmAtual;
        }
    }
}
