using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElginMauiBlazorSample.Pages;
public partial class Impressora : ComponentBase
{
    private bool _showSpinner = false;
    private readonly Dados _dados = new();

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
}

