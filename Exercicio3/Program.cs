// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

double nota1;
double nota2;
double nota3;
double notaFinal;
Console.WriteLine("Olá, Aluno. Vamos calcular sua média?");
Console.WriteLine("Qual é o seu nome completo?");
string nomeCompleto = Console.ReadLine();

Console.WriteLine("Insira sua primeira nota:");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Certo, agora insira sua segunda nota:");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Perfeito. Agora insira sua terceira nota:");
nota3 = double.Parse(Console.ReadLine());

notaFinal = (nota1 + nota2 + nota3) /3;
Console.WriteLine("BOLETIM do " + nomeCompleto);
Console.WriteLine("Nota 1: " + nota1);
Console.WriteLine("Nota 2: " + nota2);
Console.WriteLine("Nota 3: " + nota3);
Console.WriteLine("Sua média final é " + notaFinal);
if (notaFinal >= 6){
    Console.WriteLine("Aluno Aprovado com média igual ou superior a 6");
}
else if (notaFinal >= 5 & notaFinal < 6 ) {
Console.WriteLine("Aluno em Recuperação com média: " + notaFinal);
}
if (notaFinal < 5){
Console.WriteLine("Aluno Reprovado com média " + notaFinal);
}
 
