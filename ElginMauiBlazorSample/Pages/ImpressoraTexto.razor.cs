using BR.Com.Daruma.Framework.Mobile.Sat.Impostos;
using ElginMauiBlazorSample.Services;

using Microsoft.AspNetCore.Components;

using static Android.Hardware.Camera;

using System.Runtime.CompilerServices;

namespace ElginMauiBlazorSample.Pages;
public partial class ImpressoraTexto : ComponentBase
{
    [CascadingParameter]
    private Impressora Parent { get; set; }

    private readonly Dados _dados = new();

    private void ShowSpinner(string mensagem) => Parent.ShowSpinner(mensagem);
    private void HideSpinner() => Parent.HideSpinner();

    private async void ImprimirTexto()
    {
        ShowSpinner("Imprimindo...");
        await Parent.VerificarConexaoImpressora();

        var parametros = new Dictionary<string, string>();

        string align = _dados.Alinhamento switch
        {
            EAlinhamento.Esquerda => "Esquerda",
            EAlinhamento.Centralizado => "Centralizado",
            EAlinhamento.Direita => "Direita",
            _ => " "
        };

        string selectedFontFamily = _dados.FontFamily;
        string selectedFontSize = _dados.FontSize;
        string varText = _dados.Mensagem;

        parametros.Add("text", varText);
        parametros.Add("align", align);
        parametros.Add("font", selectedFontFamily);
        parametros.Add("fontSize", selectedFontSize);
        if (_dados.Negrito) parametros.Add("isBold", "true");
        else parametros.Add("isBold", "false");

        if (_dados.Sublinhado) parametros.Add("isUnderline", "true");
        else parametros.Add("isUnderline", "false");

        if (string.IsNullOrWhiteSpace(_dados.Mensagem))
        {
            HideSpinner();
            await DialogService.DisplayAlert("Entrada Vazia", "Por favor, insira uma entrada de texto", "OK");
        }
        else
        {
            await PrinterService.ImprimeTextoAsync(parametros);
            await PrinterService.JumpLineAsync();
        }

        if (_dados.CutPaper)
        {
            await PrinterService.CutPaperAsync(1);
        }
        HideSpinner();
    }

    private class Dados
    {
        public string Mensagem { get; set; } = "ELGIN DEVELOPERS COMMUNITY";
        public EAlinhamento Alinhamento { get; set; } = EAlinhamento.Esquerda;
        public string FontFamily { get; set; } = "FONT A";
        public string FontSize { get; set; } = "17";
        public bool Negrito { get; set; } = false;
        public bool Sublinhado { get; set; } = false;
        public bool CutPaper { get; set; } = false;

    }

    private enum EAlinhamento
    {
        Esquerda,
        Centralizado,
        Direita
    }

}

