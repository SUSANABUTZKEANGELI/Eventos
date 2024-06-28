namespace Eventos.Entities
{
    internal class Participante
    {
        public int CodigoParticipante { get; set; }
        public string NomeParticipante { get; set; }
        public TipoParticipante TipoParticipante { get; set; }
        public Agenda Agenda { get; set; }

        public void Inscricao(DateTime horarioAtividade, string descricaoAtividade, double duracaoAtividade)
        {
            Agenda = new Agenda()
            {
                 CodigoAgenda = new Random().Next(),
                 HorarioAtividade = horarioAtividade,
                 StatusAgenda = StatusAgenda.InscricaoRealizada,
                 Atividade = new Atividade() 
                 { 
                      Avaliacao = null,
                      DescricaoAtividade = descricaoAtividade,
                      DuracaoAtividade = duracaoAtividade,
                      StatusAtividade = Status.AbertoInscricao
                 },
            };
        }
    }
}
