namespace prove_01;

public class Lists
{
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        double[] result = new double[length];
        for (int i = 0; i < length; i++)    
        {
            result[i] = number * (i + 1);
        }
        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    
    
    // i changed the method from void to List<int> so i can return the final list
    public static List<int> RotateListRight(List<int> data, int amount)
    {
        // this is used to find how many items will stay and then be at the end of the new list later
        int splitList = data.Count - amount;

        // this gets the numbers that are moving to the front
        List<int> rightList = data.GetRange(splitList, amount);

        // this gets the numbers that are moving to the back
        List<int> leftList = data.GetRange(0, splitList);

        // this part combines the two lists into a new list
        List<int> result = new List<int>();
        result.AddRange(rightList);
        result.AddRange(leftList);
    
    return result;
    }
}