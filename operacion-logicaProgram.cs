int nota;
Console.WriteLine("Ingrese la nota: ");
nota = int.Parse(Console.ReadLine());
if (nota >= 61 && nota <= 100) {
    Console.WriteLine("Aprobado");
}
else if (nota >=101 || nota <= -0)
{
    Console.WriteLine("Nota no válida");
}
else
{
    Console.WriteLine("Reprobado");
}   
Console.ReadLine();

