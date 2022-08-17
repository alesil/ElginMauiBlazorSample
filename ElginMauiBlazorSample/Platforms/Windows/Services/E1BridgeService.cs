using ElginMauiBlazorSample.Platforms.Windows.ExternalServices;

/* *** *** *** *** *** */
/*  Platform WINDOWS   */
/* *** *** *** *** *** */

namespace ElginMauiBlazorSample.Services;
public partial class E1BridgeService
{
    private partial void DoConstructor() { }

    public partial string IniciaVenda(int idTransacao, string pdv, string valorTotal)
        => E1BridgeWin.IniciaVenda_RetornoDireto(idTransacao, pdv, valorTotal);

    public partial string IniciaVendaDebito(int idTransacao, string pdv, string valorTotal)
        => E1BridgeWin.IniciaVendaDebito_RetornoDireto(idTransacao, pdv, valorTotal);

    public partial string IniciaVendaCredito(int idTransacao, string pdv, string valorTotal, int tipoFinanciamento, int numParcelas)
        => E1BridgeWin.IniciaVendaCredito_RetornoDireto(idTransacao, pdv, valorTotal, tipoFinanciamento, numParcelas);

    public partial string IniciaCancelamentoVenda(int idTransacao, string pdv, string valorTotal, string dataHora, string nsu)
        => E1BridgeWin.IniciaCancelamentoVenda_RetornoDireto(idTransacao, pdv, valorTotal, dataHora, nsu);

    public partial string IniciaOperacaoAdministrativa(int idTransacao, string pvd, int operacao)
        => E1BridgeWin.IniciaOperacaoAdministrativa_RetornoDireto(idTransacao, pvd, operacao);

    public partial string ImprimirCupomNfce(string xml, int indexcsc, string csc)
        => E1BridgeWin.ImprimirCupomNfce_RetornoDireto(xml, indexcsc, csc);

    public partial string ImprimirCupomSat(string xml)
        => E1BridgeWin.ImprimirCupomSat_RetornoDireto(xml);

    public partial string ImprimirCupomSatCancelamento(string xml, string assQRCode)
        => E1BridgeWin.ImprimirCupomSatCancelamento_RetornoDireto(xml, assQRCode);

    public partial string SetSenha(string senha, bool habilitada)
        => E1BridgeWin.SetSenha_RetornoDireto(senha, habilitada);

    public partial string ConsultarStatus()
        => E1BridgeWin.ConsultarStatus_RetornoDireto();

    public partial string GetTimeout()
        => E1BridgeWin.GetTimeout_RetornoDireto();

    public partial string ConsultarUltimaTransacao(string pdv)
        => E1BridgeWin.ConsultarUltimaTransacao_RetornoDireto(pdv);

    public partial string SetSenhaServer(string senha, bool habilitada)
        => E1BridgeWin.SetSenhaServer_RetornoDireto(senha, habilitada);

    public partial string SetTimeout(int timeout)
        => E1BridgeWin.SetTimeout_RetornoDireto(timeout);

    public partial string GetServer()
        => E1BridgeWin.GetServer_RetornoDireto();

    public partial string SetServer(string ipTerminal, int portaTransacao, int portaStatus)
        => E1BridgeWin.SetServer_RetornoDireto(ipTerminal, portaTransacao, portaStatus);
}

