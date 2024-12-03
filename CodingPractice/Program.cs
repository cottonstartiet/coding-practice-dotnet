// See https://aka.ms/new-console-template for more information
using CodingPractice;
using CodingPractice.Logger;

BinarySearch bs = new();
Log.Info(bs.Search(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 7));
Log.Info(bs.Search(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 10));
