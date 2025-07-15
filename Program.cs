// DSA Questions
// 2 Sum - Given an array of integers, find two numbers such that they add up to a specific target number.
// 3 Sum - Given an array of integers, find all unique triplets that add up to a specific target number.
// String Compression - ["a","a","b","b","c","c","c"] should return 6 as ["a","2","b","2","c","3"]
// Move 0s to front in an array
// Find element in sorted 2D array
// BFS in tree
// DFS in tree
// Top k collections
// Next file name generator
// Give a 2D array of integers, find the maximum length of sequence of consecutive integers. 
/**
 * Design a data structure which has following operations: 
	1. void add(e) 
	2. void delete(e) 
	3. boolean contains(e) 
	4. e getRandom() 
	5. e getMostRecentlyAccessed() 
	All operations should be preferably O(1). If not possible, which one and why?
*/
/**
 * - You are given a 2D matrix filled with 0's and 1's. 1 represents the cells that you can travel to and 0 represents cells that are prohibited. Give a starting point, find out the maximum distance that you can travel from the starting point. You can go to a cell only once.
	0 0 0 1 0 0
	1 1 0 X 0 0
	0 1 0 1 1 0
	0 0 0 0 1 0
Starting point - (1,3) - Output 3
*/
/**
 * Imagine you have a special keyboard with all keys in a single row. The layout of characters on a keyboard is denoted by a string keyboard of length 26. Initially your finger is at index 0. To type a character, you have to move your finger to the index of the desired character. The time taken to move your finger from index i to index j is abs(j - i).

Given a string keyboard that describe the keyboard layout and a string text, return an integer denoting the time taken to type string text.

Input: keyboard = "abcdefghijklmnopqrstuvwxy", text = "cba" 
Output: 4
*/
/**
 * Given a wall, which is made up of two types of bricks (pores / Non-Porous).
Pores bricks allow water to pass through them. Non-Porous won't. 
Find whether water reaches to ground, if there is any rainfall.
Water can flow from top to bottom, diagonally, horizontally as well.
Only flowing from bottom to top is not possible.
Write a function that can tell me, when rain falls, whether it will reach the bottom or not.
	P N P N N
	N N N P P
	N N P N P
	N N P N N
*/
/**
 * - [Easy] Given a hotel which has 10 floors [0-9] and each floor has 26 rooms [A-Z]. You are given a sequence of rooms, where + suggests room is booked, - room is freed. You have to find which room is booked maximum number of times.
Input: ["+1A", "+3E", "-1A", "+4F", "+1A", "-3E"]
Output: "1A"
*/
/**
 * - Imagine you have a special keyboard with all keys in a single row. The layout of characters on a keyboard is denoted by a string keyboard of length 26. Initially your finger is at index 0. To type a character, you have to move your finger to the index of the desired character. The time taken to move your finger from index i to index j is abs(j - i).

Given a string keyboard that describe the keyboard layout and a string text, return an integer denoting the time taken to type string text.

Example 1:

Input: keyboard = "abcdefghijklmnopqrstuvwxy", text = "cba" 
Output: 4
*/

// LLD Problems
/**
 * Lets say you have some class/function that is listening to message queue and the function gets 
 * invoked when there are messages on the queue. Write a class/function that saves these messages to 
 * DB when - at least 500 messages have been received or at least 5 seconds have passed since the last save.
 */
/**
 * - Lets say I have created a java package DomainHelper which has a function GetIpAddress() 
 * that returns the IP address by querying DNS. You have to use this in your program 
 * but optimize the usage for performance
	class DomainHelper() {
		public string GetIpAddress(string domainName)
	}
*/

// Chess
// Battleship
// Snakes and ladders
// File conversion utility
// Metrics conversion utility
// Virtual file system with search etc.
// Rate limiter

Console.WriteLine("Hello, World!");
