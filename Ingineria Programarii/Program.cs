using Ingineria_Programarii;
using URA_Execution_TimeTracker;


ExecutionTimeTracker executionTimeTracker = new ExecutionTimeTracker();


executionTimeTracker.TrackTimeInTicks(
    (int x) => Gauss.Formula(x), 500000000);

executionTimeTracker.TrackTimeInTicks(
    (int x) => Gauss.Iterative(x), 500000000);





int[] arrayInitial = new int[5] { 14, 22, 34, 48, 59 };
int[] exampleArray = Utilities.generateArray(100000);



Tree exampleTree = new Tree();
exampleTree.addNode(5);
exampleTree.addNode(1);
exampleTree.addNode(3);
exampleTree.addNode(9);
exampleTree.addNode(18);
exampleTree.addNode(4);

//exampleTree.Traverse();

executionTimeTracker.TrackTimeInTicks(
    () => exampleTree.Traverse()
    );



