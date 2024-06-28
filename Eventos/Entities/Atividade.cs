namespace Eventos.Entities
{
    public class Atividade
    {
        public int CodigoAtividade { get; set; }
        public string DescricaoAtividade { get; set; }
        public DateTime HorarioAtividade { get; set; }
        public double DuracaoAtividade { get; set;}
        public Status StatusAtividade { get; set; }
        public List<Avaliacao>? Avaliacao { get; set; }

        public static Atividade GerarAtividade(int codigoAtividade, string descricaoAtividade, double duracaoAtividade, Status statusAtividade)
        {
            return new Atividade()
            {
                CodigoAtividade = codigoAtividade,
                DescricaoAtividade = descricaoAtividade,
                DuracaoAtividade = duracaoAtividade,
                HorarioAtividade = DateTime.Now,
                StatusAtividade = statusAtividade,
                Avaliacao = new List<Avaliacao>()
            };
        }
    }
}
