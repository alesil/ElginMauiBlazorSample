using Microsoft.AspNetCore.Components;

namespace ElginMauiBlazorSample.Pages;
public partial class E1Bridge : ComponentBase
{
    private string _ip = "192.168.3.20";
    private int _parcelas = 1;
    private int _valor = 200;
    private int _portaTransacao = 3000;
    private int _portaStatus = 3001;
    private bool _enviarSenha = false;
    private string _senha = string.Empty;

    private bool _isCredito = true;
    private bool _isDebito = true;

    private void EnviarTransacao()
    {
        var x = _ip;
    }
}
