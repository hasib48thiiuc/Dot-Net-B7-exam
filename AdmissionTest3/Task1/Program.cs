using Task1;

string sp = Console.ReadLine();

VowelCounter mass = new VowelCounter();

string final = mass.GetCounts(sp);



char[] finc = final.ToCharArray();
int i = 0;
while( i < finc.Length)
{
    if (i == 0)

        Console.Write("a-" + finc[i] + ",");
    else if (i == 1)
        Console.Write("e-" + finc[i] + ",");
    else if (i == 2)
        Console.Write("i-" + finc[i] + ",");
    else if (i == 3)
        Console.Write("o-" + finc[i] + ",");
    else if (i == 4)
        Console.Write("u-" + finc[i]);
    i++;
}

