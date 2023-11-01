//amir hossein hemmati
//T.3 factoriel


int adad;
string yesorno;

do
{
    Console.WriteLine("adad khood ra baraye anjam mohasebat vared konid:");
    adad = Convert.ToInt32(Console.ReadLine());

    long x = adad;


    if (adad == 0) x = 1;
    for (int i = 1; i < adad; i++)

    {
        x = x * i;
    }
    Console.WriteLine(x);

    Console.WriteLine("aya mikhahid edame dahid? (bale/kheir)");
    yesorno = Console.ReadLine();

} while (Console.ReadLine() == "bale");