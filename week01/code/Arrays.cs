public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Process for solving the problem:
        //1. Initialize an array to receive the multiples starting from the param 'number'
        //2. Create a loop to traverse from 0 to the param length
        //3. Compute the multiple and assign it to the array according the its sequence as array index

        double[] multiples = new double[length];
        
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Steps to solve this problem
        //1. Use modulo to calculate effective rotations
        //2. Use a loop to shift elements
        
        int rotations = amount % data.Count;

        for (int i = 0; i < rotations; i++)
        {
            // Store the last element
            int lastElement = data[data.Count - 1];
            // Shift elements to the right
            for (int j = data.Count - 1; j > 0; j--)
            {
                data[j] = data[j - 1];
            }
            // Place the last element at the front
            data[0] = lastElement;
        }
    }

}
