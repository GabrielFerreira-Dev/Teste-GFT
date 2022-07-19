namespace Questao_02.Entities
{
    abstract class Raça
    {
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public int Constituicao { get; set; }
        public int Inteligencia { get; set; }
        public int Sabedoria { get; set; }
        public int Carisma { get; set; }
        public Raça()
        {
            
        }
        public Raça(int constituicao, int forca, int sabedoria)
        {
            Constituicao = constituicao;
            Forca = forca;
            Sabedoria = sabedoria;
        }

        public Raça(int constituicao, int forca, int sabedoria, int inteligencia, int carisma, int destreza)
        {
            Constituicao = constituicao; 
            Forca = forca;
            Sabedoria = sabedoria;
            Inteligencia = inteligencia;
            Carisma = carisma;
            Destreza = destreza;
        }

        public virtual string ToString()
        {
            return "";
        }
    }
}