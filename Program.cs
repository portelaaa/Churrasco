int adultAlcool, adultSemAlcool, kids, adultos, totalPessoas;
double carne, acomp, cerveja, refri, agua;

Console.Clear();

Console.WriteLine("--- Churrasco ---\n");

Console.Write("Adultos (que consomem bebidas alcoólicas).......: ");
adultAlcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Adultos (que não consomem bebidas alcoólicas)...: ");
adultSemAlcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Crianças........................................: ");
kids = Convert.ToInt32(Console.ReadLine());

adultos = adultAlcool + adultSemAlcool;
totalPessoas = adultos + kids;

carne = 0.4 * adultos + 0.2 * kids;
acomp = 0.2 * totalPessoas;
cerveja = 2 * adultAlcool;
refri = 0.5 * (adultSemAlcool + kids);
agua = 0.4 * totalPessoas;

Console.WriteLine();

Console.WriteLine($"Carne.............: {carne:N1}kg");
Console.WriteLine($"Acompanhamentos...: {acomp:N1}kg");
Console.WriteLine($"Cerveja...........: {cerveja:N1}l");
Console.WriteLine($"Refrigerante......: {refri:N1}l");
Console.WriteLine($"Água..............: {agua:N1}l");