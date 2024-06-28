namespace Eventos.Entities
{
    public class Conferencia : Evento
    {
        public Conferencia(string nome, DateTime data, string local, int capacidadeMaxima)
            : base(nome, data, local, capacidadeMaxima) { }

        public override void Iniciar() => Console.WriteLine($"Conferência {NomeEvento} iniciada.");
        public override void Pausar() => Console.WriteLine($"Conferência {NomeEvento} pausada.");
        public override void Concluir() => Console.WriteLine($"Conferência {NomeEvento} concluída.");
        public override void Cancelar() => Console.WriteLine($"Conferência {NomeEvento} cancelada.");
    }
}
