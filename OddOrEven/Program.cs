Console.WriteLine("Sisesta number:");

int userNum=Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris v paaritu

int result = userNum % 2;

Console.WriteLine(result);

if (result != 0) //!= ei ole
{
    Console.WriteLine("Number on paaritu");
}
else
{
    Console.WriteLine("Number on paaris");
}