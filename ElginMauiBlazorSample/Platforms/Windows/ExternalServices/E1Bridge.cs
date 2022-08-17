using System.Runtime.InteropServices;

namespace ElginMauiBlazorSample.Platforms.Windows.ExternalServices;
public class E1BridgeW
{
    public const string DLL = @"Platforms\Windows\Library\E1_Bridge01_x64.dll";

    [DllImport(DLL, CallingConvention = CallingConvention.StdCall)]
    internal static extern string IniciaVenda(int idTransacao, string pdv, string valorTotal);

    [DllImport(DLL, CallingConvention = CallingConvention.StdCall)]
    internal static extern string IniciaVendaDebito(int idTransacao, string pdv, string valorTotal);

    [DllImport(DLL, CallingConvention = CallingConvention.StdCall)]
    internal static extern string IniciaVendaCredito(int idTransacao, string pdv, string valorTotal, int tipoFinanciamento, int numParcelas);

    [DllImport(DLL, CallingConvention = CallingConvention.StdCall)]
    internal static extern string IniciaCancelamentoVenda(int idTransacao, string pdv, string valorTotal, string dataHora, string nsu);

    [DllImport(DLL, CallingConvention = CallingConvention.StdCall)]
    internal static extern string IniciaOperacaoAdministrativa(int idTransacao, string pdv, int operacao);

    [DllImport(DLL, CallingConvention = CallingConvention.StdCall)]
    internal static extern string ImprimirCupomNfce(string xml, int indexcsc, string csc);

    [DllImport(DLL, CallingConvention = CallingConvention.StdCall)]
    internal static extern string ImprimirCupomSat(string xml);

    [DllImport(DLL, CallingConvention = CallingConvention.StdCall)]
    internal static extern string ImprimirCupomSatCancelamento(string xml, string assQRCode);

    [DllImport(DLL, CallingConvention = CallingConvention.StdCall)]
    internal static extern string SetSenha(string senha, bool habilitada);

    [DllImport(DLL, CallingConvention = CallingConvention.StdCall)]
    internal static extern string ConsultarStatus();

    [DllImport(DLL, CallingConvention = CallingConvention.StdCall)]
    internal static extern int GetTimeoutRef(ref string retorno);

    [DllImport(DLL, CallingConvention = CallingConvention.StdCall)]
    internal static extern string ConsultarUltimaTransacao(string pdv);

    [DllImport(DLL, CallingConvention = CallingConvention.StdCall)]
    internal static extern string SetSenhaServer(string senha, bool habilitada);

    [DllImport(DLL, CallingConvention = CallingConvention.StdCall)]
    internal static extern string SetTimeout(int timeout);

    [DllImport(DLL, CallingConvention = CallingConvention.StdCall)]
    internal static extern int GetServerRef(ref string retorno);

    [DllImport(DLL, CallingConvention = CallingConvention.StdCall)]
    internal static extern string SetServer(string ipTerminal, int portaTransacao, int portaStatus);

}
