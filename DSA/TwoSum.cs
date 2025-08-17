using System;

namespace coding_practice_dotnet.DSA;

public class TwoSum
{
    public static Tuple<int, int>? IsTwoSum(int[] numbers, int target)
    {
        if (numbers == null || numbers.Length < 2)
        {
            return null; // Invalid input
        }


        var map = new HashSet<int>();
        foreach (var num in numbers)
        {
            var complement = target - num;
            if (map.Contains(complement))
            {
                return Tuple.Create(complement, num);
            }
            map.Add(num);
        }

        return null;
    }
}
