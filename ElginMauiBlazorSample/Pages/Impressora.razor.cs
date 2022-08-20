using Microsoft.AspNetCore.Components;

namespace ElginMauiBlazorSample.Pages;
public partial class Impressora : ComponentBase
{
    private bool _showSpinner = false;
    public readonly Dados DadosImpressora = new();
    private EPaginaImpressora _paginaImpressora = EPaginaImpressora.ImpressoraTexto;


    public RenderFragment ChildContent { get; set; }

    public void ShowSpinner()
    {
        _showSpinner = true;
        StateHasChanged();
    }

    public void HideSpinner()
    {
        _showSpinner = false;
        StateHasChanged();
    }

    private void ClickImpressoraTexto()
    {
        _paginaImpressora = EPaginaImpressora.ImpressoraTexto;
    }

    private void ClickImpressoraBarcode()
    {
        _paginaImpressora = EPaginaImpressora.ImpressoraBarcode;
    }

    private void ClickImpressoraImagem()
    {
        _paginaImpressora = EPaginaImpressora.ImpressoraImagem;
    }


    public class Dados
    {
        public ETipoImpresora TipoImpresora { get; set; } = ETipoImpresora.Interna;
        public string ImpressoraIp { get; set; } = "192.168.2.160:9100";
    }

    public enum ETipoImpresora
    {
        Interna,
        Usb,
        Ethernet
    }

    private enum EPaginaImpressora
    {
        ImpressoraTexto,
        ImpressoraBarcode,
        ImpressoraImagem
    }
}

