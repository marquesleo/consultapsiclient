using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio.ViewModel
{
    public class ConsultaViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public DateTime Horario { get; set; }
       
        [MaxLength(50, ErrorMessage = "O Campo {0} precisa ter no máximo {1}")]
        public string proposito { get; set; }
        public bool UmaHora { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [MaxLength(500, ErrorMessage = "O Campo {0} precisa ter no máximo {1}")]
        public string Obervacao { get; set; }
        public string Status { get; set; }
        public enum enuStatus
        {
            Ocorrido,
            NaoOcorrido,
            Cancelado
        }
        public int Satisfacao { get; set; }
        [MaxLength(500, ErrorMessage = "O Campo {0} precisa ter no máximo {1}")]
        public string Comentario { get; set; }
        public DateTime HorarioSatisfacao { get; set; }
        public bool JaViuSatisfacao { get; set; }
        public Guid Psicologa_Id { get; set; }
        public Guid Paciente_Id { get; set; }
        public Guid Empresa_Id { get; set; }
                
    }
}
