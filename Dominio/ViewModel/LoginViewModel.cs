﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio.ViewModel
{
    public class LoginViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(30, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Username { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [MaxLength(200, ErrorMessage = "O Campo {0} precisa ter no máximo {1}")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [MaxLength(10, ErrorMessage = "O Campo {0} precisa ter no máximo {1}")]
        public string Password { get; set; }
        public bool Ativo { get; set; }


        public AcessoViewModel Acesso { get; set; }

    }
}
