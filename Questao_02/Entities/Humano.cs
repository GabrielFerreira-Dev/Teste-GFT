namespace Questao_02.Entities
{
    class Humano : Raça
    {
        int atrb = 1;
        public Humano(int forca, int destreza, int constituicao, int inteligencia, int sabedoria, int carisma)
             : base(forca,destreza,constituicao,inteligencia,sabedoria,carisma)
            {

            }
        public override string ToString()
        {
            return "Todos os atributos +" + atrb.ToString();
        }
    }
}