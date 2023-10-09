using Ingineria_Programarii;


/// Formula
long Gauss1(int n)
{
    return ((long)n*((long)n + 1)) / 2;
}
// Instructiunea for
long Gauss2(int n)
{
    long suma = 0;
    for(int i = 1;i<= n; i++)
    {
        suma += i;
    }
    return suma;
}

DateTime startDateGauss1 = DateTime.Now;
Console.WriteLine("Gauss 1 - Formula Matematica N(N+1)");
Console.WriteLine(Gauss1(500000000));
DateTime endDateGauss1 = DateTime.Now;

Console.WriteLine("Durata de executie: " + (endDateGauss1 - startDateGauss1).Ticks.ToString() + " Ticks");


DateTime startDateGauss2 = DateTime.Now;
Console.WriteLine("Gauss 2 - Instructiune repetitiva ");
Console.WriteLine(Gauss2(500000000));
DateTime endDateGauss2 = DateTime.Now;
Console.WriteLine("Durata de executie: " + (endDateGauss2 - startDateGauss2).Ticks.ToString() + " Ticks");

int[] arrayInitial = new int[5] {14,22,34,48,59 };









int[] exampleArray = Utilities.generateArray(100000);



Tree exampleTree = new Tree();
exampleTree.addNode(5);
exampleTree.addNode(1);
exampleTree.addNode(3);
exampleTree.addNode(9);
exampleTree.addNode(18);
exampleTree.addNode(4);

exampleTree.Traverse();