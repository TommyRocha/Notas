// projeto notas

int numeroTarefas = 5;

// notas de cada aluno

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

// soma das notas de cada aluno

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

// média das notas de cada aluno

decimal sophiaAverage = (decimal)sophiaSum / numeroTarefas;
decimal nicolasAverage = (decimal)nicolasSum / numeroTarefas;
decimal zahirahAverage = (decimal)zahirahSum / numeroTarefas;
decimal jeongAverage = (decimal)jeongSum / numeroTarefas;

// resultados
Console.WriteLine("Resultados das somas:");

Console.WriteLine("sophia: " + sophiaSum );
Console.WriteLine("nicolas: " + nicolasSum);
Console.WriteLine("zahirah: " + zahirahSum);
Console.WriteLine("jeong: " + jeongSum);

Console.WriteLine("");

Console.WriteLine($"média Sophia: {sophiaAverage}");
Console.WriteLine($"média Nicolas: {nicolasAverage}");
Console.WriteLine($"média Zahirah: {zahirahAverage}");
Console.WriteLine($"média Jeong: {jeongAverage}");


// notas finais de cada aluno
Console.WriteLine("");
Console.WriteLine("Notas finais:");


// sophia
if (sophiaAverage > 96)
{
    Console.WriteLine("sophia: A+");
}
else if (sophiaAverage == 96 || sophiaAverage >= 93)
{
    Console.WriteLine("sophia: A");
}
else if (sophiaAverage == 90 || sophiaAverage <= 92)
{
    Console.WriteLine("sophia: A-");
}
else if (sophiaAverage == 87 || sophiaAverage <= 89)
{
    Console.WriteLine("sophia: B+");
}
else if (sophiaAverage == 83 || sophiaAverage <= 86)
{
    Console.WriteLine("sophia: B");
}
else
{
    Console.WriteLine("sophia: C");
}


// nicolas

if (nicolasAverage > 96)
{
    Console.WriteLine("nicolas: A+");
}
else if (nicolasAverage == 96 || nicolasAverage >= 93)
{
    Console.WriteLine("nicolas: A");
}
else if (nicolasAverage == 90 || nicolasAverage <= 92)
{
    Console.WriteLine("nicolas: A-");
}
else if (nicolasAverage == 87 || nicolasAverage <= 89)
{
    Console.WriteLine("nicolas: B+");
}
else if (nicolasAverage == 83 || nicolasAverage <= 86)
{
    Console.WriteLine("nicolas: B");
}
else
{
    Console.WriteLine("nicolas: C");
}

// zahirah
if (zahirahAverage > 96)
{
    Console.WriteLine("zahirah: A+");
}
else if (zahirahAverage == 96 || zahirahAverage >= 93)
{
    Console.WriteLine("zahirah: A");
}
else if (zahirahAverage == 90 || zahirahAverage <= 92)
{
    Console.WriteLine("zahirah: A-");
}
else if (zahirahAverage == 87 || zahirahAverage <= 89)
{
    Console.WriteLine("zahirah: B+");
}
else if (zahirahAverage == 83 || zahirahAverage <= 86)
{
    Console.WriteLine("zahirah: B");
}
else
{
    Console.WriteLine("zahirah: C");
}


// jeong

if (jeongAverage > 96)
{
    Console.WriteLine("jeong: A+");
}
else if (jeongAverage == 96 || jeongAverage >= 93)
{
    Console.WriteLine("jeong: A");
}
else if (jeongAverage == 90 || jeongAverage <= 92)
{
    Console.WriteLine("jeong: A-");
}
else if (jeongAverage == 87 || jeongAverage <= 89)
{
    Console.WriteLine("jeong: B+");
}
else if (jeongAverage == 83 || jeongAverage <= 86)
{
    Console.WriteLine("jeong: B");
}
else
{
    Console.WriteLine("jeong: C");
}
