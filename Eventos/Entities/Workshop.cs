namespace Eventos.Entities
{
    public class Workshop : Evento
    {
        public Workshop(string nome, DateTime data, string local, int capacidadeMaxima)
            : base(nome, data, local, capacidadeMaxima) { }

        public override void Iniciar() => Console.WriteLine($"Workshop {NomeEvento} iniciado.");
        public override void Pausar() => Console.WriteLine($"Workshop {NomeEvento} pausado.");
        public override void Concluir() => Console.WriteLine($"Workshop {NomeEvento} concluído.");
        public override void Cancelar() => Console.WriteLine($"Workshop {NomeEvento} cancelado.");
    }
}
