    namespace PROEVENTOS.API.Models
{
    public class Evento
    {
        public long EventoId { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdePessoas { get; set; }
        public string Lote { get; set; }
        public string ImgURL { get; set; }
    }
}
