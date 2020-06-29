using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace CadastroDeEtiquetas.Models
{
    [Table("Etiquetas")]
    public class Etiqueta
    {
        public int Id { get; set; }
        public virtual Formulario Formulario { get; set; }
        [Display(Name ="Numero de Formulario")]
        public int FormularioId  { get; set; }
        public int Linguagem { get; set; }
        public int Tipo { get; set; }
        public string Descricao { get; set; }
        [Display(Name="Largura de Impressao")]
        public int LarguraImpressao { get; set; }
        public int Densidade { get; set; }
        public int Velocidade { get; set; }
        public string Imagem { get; set; }
        [Display(Name = "numero de Etiqueta")]
        public string EstruturaEtiqueta { get; set; }


    }
}
