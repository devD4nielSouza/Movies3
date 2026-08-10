using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Movies.Desktop.Helpers
{
    public static class ApiEndPointResolver
    {
        
       // Endereço onde a API está rodando
            private const string ApiUrl = "http://localhost:5254";
            // Retorna o endereço da API
            public static string Resolve()
            { return ApiUrl; }
      
    }
}
