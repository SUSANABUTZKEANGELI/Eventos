namespace Eventos.Entities
{
    internal class Agenda
    {
        public int CodigoAgenda { get; set; }
        public DateTime HorarioAtividade { get; set; }
        public Atividade Atividade { get; set; }
        public StatusAgenda StatusAgenda { get; set; }
    }
}
