int n1, n2, n3, n4, media, ne, exame;

Console.WriteLine("Digite a nota 1: ");
n1 = Convert.ToInt16(Console.ReadLine());
Console.ReadKey();

Console.WriteLine("Digite a nota 2: ");
n2 = Convert.ToInt16(Console.ReadLine());
Console.ReadKey();

Console.WriteLine("Digite a nota 3: ");
n3 = Convert.ToInt16(Console.ReadLine());
Console.ReadKey();

Console.WriteLine("Digite a nota 4: ");
n4 = Convert.ToInt16(Console.ReadLine());
Console.ReadKey();

media = (n1 + n2 + n3 + n4) / 4;
Console.WriteLine("Sua média é de: " + media);

if (media >= 7)
{
    Console.WriteLine("Você foi aprovado!");
}
else
{
    Console.WriteLine("Você foi reprovado e precisará realizar o exame!");

    Console.WriteLine("Digite a nota do exame: ");
    ne = Convert.ToInt16(Console.ReadLine());

    exame = (media + ne) / 2;

    if (exame>=5)
    {
        Console.WriteLine("Você foi aprovado!");
    }
    else
    {
        Console.WriteLine("Você foi reprovado no exame da unip.");
    }
}