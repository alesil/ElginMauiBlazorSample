using ElginMauiBlazorSample.Platforms.Windows.ExternalServices;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* *** *** *** *** *** */
/*  Platform WINDOWS   */
/* *** *** *** *** *** */

namespace ElginMauiBlazorSample.Services;
public partial class E1BridgeService
{
    private partial void DoConstructor() { }

    public partial string IniciaVenda(int idTransacao, string pdv, string valorTotal)
    {
        return E1BridgeW.IniciaVenda(idTransacao, pdv, valorTotal);
    }

    public partial string IniciaVendaDebito(int idTransacao, string pdv, string valorTotal)
    {
        return E1BridgeW.IniciaVendaDebito(idTransacao, pdv, valorTotal);
    }

    public partial string IniciaVendaCredito(int idTransacao, string pdv, string valorTotal, int tipoFinanciamento, int numParcelas)
    {
        return E1BridgeW.IniciaVendaCredito(idTransacao, pdv, valorTotal, tipoFinanciamento, numParcelas);
    }

    public partial string IniciaCancelamentoVenda(int idTransacao, string pdv, string valorTotal, string dataHora, string nsu)
    {
        return E1BridgeW.IniciaCancelamentoVenda(idTransacao, pdv, valorTotal, dataHora, nsu);
    }

    public partial string IniciaOperacaoAdministrativa(int idTransacao, string pvd, int operacao)
    {
        return E1BridgeW.IniciaOperacaoAdministrativa(idTransacao, pvd, operacao);
    }

    public partial string ImprimirCupomNfce(string xml, int indexcsc, string csc)
    {
        return E1BridgeW.ImprimirCupomNfce(xml, indexcsc, csc);
    }

    public partial string ImprimirCupomSat(string xml)
    {
        return E1BridgeW.ImprimirCupomSat(xml);
    }

    public partial string ImprimirCupomSatCancelamento(string xml, string assQRCode)
    {
        return E1BridgeW.ImprimirCupomSatCancelamento(xml, assQRCode);
    }

    public partial string SetSenha(string senha, bool habilitada)
    {
        return E1BridgeW.SetSenha(senha, habilitada);
    }

    public partial string ConsultarStatus()
    {
        return E1BridgeW.ConsultarStatus();
    }

    public partial string GetTimeout()
    {
        //return E1BridgeW.Timeout;
        return "NÃO IMPLEMENTADO";
    }

    public partial string ConsultarUltimaTransacao(string pdv)
    {
        return E1BridgeW.ConsultarUltimaTransacao(pdv);
    }

    public partial string SetSenhaServer(string senha, bool habilitada)
    {
        return E1BridgeW.SetSenhaServer(senha, habilitada);
    }

    public partial string SetTimeout(int timeout)
    {
        return E1BridgeW.SetTimeout(timeout);
    }

    public partial string GetServer()
    {
        // return E1BridgeW.Server;
        return "NÃO IMPLEMENTADO";
    }

    public partial string SetServer(string ipTerminal, int portaTransacao, int portaStatus)
    {
        //var x =  E1BridgeW.SetServer(ipTerminal, portaTransacao, portaStatus);
        return E1BridgeW.SetServer(ipTerminal, portaTransacao, portaStatus);
    }
}

