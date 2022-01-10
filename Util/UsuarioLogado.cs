using System;

namespace Util
{

    public static class Usuario
    {
        public static TokenLogado UsuarioLogado { get; set; }
       
    }
    public class User
    {
        public string username { get; set; }
        public object email { get; set; }
        public string id { get; set; }
    }

    public class TokenLogado
    {
        public User user { get; set; }
         public Acesso acesso { get; set; }
        public string token { get; set; }
    }

    public class Acesso
    {
      
        public string id { get; set; }
        public string empresa_Id { get; set; }
        public string usuario_Id { get; set; }
        public string tipo { get; set; }
    }
}
