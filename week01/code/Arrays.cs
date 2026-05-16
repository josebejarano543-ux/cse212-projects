using System;
using System.Collections.Generic;

public static class Arrays
{
    public static double[] MultiplesOf(double start, int count)
    {
        // Create an array to store the multiples
        double[] result = new double[count];

        // Loop through the array
        for (int i = 0; i < count; i++)
        {
            // Store the multiple
            result[i] = start * (i + 1);
        }

        // Return the array
        return result;
    }

    public static void RotateListRight(List<int> data)
    {
        if (data.Count <= 1)
        {
            return;
        }

        int last = data[data.Count - 1];

        for (int i = data.Count - 1; i > 0; i--)
        {
            data[i] = data[i - 1];
        }

        data[0] = last;
    }
}