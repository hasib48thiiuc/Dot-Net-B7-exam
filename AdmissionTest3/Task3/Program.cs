// See https://aka.ms/new-console-template for more information
using Task3;

Console.WriteLine("Hello, World!");
PrimeFinder primeFinder = new PrimeFinder();
var actualResult = primeFinder.GetPrimes(1,100);

foreach(var result in actualResult)
    if(result!=0)
    Console.Write($"{result}, ");