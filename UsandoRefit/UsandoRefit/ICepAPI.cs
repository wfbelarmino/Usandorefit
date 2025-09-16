using Refit;


namespace UsandoRefit
{
    public interface ICepAPI
    {
        [Get("/ws/{cep}/json/")]
       
        Task<CepResponse> ConsultaCep(string cep);

    }
}
