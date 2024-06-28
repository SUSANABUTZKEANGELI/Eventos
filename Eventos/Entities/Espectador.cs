namespace Eventos.Entities
{
    public class Espectador : Participante
    {
        private Participante espectador;

        public Espectador(int codigoParticipante, string nomeParticipante) : base(codigoParticipante, nomeParticipante) { }

        public override void Participar(Atividade atividade)
        {
            AgendaPessoal.Add(atividade);
            Console.WriteLine($"Espectador {NomeParticipante} participando da atividade {atividade.DescricaoAtividade}.");
        }
    }
}
