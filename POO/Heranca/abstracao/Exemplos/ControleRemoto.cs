namespace Exemplos
{
public class ControleRemoto : IControle
    {
        public int NivelVolume = 99;

        public int VolumeMaximo = 100;
        public void Ligar()
        {
            Console.WriteLine($"Ligando a TV");
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando a TV");
        }

        public void Aumentar()
    {

            if (NivelVolume < VolumeMaximo)
            {
   Console.WriteLine($"Nivel atual do volume:{VolumeMaximo}");
            }   

            else {
                Console.WriteLine($"O volume ja atingiu o nivel maximo {NivelVolume}");
            }    
    }

        void IControle.Diminuir(){
            if(NivelVolume == 0) 
            {
                System.Console.WriteLine($"O volume ja esta no maximo {NivelVolume}");
            }else
            {
                NivelVolume--;
                System.Console.WriteLine($"Volume atua : {NivelVolume}");
            }


        }
        
    }
    }