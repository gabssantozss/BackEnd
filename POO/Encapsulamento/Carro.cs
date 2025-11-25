
namespace Encapsulamento
{
    public class Carros
    {
        private string modelo = "";
         private string marca = "";
         private int VelocidadeAtual;

        public void DefinirMarca(string M)
        {
            marca = M;
        }

        public string ObterMarca()
        {
            return marca;
        }

        public void DefinirModelo(string Mo)
        {
            modelo = Mo;
        }

        public string ObterModelo()
        {
            return modelo;
        }

        public void Acelerar(int quantidade)
        {
            VelocidadeAtual += quantidade;
        }

        public int ObterVelocidade()
        {
            return VelocidadeAtual;
        }


    }
}