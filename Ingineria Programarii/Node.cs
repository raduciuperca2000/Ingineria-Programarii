// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");










using Ingineria_Programarii;


//Arbore de cautare 


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
