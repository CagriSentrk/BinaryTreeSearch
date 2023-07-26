using System;

public class Node
{
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int value, Node left, Node right)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

public class BinarySearchTree
{
    public static bool Contains(Node root, int value)
    {
        // Kök düğüm(root) yoksa, yani ağaç boşsa, aradığımız değeri bulamayız. 
        // Bu nedenle, 'false' döndürülür.
        if (root == null)
            return false;
        // Eğer 'root.Value' (kök düğümün değeri), aradığımız 'value' değeriyle eşitse,
        // aradığımız değeri ağaçta bulduk demektir. Bu durumda 'true' döndürülür.
        if (root.Value == value)
            return true;

        // Eğer aranan değer, kök düğümün değerinden küçükse, sol alt ağaçta aranmalıdır.
        // Eğer aranan değer, kök düğümün değerinden büyükse, sağ alt ağaçta aranmalıdır.
        if (value < root.Value)
            return Contains(root.Left, value);
        else
            return Contains(root.Right, value);
    }

    public static void Main(string[] args)
    {
        Node n1 = new Node(1, null, null);
        Node n3 = new Node(3, null, null);        //                   N2= 2 
        Node n2 = new Node(2, n1, n3);           //                   /     \
                                                //                   /       \
                                               //                   /         \ 
                                              //                 N1 = 1       N3 = 3
                                               
        // İkinci ağaç yapısının root'u 'n2' (2) ve 3 değeri bu ağaçta bulunuyor. 
        Console.WriteLine(Contains(n2, 3)); // Output: True


    }
}
