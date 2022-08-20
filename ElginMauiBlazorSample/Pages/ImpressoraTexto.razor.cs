using Microsoft.AspNetCore.Components;

namespace ElginMauiBlazorSample.Pages;
public partial class ImpressoraTexto : ComponentBase
{
    [CascadingParameter]
    private Impressora Parent { get; set; }

    private readonly Dados _dados = new();

    private class Dados
    {
        public string Mensagem { get; set; } = "ELGIN DEVELOPERS COMMUNITY";
        public EAlinhamento Alinhamento { get; set; } = EAlinhamento.Esquerda;
        public string FontFamily { get; set; } = "A";
        public string FontSize { get; set; } = "34";
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

