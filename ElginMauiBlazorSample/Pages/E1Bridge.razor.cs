using Microsoft.AspNetCore.Components;

namespace ElginMauiBlazorSample.Pages;
public partial class E1Bridge : ComponentBase
{
    private Dados _dados = new();

    private void EnviarTransacao()
    {
        
    }

    private class Dados
    {
        public string Ip { get; set; } = "192.168.3.20";
        public decimal Valor { get; set; } = 2.50m;
        public int Parcelas { get; set; } = 1;
        public int PortaTransacao { get; set; } = 3000;
        public int PortaStatus { get; set; } = 3001;
        public bool EnviarSenha { get; set; } = false;
        public string Senha { get; set; }
        public EFormaPagamento FormaPagamento { get; set; } = EFormaPagamento.Credito;
        public ETipoParcelamento TipoParcelamento { get; set; } = ETipoParcelamento.AVista;
    }

    private enum EFormaPagamento
    {
        Credito,
        Debito
    }
    private enum ETipoParcelamento
    {
        Loja,
        Administradora,
        AVista
    }
}
