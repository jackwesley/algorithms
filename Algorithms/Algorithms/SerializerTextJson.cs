using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Algorithms
{
    public class SerializerTextJson
    {

        public void Serializar()
        {
            var muitosVM = new MuitosViewModel { codigo = "123", mensagem = "sucesso" };
            var testViewModel = new TesteViewModel { primeiro_nome = "Jack", segundo_nome = "Wesley" };
            var testViewModel1 = new TesteViewModel { primeiro_nome = "Jose", segundo_nome = "Justino" };
            var testViewModel2 = new TesteViewModel { primeiro_nome = "Joao", segundo_nome = "Costa" };

            muitosVM.lista_testevm.Add(testViewModel);
            muitosVM.lista_testevm.Add(testViewModel1);
            muitosVM.lista_testevm.Add(testViewModel2);

            var serializadoMuitosVM = JsonSerializer.Serialize(muitosVM);
            var jsonProperties = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };


            var deserializado = JsonSerializer.Deserialize<Muitos>(serializadoMuitosVM, jsonProperties);
        }
    }


    public class MuitosViewModel
    {
        public string codigo { get; set; }
        public string mensagem { get; set; }

        public List<TesteViewModel> lista_testevm { get; set; }

        public MuitosViewModel()
        {
            lista_testevm = new List<TesteViewModel>();
        }
    }

    public class TesteViewModel
    {
        public string primeiro_nome { get; set; }

        public string segundo_nome { get; set; }
    }


    public class Muitos
    {
        public string Codigo { get; set; }
        public string Mensagem { get; set; }

        [JsonPropertyName("lista_testevm")]
        public List<Teste> ListaTestevm { get; set; }
    }


    public class Teste
    {
        public string PrimeiroNome { get; set; }

        public string SegundoNome { get; set; }
    }

}
