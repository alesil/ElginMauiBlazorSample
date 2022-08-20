using Microsoft.AspNetCore.Components;

namespace ElginMauiBlazorSample.Pages;
public partial class Impressora : ComponentBase
{
    private bool _showSpinner = false;
    private readonly Dados _dados = new();
    private EPaginaImpressora _paginaImpressora = EPaginaImpressora.ImpressoraTexto;

    public RenderFragment ChildContent { get; set; }

    private void ShowSpinner()
    {
        _showSpinner = true;
        StateHasChanged();
    }

    private void HideSpinner()
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


    private class Dados
    {
        public ETipoImpresora TipoImpresora { get; set; } = ETipoImpresora.Interna;
        public string ImpressoraIp { get; set; } = "192.168.2.160:9100";
    }

    private enum ETipoImpresora
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

