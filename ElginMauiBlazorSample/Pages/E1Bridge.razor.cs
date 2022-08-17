using ElginMauiBlazorSample.Services;

using Microsoft.AspNetCore.Components;

namespace ElginMauiBlazorSample.Pages;
public partial class E1Bridge : ComponentBase
{
    private Dados _dados = new();

    private async void EnviarTransacao()
    {
    }

    private async void ConsultarTimeout()
    {
        if (!VerificarConexaoBridgeServer()) return;
        VerificarEnvioSenha();

        string resultado = E1BridgeService.GetTimeout();
        await DialogService.DisplayAlert("Retorno E1-Bridge : Timeout do Terminal", resultado);
    }

    private async void ConsultarUltimaTransacao()
    {
        if (!VerificarConexaoBridgeServer()) return;
        VerificarEnvioSenha();

        string resultado = E1BridgeService.ConsultarUltimaTransacao("PDV2");
        await DialogService.DisplayAlert("Retorno E1-Bridge : Última Transação", resultado);
    }

    private async void ConsultarStatusTerminal()
    {
        if (!VerificarConexaoBridgeServer()) return;
        VerificarEnvioSenha();

        string resultado = E1BridgeService.ConsultarStatus();
        await DialogService.DisplayAlert("Retorno E1-Bridge : Status do Terminal", resultado);
    }

    private bool VerificarConexaoBridgeServer()
    {
        //Se o valor inseridos no campo IP e nas portas transação/status forem válidos, atualize as configurações
        if (ValidarIp() && ValidarPortaTransacao() && ValidarPortaStatus())
        {
            E1BridgeService.SetServer(_dados.Ip, _dados.PortaTransacao, _dados.PortaStatus);
            return true;
        }
        return false;
    }

    private void VerificarEnvioSenha()
    {
        E1BridgeService.SetSenha(_dados.Senha, _dados.EnviarSenha);
    }

    private bool ValidarIp()
    {
        System.Text.RegularExpressions.Regex regexIP = new (@"^([01]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])\.([01]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])\.([01]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])\.([01]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])$");

        bool isIpValid = regexIP.Match(_dados.Ip).Success;

        if (isIpValid) return true;

        DialogService.DisplayAlert("Alerta", "Insira um IP válido para a conexão Bridge!");
        return false;
    }

    private bool ValidarPortaTransacao()
    {
        switch (_dados.PortaTransacao)
        {
            case > 65535:
                DialogService.DisplayAlert("Alerta", "O valor inserido na porta de transação excede o limite esbelecido de 65535!");
                return false;
            case <= 0:
                DialogService.DisplayAlert("Alerta", "O valor inserido na porta de transação deve ser maior que zero!");
                return false;
            default:
                return true;
        }
    }

    private bool ValidarPortaStatus()
    {
        switch (_dados.PortaStatus)
        {
            case > 65535:
                DialogService.DisplayAlert("Alerta", "O valor inserido na porta de status excede o limite esbelecido de 65535!");
                return false;
            case <= 0:
                DialogService.DisplayAlert("Alerta", "O valor inserido na porta de status deve ser maior que zero!");
                return false;
            default:
                return true;
        }
    }

    private class Dados
    {
        public string Pdv { get; set; } = DeviceInfo.Name;
        public string Ip { get; set; } = "192.168.3.20";
        public decimal Valor { get; set; } = 2.50m;
        public int Parcelas { get; set; } = 2;
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
