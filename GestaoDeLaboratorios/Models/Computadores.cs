using System.ComponentModel.DataAnnotations;

namespace GestaodeLaboratorios.Models
{
    public class Computadores
    {
        [Key]
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Processador { get; set; }
        public string PlacaMae { get; set; }
        public int Memoria { get; set; }
        public int HD { get; set; }
        public string NumeroPatrimonio { get; set; }
        public DateTime DataCompra { get; set; }


    }
}