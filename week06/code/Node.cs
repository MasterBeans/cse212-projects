public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if(value > Data) // to make sure value is unique
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data){
            return true;
        }
        else if (value < Data && Left != null){
            return Left.Contains(value);
        }
        else if (value > Data && Right != null){
            return Right.Contains(value);
        }
        return false;
    }

    public int GetHeight()
    {

        // TODO Start Problem 4
        
        int leftHeight, rightHeight;
         if (this == null) 
        {
            return 0; // No nodes, height is 0
        }
                
        if (Left != null){
            leftHeight = Left.GetHeight();
        }
        else{
            leftHeight = 0;
        }
        
        if (Right != null){
            rightHeight = Right.GetHeight();
        }
        else{
            rightHeight = 0;
        }
        
        if (leftHeight > rightHeight){
            return leftHeight + 1;
        }
        else if (rightHeight > leftHeight){
            return rightHeight + 1;
        }
        else{
            return leftHeight +1;
        }
    }
}