namespace Eventos.Entities
{
    internal class Atividade
    {
        public int CodigoAtividade { get; set; }
        public string DescricaoAtividade { get; set; }
        public double DuracaoAtividade { get; set;}
        public DateTime HorarioAtividade { get; set; }
        public Status StatusAtividade { get; set; }
        public List<Avaliacao>? Avaliacao { get; set; }
        public List<Participante>? Participantes { get; set; } = new();


        public void ReceberInscricao(int codigo, string nome, TipoParticipante tipo)
        {
            var participante = new Participante
            {
                CodigoParticipante = codigo,
                NomeParticipante = nome,
                TipoParticipante = tipo
            };

            Participantes!.Add(participante);
        }
    }
}
