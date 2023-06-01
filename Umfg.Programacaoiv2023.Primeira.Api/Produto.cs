using System;
using System.Text.Json.Serialization;

namespace Umfg.Programacaoiv2023.RestFulProduto.Api
{
    public sealed class Produto
    {
        [JsonPropertyName("id")]
        public Guid Id { get; private set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("codigoBarra")]
        public long CodigoDeBarras { get; set; }

        [JsonPropertyName("valor")]
        public decimal Valor { get; set; }

        public Produto() { }

        public Produto(string descricao, long codigoDeBarras, decimal valor, int v)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
            CodigoDeBarras = codigoDeBarras;
            Valor = valor;
        }
    }
}