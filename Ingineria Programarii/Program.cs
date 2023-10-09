﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


int LinearSearch(int[] initialArray, int searchedItem) {

    for(int i = 0; i< initialArray.Length; i++)
    {
        if (initialArray[i] == searchedItem)
        {
            return i;
        }
    }
    // Not found case
    return -1;
}

int BinarySearch(int[] initialArray, int searchedItem) {
    //Vectorul trebuie sa fie neaparat sortat
    

    //Capat start 
    int p = 0;
    //Capat stop
    int u = initialArray.Length -1;

    while(p <= u)
    {
        int mijloc = (p + u) / 2;
        //`Console.WriteLine("Valoarea mijlocului: " + initialArray[mijloc]);
        if (searchedItem == initialArray[mijloc])
        {
            return mijloc;
        }else if(searchedItem > initialArray[mijloc])
        {
            p = 1 + mijloc;
        }else
        {
            u =  mijloc -1;
        }
    }

    //case of not found
    return -1;
}

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

//DateTime startDateGauss1 = DateTime.Now;
//Console.WriteLine("Gauss 1 - Formula Matematica N(N+1)");
//Console.WriteLine(Gauss1(500000000));
//DateTime endDateGauss1 = DateTime.Now;

//Console.WriteLine("Durata de executie: " + (endDateGauss1 - startDateGauss1).Ticks.ToString() + " Ticks");


//DateTime startDateGauss2 = DateTime.Now;
//Console.WriteLine("Gauss 2 - Instructiune repetitiva ");
//Console.WriteLine(Gauss2(500000000));
//DateTime endDateGauss2 = DateTime.Now;
//Console.WriteLine("Durata de executie: " + (endDateGauss2-startDateGauss2).Ticks.ToString() + " Ticks" );

int[] arrayInitial = new int[5] {14,22,34,48,59 };







int[] generateArray(int size)
{
    Random randomGenerator = new Random();
    int[] generatedArray = new int[size];
    generatedArray[0] = randomGenerator.Next(0,1000);

    for(int i = 1; i < size; i++)
    {
        generatedArray[i] = generatedArray[i-1] + randomGenerator.Next(0, 1000);
    }
    return generatedArray;
}

int[] exampleArray = generateArray(100000);



Tree exampleTree = new Tree();
exampleTree.addNode(5);
exampleTree.addNode(1);
exampleTree.addNode(3);
exampleTree.addNode(9);
exampleTree.addNode(18);
exampleTree.addNode(4);

exampleTree.Traverse();