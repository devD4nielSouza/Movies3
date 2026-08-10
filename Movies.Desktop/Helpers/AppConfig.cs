using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Desktop.Helpers
{
    public class AppConfig
    {
        // URL da API
        public static string ApiBaseUrl => ApiEndPointResolver.Resolve();
        // Nome do aplicativo
        public static string AppName => "Movies Desktop";
        // Versão do aplicativo
        public static string Version => "1.0.0"; 
        // Tempo limite das requisições em segundos
        public static int Timeout => 30;
    }
}
