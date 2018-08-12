using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoMVC_Introducao.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }
        [StringLength(50,MinimumLength = 5, ErrorMessage ="Inserir dentro do limite: minimo de 5 e maximo de 50")]
        public string Observações { get; set; }
        [Range(18,70, ErrorMessage ="A Idade precisa estar entre 18 a 70.")]
        [Required(ErrorMessage = "A idade é obrigatório")]
        public int Idade { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage ="Digite um e-mail valido.")]
        [Required(ErrorMessage ="E-mail obrigatório.")]
        public string Email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage ="Somente letras e de 5 a 15 caracteres.")]
        [Required(ErrorMessage = "O login é obrigatório")]
        public string Login { get; set; }
        [Required(ErrorMessage = "O senha é obrigatório")]
        public string Senha { get; set; }
        [Compare("Senha", ErrorMessage = "As senhas não são iguais.")]
        public string ConfirmaçãoSenha { get; set; }

    }
}