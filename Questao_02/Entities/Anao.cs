namespace Questao_02.Entities
{
    class Anao : Raça
    {
        public Anao()
        {
            
        }
        public Anao(int constituicao, int forca, int sabedoria) : base(constituicao, forca, sabedoria)
        {
            Constituicao = constituicao;
            Forca = forca;
            Sabedoria = sabedoria;
        }
        

        public override string ToString()
        {
            return "Constituição: +"
            + Constituicao
            + ", Força: +"
            + Forca
            + ", Sabedoria: +"
            + Sabedoria.ToString();
        }


    }
}