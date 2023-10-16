using Ingineria_Programarii;
using URA_Execution_TimeTracker;


ExecutionTimeTracker executionTimeTracker = new ExecutionTimeTracker();


/// Calculare Suma lui Gauss

executionTimeTracker.TrackTimeInTicks(
    (string x) => Gauss.Formula(500000000), "Suma lui Gauss cu formula");

executionTimeTracker.TrackTimeInTicks(
    (string x) => Gauss.Iterative(500000000), "Suma lui Gauss folosind metoda iterativa");





int[] arrayInitial = new int[5] { 14, 22, 34, 48, 59 };

// Cautari 
int[] exampleArray = Utilities.generateArray(100000);


executionTimeTracker.TrackTimeInTicks(
    (string algo) => Search.LinearSearch(exampleArray, exampleArray[80780]), "Linear Seach");

executionTimeTracker.TrackTimeInTicks(
    (string algo) => Search.BinarySearch(exampleArray, exampleArray[80780]), "Binary Search");






Tree exampleTree = new Tree();
exampleTree.addNode(5);
exampleTree.addNode(1);
exampleTree.addNode(3);
exampleTree.addNode(9);
exampleTree.addNode(18);
exampleTree.addNode(4);

//exampleTree.Traverse();

executionTimeTracker.TrackTimeInTicks(
    (string algo) => exampleTree.Traverse(), "Traversare Arbore"
    );


// Curs 2 -> Sortari


int[] vectorInitial = { 1, 3, 6, 3, 2, 7, 8, 9 };




executionTimeTracker.TrackTimeInTicks(
    (string algo) => Sorting.BubbleSort(vectorInitial), "Metoda Bulelor");

executionTimeTracker.TrackTimeInTicks(
    (string algo) => Sorting.SelectionSort(vectorInitial), "Metoda Sortari prin selectie");

executionTimeTracker.TrackTimeInTicks((string algo) => Sorting.SelectionSortImproved(vectorInitial), "Metoda Sortarii prin Selectie v2");

executionTimeTracker.TrackTimeInTicks(
    (string algo) => Sorting.CoutingSort(vectorInitial, 9), "Sortarea cu vector de frecventa");