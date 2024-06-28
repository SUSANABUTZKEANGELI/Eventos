using Eventos;
using Eventos.Entities;

var evento = new Evento
{
    CapacidadeMaxima = 200,
    DataEvento = new DateTime(2024, 07, 04),
    LocalEvento = "Rua XV de Novembro, 123",
    NomeEvento = "Evento 1",
    StatusEvento = Status.FechadoInscricao,
    Atividades = new List<Atividade> {
        new Atividade {
            CodigoAtividade = 1,
            DescricaoAtividade = "Atividade 1",
            DuracaoAtividade = 1.5,
            HorarioAtividade = new DateTime(2024, 07, 04, 10, 0, 0),
            StatusAtividade = Status.AbertoInscricao
        },
        new Atividade
        {
            CodigoAtividade = 2,
            DescricaoAtividade = "Atividade 2",
            DuracaoAtividade = 3.5,
            HorarioAtividade = new DateTime(2024, 07, 04, 13, 0, 0),
            StatusAtividade = Status.AbertoInscricao
        }
    }
};

var participante1 = new Participante
{
    CodigoParticipante = 1,
    NomeParticipante = "Participante 1",
    TipoParticipante = TipoParticipante.Espectador
};

var participante2 = new Participante
{
    CodigoParticipante = 2,
    NomeParticipante = "Participante 2",
    TipoParticipante = TipoParticipante.Espectador
};

evento.Iniciar();
var atividade1 = evento.Atividades.SingleOrDefault(x => x.CodigoAtividade == 1)!;

participante1.Inscricao(
    atividade1.HorarioAtividade,
    atividade1.DescricaoAtividade,
    atividade1.DuracaoAtividade
    );
atividade1.ReceberInscricao(participante1.CodigoParticipante, participante1.NomeParticipante, participante1.TipoParticipante);

var atividade2 = evento.Atividades.SingleOrDefault(x => x.CodigoAtividade == 2)!;

participante2.Inscricao(
    atividade2.HorarioAtividade,
    atividade2.DescricaoAtividade,
    atividade2.DuracaoAtividade
    );

atividade2.ReceberInscricao(participante2.CodigoParticipante, participante2.NomeParticipante, participante2.TipoParticipante);

evento.StatusEvento = Status.FechadoInscricao;

Console.WriteLine($"=====EVENTO: {evento.NomeEvento}========");
Console.WriteLine($"Data: {evento.DataEvento}");
Console.WriteLine($"Capacidade máxima: {evento.CapacidadeMaxima}");
Console.WriteLine($"Local: {evento.LocalEvento}");
Console.WriteLine($"Status: {evento.StatusEvento}");
Console.WriteLine("");

Console.WriteLine("======= ATIVIDADES DO EVENTO ========");
Console.WriteLine($"Atividade: {atividade1.DescricaoAtividade}");
Console.WriteLine($"Duração: {atividade1.DuracaoAtividade} horas");
Console.WriteLine($"Horário: {atividade1.HorarioAtividade}");
Console.WriteLine($"Quantidade de Inscritos: {atividade1.Participantes?.Count()}");
Console.WriteLine("");

Console.WriteLine("-------------------------------------");
Console.WriteLine($"Atividade: {atividade2.DescricaoAtividade}");
Console.WriteLine($"Duração: {atividade2.DuracaoAtividade} horas");
Console.WriteLine($"Horário: {atividade2.HorarioAtividade}");
Console.WriteLine($"Quantidade de Inscritos: {atividade1.Participantes?.Count()}");