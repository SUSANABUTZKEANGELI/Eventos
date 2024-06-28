namespace Eventos.Entities
{
    public abstract class Participante
    {
        public int CodigoParticipante { get; set; }
        public string NomeParticipante { get; set; }
        public List<Atividade> AgendaPessoal { get; set; }

        public Participante(int codigoParticipante, string nomeParticipante)
        {
            CodigoParticipante = codigoParticipante;
            NomeParticipante = nomeParticipante;
            AgendaPessoal = new List<Atividade>();
        }

        public abstract void Participar(Atividade atividade);
    }
}
