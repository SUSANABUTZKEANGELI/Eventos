namespace Eventos.Entities
{
    internal class Evento
    {
        public string NomeEvento { get; set; }    
        public DateTime DataEvento { get; set; }
        public string LocalEvento { get; set; }
        public Status StatusEvento { get; set; }
        public int CapacidadeMaxima { get; set; }
        public List<Atividade> Atividades { get; set; }
        public List<Participante> Participantes { get; set; }

        public void Iniciar()
        {
            StatusEvento = Status.AbertoInscricao;
        }

        public void Pausar()
        {
            StatusEvento = Status.Pausado;
        }

        public void Concluir()
        {
            StatusEvento = Status.Finalizado;
        }

        public void Cancelar()
        {
            StatusEvento = Status.Cancelado;
        }
    }
}
