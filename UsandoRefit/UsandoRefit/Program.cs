// See https://aka.ms/new-console-template for more information
using Refit;
using System.ComponentModel.Design;
using UsandoRefit;

Console.WriteLine("Digite o CEP.....");
var cep = Console.ReadLine();

var service = RestService.For<ICepAPI>("https://viacep.com.br");
var retorno = await service.ConsultaCep(cep);

if(retorno != null)
{
    Console.WriteLine($"Logradouro: {retorno.Logradouro}");
    Console.WriteLine($"Bairro: {retorno.Bairro}");
    Console.WriteLine($"Cidade: {retorno.Localidade}");
    Console.WriteLine($"Estado: {retorno.UF}");
}