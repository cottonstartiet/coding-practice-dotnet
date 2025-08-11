using System;
using System.Collections.Generic;

namespace coding_practice_dotnet.DSA;

public class KeyboardDistance
{
    private const string KeyboardLayout = "abcdefghijklmnopqrstuvwxyz";

    public static int CalculateTime(string input)
    {
        IDictionary<char, int> keyMap = new Dictionary<char, int>();
        for (int i = 0; i < KeyboardLayout.Length; i++)
        {
            keyMap[KeyboardLayout[i]] = i;
        }

        int previousPosition = 0;
        int distance = 0;

        foreach (var ch in input)
        {
            int currentPosition = keyMap[ch];
            distance += Math.Abs(previousPosition - currentPosition);
            previousPosition = currentPosition;
        }

        return distance;
    }
}
