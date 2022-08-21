/* *** *** *** *** *** */
/*  Platform WINDOWS   */
/* *** *** *** *** *** */

namespace ElginMauiBlazorSample.Services;
public partial class PrinterService
{
    private partial void DoConstructor() { throw new NotImplementedException(); }

    public partial int PrinterInternalImpStart() { throw new NotImplementedException(); }
    public partial int PrinterExternalImpStartByIP(string model, string ip, int port) { throw new NotImplementedException(); }
    public partial int PrinterExternalImpStartByUSB(string model) { throw new NotImplementedException(); }
    public partial void PrinterStop() { throw new NotImplementedException(); }
    public partial int AvancaLinhas(int linesNumber) { throw new NotImplementedException(); }
    public partial void JumpLine() { throw new NotImplementedException(); }
    public partial int CutPaper(int cut) { throw new NotImplementedException(); }
    public partial int ImprimeBarCode(Dictionary<string, string> dictionary) { throw new NotImplementedException(); }
    public partial int ImprimeQR_CODE(Dictionary<string, string> dictionary) { throw new NotImplementedException(); }
    public partial int ImprimeImagem(Stream bitmap) { throw new NotImplementedException(); }
    public partial int ImprimeImagemPadrao() { throw new NotImplementedException(); }
    public partial int ImprimeXMLNFCe(Dictionary<string, object> parametros) { throw new NotImplementedException(); }
    public partial int ImprimeXMLSAT(Dictionary<string, object> parametros) { throw new NotImplementedException(); }
    public partial int StatusGaveta() { throw new NotImplementedException(); }
    public partial int AbrirGaveta() { throw new NotImplementedException(); }
    public partial int StatusSensorPapel() { throw new NotImplementedException(); }
    public partial int ImprimeCupomTEF(Dictionary<string, string> dictionary) { throw new NotImplementedException(); }
    public partial int ImprimeTexto(Dictionary<string, string> dictionary) { throw new NotImplementedException(); }

}
