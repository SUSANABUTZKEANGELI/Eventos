using Eventos.Entities;

var eventoConferencia = new Conferencia("Conferência", DateTime.Now, "Blumenau", 100);

var participante1 = new Palestrante(1, "Palestrante 1");
var participante2 = new Espectador(1, "Espectador 1");
var participante3 = new Espectador(2, "Espectador 2");
var participante4 = new Espectador(3, "Espectador 3");

eventoConferencia.Iniciar();

var atividade1 = Atividade.GerarAtividade(1, "Atividade 1", 1.5, Eventos.Status.AbertoInscricao);
var atividade2 = Atividade.GerarAtividade(2, "Atividade 2", 3, Eventos.Status.AbertoInscricao);

eventoConferencia.Atividades.Add(atividade1);
eventoConferencia.Atividades.Add(atividade2);

participante1.Participar(atividade1);
participante2.Participar(atividade1);
participante3.Participar(atividade1);
participante4.Participar(atividade1);

var avaliacao = new Avaliacao() { Nota = 10, Comentario = "GREAT"};
atividade1.Avaliacao.Add(avaliacao);

eventoConferencia.Concluir();

Console.WriteLine($"=====EVENTO: {eventoConferencia.NomeEvento}========");
Console.WriteLine($"Data: {eventoConferencia.DataEvento}");
Console.WriteLine($"Capacidade máxima: {eventoConferencia.CapacidadeMaxima}");
Console.WriteLine($"Local: {eventoConferencia.LocalEvento}");
Console.WriteLine($"Status: {eventoConferencia.StatusEvento}");
Console.WriteLine("");

Console.WriteLine("======= ATIVIDADES DO EVENTO ========");
Console.WriteLine($"Atividade: {atividade1.DescricaoAtividade}");
Console.WriteLine($"Duração: {atividade1.DuracaoAtividade} horas");
Console.WriteLine($"Horário: {atividade1.HorarioAtividade}");
Console.WriteLine($"Avaliação: {atividade1.Avaliacao.FirstOrDefault().Nota} - Comentário: {atividade1.Avaliacao.FirstOrDefault().Comentario}");
Console.WriteLine("");

Console.WriteLine("======= AGENDA DO PALESTRANTE ========");
Console.WriteLine($"Nome: {participante1.NomeParticipante}");
Console.WriteLine($"Atividade: {participante1.AgendaPessoal.FirstOrDefault().DescricaoAtividade}");
Console.WriteLine($"Duração: {participante1.AgendaPessoal.FirstOrDefault().DuracaoAtividade} horas");
Console.WriteLine($"Horário: {participante1.AgendaPessoal.FirstOrDefault().HorarioAtividade}");
Console.WriteLine("");

Console.WriteLine("======= AGENDA DO ESPECTADOR ========");
Console.WriteLine($"Nome: {participante2.NomeParticipante}");
Console.WriteLine($"Atividade: {participante2.AgendaPessoal.FirstOrDefault().DescricaoAtividade}");
Console.WriteLine($"Duração: {participante2.AgendaPessoal.FirstOrDefault().DuracaoAtividade} horas");
Console.WriteLine($"Horário: {participante2.AgendaPessoal.FirstOrDefault().HorarioAtividade}");
Console.WriteLine("");
