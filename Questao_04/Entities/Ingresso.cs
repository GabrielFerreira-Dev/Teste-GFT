namespace Questao_04.Entities
{
    abstract class Ingresso
    {
        public double ValorEmReais = 30;

        public virtual string imprimeValor()
        {
            return "Ingresso";
        }
    }
}