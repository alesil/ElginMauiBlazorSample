using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElginMauiBlazorSample.Services;
public partial class E1BridgeService
{
    public E1BridgeService()
    {
        DoConstructor();
    }

    private partial void DoConstructor();

    public partial string IniciaVenda(int idTransacao, string pdv, string valorTotal);
    public partial string IniciaVendaDebito(int idTransacao, string pdv, string valorTotal);


    public partial string IniciaVendaCredito(int idTransacao, string pdv, string valorTotal, int tipoFinanciamento, int numParcelas);
    public partial string IniciaCancelamentoVenda(int idTransacao, string pdv, string valorTotal, string dataHora, string nsu);
    public partial string IniciaOperacaoAdministrativa(int idTransacao, string pvd, int operacao);
    public partial string ImprimirCupomNfce(string xml, int indexcsc, string csc);
    public partial string ImprimirCupomSat(string xml);
    public partial string ImprimirCupomSatCancelamento(string xml, string assQRCode);
    public partial string SetSenha(string senha, bool habilitada);
    public partial string ConsultarStatus();
    public partial string GetTimeout();
    public partial string ConsultarUltimaTransacao(string pdv);
    public partial string SetSenhaServer(string senha, bool habilitada);
    public partial string SetTimeout(int timeout);
    public partial string GetServer();
    public partial string SetServer(string ipTerminal, int portaTransacao, int portaStatus);

}
