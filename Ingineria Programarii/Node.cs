// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");




/// Formula
// Instructiunea for

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









//DateTime startTimeLinearSearch = DateTime.Now;
//Console.WriteLine(LinearSearch(exampleArray, exampleArray[80780]));
//DateTime endTimeLinearSearch = DateTime.Now;
//Console.WriteLine("Timpul de executie pentru Linear Search" +
//    " este de: " + (endTimeLinearSearch - startTimeLinearSearch).Ticks.ToString());
//DateTime startTimeBinarySearch = DateTime.Now;
//Console.WriteLine(BinarySearch(exampleArray, exampleArray[80780]));
//DateTime endTimeBinarySearch = DateTime.Now;
//Console.WriteLine("Timpul de executie pentru " +
//    "Binary Search este de: " + (endTimeBinarySearch - startTimeBinarySearch).Ticks.ToString());


// Arbore de cautare 


class Node
{
    public int key { get; set; }
    public Node left;
    public Node right;

    public Node(int key)
    {
        this.key = key;
        this.left = null;
        this.right = null;
    }
}


class Tree
{
    Node root = null;


    public void addNode(int key)
    {
        addNodeInternal(ref root,key);
    }
    

    private void addNodeInternal(ref Node root, int key )
    {
        if (root == null)
        {
            root = new Node(key);
        }
        else
        {
                if (root.key == key) return;
            if (root.key < key)
            {
                addNodeInternal(ref root.right, key);
            }
            else
            {
                addNodeInternal(ref root.left, key);
            }
        }
    }
    //public override string ToString()
    //{
    //    return Traverse(root, string.Empty);
    //}

    public void Traverse()
    {
        Traverse(root, string.Empty);
    }

    private void Traverse(Node node, string currentString)
    {
        if (node != null)
        {
            Traverse(node.left, currentString);
            Console.WriteLine(node.key);
            Traverse(node.right, currentString);
            
        }
    }



}
