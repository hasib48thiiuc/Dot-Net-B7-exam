using Task1;

string sp = Console.ReadLine();

VowelCounter mass = new VowelCounter();

string final = mass.GetCounts(sp);



char[] finc = final.ToCharArray();
int i = 0;

       


Console.Write("a-" + finc[0] + ","+ "e-" + finc[1] + ","+ "i-"+ finc[2] + ","+ "o-"+ finc[3]+ ","+ "u-" + finc[4] + ",");
