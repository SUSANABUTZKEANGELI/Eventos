namespace Eventos.Entities
{
    public class Palestrante : Participante
    {
        private Participante palestrante;

        public Palestrante(int codigoParticipante, string nomeParticipante) : base(codigoParticipante, nomeParticipante) { }

        public override void Participar(Atividade atividade)
        {
            AgendaPessoal.Add(atividade);
            Console.WriteLine($"Palestrante {NomeParticipante} participando da atividade {atividade.DescricaoAtividade}.");
        }
    }
}
