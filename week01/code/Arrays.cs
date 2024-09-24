using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>Array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Plan:
        // 1. Create a new array of doubles with the size specified by 'length'.
        // 2. Use a for loop to populate the array:
        //    a. The first element should be 'number'.
        //    b. Each subsequent element should be calculated as (number * (index + 1)), 
        //       where 'index' is the current loop iteration starting from 0.
        // 3. Return the populated array.

        // Step 1: Initialize the array
        double[] multiplesArray = new double[length];

        // Step 2: Populate the array with multiples of 'number'
        for (int i = 0; i < length; i++)
        {
            multiplesArray[i] = number * (i + 1);
        }

        // Step 3: Return the array of multiples
        return multiplesArray; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3, then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  
    /// The value of amount will be in the range of 1 to data.Count, inclusive.
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Plan:
        // 1. Ensure that the amount is within the valid range (1 to data.Count).
        // 2. Calculate the effective rotation amount using modulo operation: 
        //    (amount % data.Count) to handle cases where the amount is greater than the list size.
        // 3. Use a list to temporarily hold the rotated elements.
        // 4. Copy elements from the original list to their new positions based on the calculated index.
        // 5. Replace the original list's elements with the rotated ones.

        // Step 1: Ensure amount is within the valid range
        if (data.Count == 0) return; // No need to rotate if the list is empty
        amount = amount % data.Count;

        // Step 2: Create a temporary list for rotated values
        List<int> rotatedList = new List<int>(data.Count);

        // Step 3: Populate the temporary list with rotated values
        for (int i = 0; i < data.Count; i++)
        {
            // Calculate the new index based on the rotation
            int newIndex = (i + amount) % data.Count;
            rotatedList.Add(data[newIndex]);
        }

        // Step 4: Clear the original list and add the rotated elements back
        data.Clear();
        data.AddRange(rotatedList);
    }
}
