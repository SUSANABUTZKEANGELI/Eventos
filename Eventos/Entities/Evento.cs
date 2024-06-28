namespace Eventos.Entities
{
    public abstract class Evento
    {
        public string NomeEvento { get; set; }    
        public DateTime DataEvento { get; set; }
        public string LocalEvento { get; set; }
        public Status StatusEvento { get; set; }
        public int CapacidadeMaxima { get; set; }
        public List<Atividade> Atividades { get; set; }
        public List<Participante> Participantes { get; set; }

        public Evento(string nome, DateTime data, string local, int capacidadeMaxima)
        {
            NomeEvento = nome;
            DataEvento = data;
            LocalEvento = local;
            StatusEvento = Status.AbertoInscricao;
            CapacidadeMaxima = capacidadeMaxima;
            Participantes = new List<Participante>();
            Atividades = new List<Atividade>();
        }

        public abstract void Iniciar();
        public abstract void Pausar();
        public abstract void Concluir();
        public abstract void Cancelar();
    }
}
