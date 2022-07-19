namespace Questao_04.Entities
{
    class VIP : Ingresso
    {
        public double valorVip { get; set; }
        public double IngressoVip()
        {
            return ValorEmReais + valorVip;
        }
        public override string imprimeValor()
        {
            return IngressoVip().ToString();
        }
    }
}