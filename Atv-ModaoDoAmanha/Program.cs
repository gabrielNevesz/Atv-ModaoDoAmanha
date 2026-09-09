using Atv_ModaoDoAmanha;

Console.WriteLine("---Sistema de gestão de música---");
Console.WriteLine();

AlunoMusica aluno = new AlunoMusica();


Console.WriteLine("Seu nome: ");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Sua mensalidade base: ");
aluno.MensalidadeBase = double.Parse(Console.ReadLine());

Console.WriteLine("Suas horas de pratica semanal: ");
aluno.HorasPraticaSemanal = double.Parse(Console.ReadLine());

Console.WriteLine("Digite seu nível de habilidade: ");
aluno.NivelHabilidade = int.Parse(Console.ReadLine());

Console.WriteLine("\n*** Desempenho do aluno ***");
Console.WriteLine($"Nome: {aluno.Nome}");
Console.WriteLine($"Desconto de horas: R$ {aluno.DescontoHoras()}");
Console.WriteLine($"Seu nível técnico é: {aluno.NivelHabilidade}");
Console.WriteLine($"Para você ir para o próximo nível: {aluno.HorasFaltantesProximoNivel()} horas");
Console.WriteLine($"Seu novo nível é: {aluno.ProximoNivel()}");
Console.WriteLine($"Sua mensalidade final: R$ {aluno.MensalidadeFinal()}");
Console.WriteLine($"Vai receber a bolsa orquestral?: {aluno.BolsaOrquestral()}");
