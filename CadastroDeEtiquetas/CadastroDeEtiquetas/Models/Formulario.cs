using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroDeEtiquetas.Models
{
    [Table("Formularios")]
    public class Formulario
    {
        public int FormularioId { get; set; }
        public string Descricao { get; set; }
        public int Colunas { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public int Fixacao { get; set; }
        public double GapLinha { get; set; }
        public double GapColuna { get; set; }
        public int Rfid { get; set; }
        public string Imagem { get; set; }
        public List<Etiqueta> Etiquetas { get; set; }

    }
}
