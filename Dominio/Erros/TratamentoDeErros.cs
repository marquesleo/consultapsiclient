using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Erros.Login
{
    public class ErrorsLogin
    {

        private List<string> _Password;
        public List<string> Password
        {
            get
            {
                if (_Password == null)
                    _Password = new List<string>();
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }

        private List<string> _Username;
        public List<string> Username
        {
            get

            {
                if (_Username == null)
                    _Username = new List<string>();
                return _Username;
            }
            set
            {
                _Username = value;
            }
        }

    }
    public class ErrorsPsicologo
        {
            private List<string> _Nome;
            public List<string> Nome
            {
                get
                {
                    if (_Nome == null)
                        _Nome = new List<string>();
                    return _Nome;
                }
                set
                {
                    _Nome = value;
                }
            }

            private List<string> _Celular;
            public List<string> Celular
            {
                get
                {
                    if (_Celular == null)
                        _Celular = new List<string>();
                    return _Celular;
                }
                set
                {
                    _Celular = value;
                }
            }

            private List<string> _Telefone;
            public List<string> Telefone
            {
                get
                {
                    if (_Telefone == null)
                        _Telefone = new List<string>();
                    return _Telefone;
                }
                set
                {
                    _Telefone = value;
                }
            }
        }
    public class ErrorsPaciente
    {
        private List<string> _Nome;
        public List<string> Nome
        {
            get
            {
                if (_Nome == null)
                    _Nome = new List<string>();
                return _Nome;
            }
            set
            {
                _Nome = value;
            }
        }

        private List<string> _Celular;
        public List<string> Celular
        {
            get
            {
                if (_Celular == null)
                    _Celular = new List<string>();
                return _Celular;
            }
            set
            {
                _Celular = value;
            }
        }

        private List<string> _Telefone;
        public List<string> Telefone
        {
            get
            {
                if (_Telefone == null)
                    _Telefone = new List<string>();
                return _Telefone;
            }
            set
            {
                _Telefone = value;
            }
        }
    }
    public class TratamentoDeErrosPsicologo : TratamentoDeErrosBase
        {
            public ErrorsPsicologo errors { get; set; }
        }
    public class TratamentoDeErrosPaciente : TratamentoDeErrosBase
    {
        public ErrorsPaciente errors { get; set; }
    }
    public class TratamentoDeErrosLogin : TratamentoDeErrosBase
        {
            public ErrorsLogin errors { get; set; }
        }



  }

