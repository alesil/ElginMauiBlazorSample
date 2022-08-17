using ElginMauiBlazorSample.Platforms.Windows.ExternalServices;

/* *** *** *** *** *** */
/*  Platform WINDOWS   */
/* *** *** *** *** *** */

namespace ElginMauiBlazorSample.Services;
public partial class E1BridgeService
{
    private partial void DoConstructor() { }

    public partial string IniciaVenda(int idTransacao, string pdv, string valorTotal)
        => E1BridgeWin.IniciaVenda(idTransacao, pdv, valorTotal);

    public partial string IniciaVendaDebito(int idTransacao, string pdv, string valorTotal)
        => E1BridgeWin.IniciaVendaDebito(idTransacao, pdv, valorTotal);

    public partial string IniciaVendaCredito(int idTransacao, string pdv, string valorTotal, int tipoFinanciamento, int numParcelas)
        => E1BridgeWin.IniciaVendaCredito(idTransacao, pdv, valorTotal, tipoFinanciamento, numParcelas);

    public partial string IniciaCancelamentoVenda(int idTransacao, string pdv, string valorTotal, string dataHora, string nsu)
        => E1BridgeWin.IniciaCancelamentoVenda(idTransacao, pdv, valorTotal, dataHora, nsu);

    public partial string IniciaOperacaoAdministrativa(int idTransacao, string pvd, int operacao)
        => E1BridgeWin.IniciaOperacaoAdministrativa(idTransacao, pvd, operacao);

    public partial string ImprimirCupomNfce(string xml, int indexcsc, string csc)
        => E1BridgeWin.ImprimirCupomNfce(xml, indexcsc, csc);

    public partial string ImprimirCupomSat(string xml)
        => E1BridgeWin.ImprimirCupomSat(xml);

    public partial string ImprimirCupomSatCancelamento(string xml, string assQRCode)
        => E1BridgeWin.ImprimirCupomSatCancelamento(xml, assQRCode);

    public partial string SetSenha(string senha, bool habilitada)
        => E1BridgeWin.SetSenha(senha, habilitada);

    public partial string ConsultarStatus()
        => E1BridgeWin.ConsultarStatus();

    public partial string GetTimeout()
    {
        //return E1BridgeW.Timeout;
        return "NÃO IMPLEMENTADO";
    }

    public partial string ConsultarUltimaTransacao(string pdv)
        => E1BridgeWin.ConsultarUltimaTransacao(pdv);

    public partial string SetSenhaServer(string senha, bool habilitada)
        => E1BridgeWin.SetSenhaServer(senha, habilitada);

    public partial string SetTimeout(int timeout)
        => E1BridgeWin.SetTimeout(timeout);

    public partial string GetServer()
    {
        // return E1BridgeW.Server;
        return "NÃO IMPLEMENTADO";
    }

    public partial string SetServer(string ipTerminal, int portaTransacao, int portaStatus)
        => E1BridgeWin.SetServer(ipTerminal, portaTransacao, portaStatus);
}

