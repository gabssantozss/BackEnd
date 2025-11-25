namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Contratante = "";

        public string PrestadorDeServico = "";

        public string TextoClausulas = "";

        public Contrato (string contratante, string contratada, string txtClausulas)
    {
        Contratante = contratante;
        PrestadorDeServico = contratada;
        TextoClausulas = txtClausulas;
    }
        public void Imprimir()
        {
            System.Console.WriteLine($@"
            Contratante : {Contratante}
            Contratada: {PrestadorDeServico}
            Clausulas do contrato: {TextoClausulas}");
        }
    }
}