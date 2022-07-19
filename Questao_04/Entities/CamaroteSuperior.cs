namespace Questao_04.Entities
{
    class CamaroteSuperior : VIP
    {
        public double adicionalCamarote = 20;
        public string local = "Camarote no segundo andar";

        public double valorCamarote()
        {
            return IngressoVip() + adicionalCamarote;
        }

        public string textoCamarote()
        {
            return "Valor camarote: "
                + valorCamarote().ToString()
                + " no local: "
                + local.ToString();
        }
    }
}