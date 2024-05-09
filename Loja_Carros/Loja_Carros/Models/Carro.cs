namespace Loja_Carros.Models
{
    public class Carro
    {

        //Criando abstração(dados do cliente para o banco.) Imagina que você está fazendo um retrato
        //E fazendo emcapsulamento do objeto cliente, que é a proteção dos dados.
        public int Id { get; set; }
        //O id é uma abstração do cliente

        public string Marca { get; set; }
        public string Ano { get; set; }
        public string Modelo { get; set; }
        public string Fabricante { get; set; }

        private List<Carro>? listaCarro { get; set; }

        public void NovoCarro()
        {
            //tranamento de exeções (try) tente
            try
            {
                listaCarro = new List<Carro>()
            {
                new Carro(){ Id = 1,Marca= "Jeep", Ano = "2019",Modelo="Compass", Fabricante = "Fiat" },
                new Carro(){ Id = 2,Marca= "Koeniggseg",Ano ="2019" ,Modelo="Jesko", Fabricante = "Koeniggseg" },
                new Carro(){ Id = 3,Marca= "Lamborghini",Ano = "2006", Modelo="Gallardo", Fabricante = "Lamborgini"},
                new Carro(){ Id = 4,Marca= "Caddilac",Ano = "2012", Modelo="CTS-V", Fabricante ="General Motors"},
                new Carro(){ Id = 5,Marca= "Nissan",Ano = "2010", Modelo="Sentra", Fabricante = "Nissan"}
            };
            }
            //catch (caso de algo de errado apresente uma mensagem ao invés de crachar o sistema
            catch (System.Exception ex)
            {
                //mensgem de erro caso aconteça
                throw new Exception(ex.Message);
            }
        }
        public List<Carro> ListarCarro()
        {
            try
            {
                return listaCarro;
            }
            catch (System.Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
