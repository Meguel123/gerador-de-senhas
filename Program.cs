
Console.Clear();
int i, c;
int N, P, AP;

c = 2;
N = 1;
P = 1;

for(i = 1; i < c;)
{
c = c + 3;
AP = i;


Thread.Sleep(30000);
Console.Clear();
Console.WriteLine(@$"--------------GERADOR DE SENHAS-------------- ");
Console.WriteLine("AP" + AP);

Thread.Sleep(15000);
Console.Clear();
Console.WriteLine(@$"--------------GERADOR DE SENHAS-------------- ");
Console.WriteLine("P" + P);
Thread.Sleep(15000);
AP = AP + 1;
Console.Clear();
Console.WriteLine(@$"--------------GERADOR DE SENHAS-------------- ");
Console.WriteLine("AP" + AP);
Thread.Sleep(30000);
P = P + 1;
AP = AP + 1;
Console.Clear();
Console.WriteLine(@$"--------------GERADOR DE SENHAS-------------- ");
Console.WriteLine("N" + N);
Console.WriteLine("AP" + AP);
N = N + 1;
i = i + 3;
}

