namespace Questao_04.Entities
{
    class CamaroteInferior : VIP
    {
        public string local = "Rua Y 3º andar";

        public string imprimirLocal()
        {
            return "local: "
            + local.ToString();
        }
    }
}