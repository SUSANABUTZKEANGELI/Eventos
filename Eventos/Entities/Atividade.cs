namespace Eventos.Entities
{
    internal class Atividade
    {
        public string DescricaoAtividade { get; set; }
        public double DuracaoAtividade { get; set;}
        public Status StatusAtividade { get; set; }
        public List<int>? Avaliacao { get; set; }
    }
}
