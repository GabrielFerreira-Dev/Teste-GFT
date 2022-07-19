namespace Questao_02.Entities
{
    class Elfo : Raça
    {
        public Elfo()
        {
            
        }
        public Elfo(int destreza, int carisma, int inteligencia) : base(destreza, carisma, inteligencia)
        {
            Destreza = destreza;
            Carisma = carisma;
            Inteligencia = inteligencia;
        }

        public override string ToString()
        {
            return "Destreza: +"
            + Constituicao
            + ", Carisma: +"
            + Forca
            + ", Inteligencia: +"
            + Sabedoria.ToString();
        }

    }
}