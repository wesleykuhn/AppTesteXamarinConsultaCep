namespace AppConsultaCep.Library.Models
{
    public class Endereco
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string unidade { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }

        public override string ToString()
        {
            return "CEP: " + this.cep +
                "\nLogradouro: " + this.logradouro +
                "\nComplemento: " + this.complemento +
                "\nBairro: " + this.bairro +
                "\nLocalidade: " + this.localidade +
                "\nUF: " + this.uf +
                "\nUnidade: " + this.unidade +
                "\nIBGE: " + this.ibge +
                "\nGIA: " + this.gia;
        }
    }
}