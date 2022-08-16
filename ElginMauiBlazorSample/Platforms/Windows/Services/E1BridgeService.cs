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
        throw new NotImplementedException();
    }

    public partial string IniciaVendaDebito(int idTransacao, string pdv, string valorTotal)
    {
        throw new NotImplementedException();
    }

    public partial string IniciaVendaCredito(int idTransacao, string pdv, string valorTotal, int tipoFinanciamento, int numParcelas)
    {
        throw new NotImplementedException();
    }

    public partial string IniciaCancelamentoVenda(int idTransacao, string pdv, string valorTotal, string dataHora, string nsu)
    {
        throw new NotImplementedException();
    }

    public partial string IniciaOperacaoAdministrativa(int idTransacao, string pvd, int operacao)
    {
        throw new NotImplementedException();
    }

    public partial string ImprimirCupomNfce(string xml, int indexcsc, string csc)
    {
        throw new NotImplementedException();
    }

    public partial string ImprimirCupomSat(string xml)
    {
        throw new NotImplementedException();
    }

    public partial string ImprimirCupomSatCancelamento(string xml, string assQRCode)
    {
        throw new NotImplementedException();
    }

    public partial string SetSenha(string senha, bool habilitada)
    {
        throw new NotImplementedException();
    }

    public partial string ConsultarStatus()
    {
        throw new NotImplementedException();
    }

    public partial string GetTimeout()
    {
        throw new NotImplementedException();
    }

    public partial string ConsultarUltimaTransacao(string pdv)
    {
        throw new NotImplementedException();
    }

    public partial string SetSenhaServer(string senha, bool habilitada)
    {
        throw new NotImplementedException();
    }

    public partial string SetTimeout(int timeout)
    {
        throw new NotImplementedException();
    }

    public partial string GetServer()
    {
        throw new NotImplementedException();
    }

    public partial string SetServer(string ipTerminal, int portaTransacao, int portaStatus)
    {
        throw new NotImplementedException();
    }
}

