
# Cracking the Coding Interview 

189 programming questions and my solutions in C# 

## Chapter 1 – Arrays and Strings 

### 1.1 Is Unique 

Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures? 

### 1.2 Check Permutation 

Given two strings, write a method to decide it one is a permutation of the other. 

### 1.3 URLify 

Write a method to replace all spaces in a string with '%20'. You may assume that the string has sufficient space at the end to hold the additional characters, and that you are given the "true" length of the string. 

### 1.4 Palindrome Permutation 

Given a string, write a function to check if it is a permutation of a palindrome. A palindrome is a word or phrase that is the same forwards and backwards. A permutation is a rearrangement of letters. The palindrome does not need to be limited to just dictionary words. You can ignore casing and non-letter characters. 

### 1.5 One Away 

There are three types of edits that can be performed on strings: insert a character, remove a character, or replace a character. Given two strings, write a function to check if they are one edit (or zero edits) away. 

### 1.6 String Compression 

Implement a method to perform basic string compression using the counts of repeated characters. For example, the string `aabcccccaaa` would become `a2b1c5a3`. If the "compressed" string would not become smaller than the original string, your method should return the original string. 

### 1.7 Rotate Matrix 

Given an image represented by an N x N matrix, where each pixel in the image is represented by an integer, write a method to rotate the image by 90 degrees. Can you do this in place? 

### 1.8 Zero Matrix 

Write an algorithm such that if an element in an M x N matrix is 0, its entire row and column are set to 0. 

### 1.9 String Rotation 

Assume you have a method `isSubstring` which checks if one word is a substring of another. Given two strings, `s1` and `s2`, write code to check if `s2` is a rotation of `s1` using only one call to `isSubstring` (e.g., "waterbottle" is a rotation of "erbottlewat"). 

## Chapter 2 – Linked lists 

### 2.1 Remove Dups 

Write code to remove duplicates from an unsorted linked list. How would you solve this problem if a temporary buffer is not allowed? 

### 2.2 Return Kth to Last 

Implement an algorithm to find the kth to last element of a singly linked list. 

### 2.3 Delete Middle Node 

Implement an algorithm to delete a node in the middle (i.e., any node but the first and last node, not necessarily the exact middle) of a singly linked list, given only access to that node. 

### 2.4 Partition 

Write code to partition a linked list around a value x, such that all nodes less than x come before all nodes greater than or equal to x. 

## Chapter 3 – Stacks and Queues 

### 3.3 – Stack of Plates 

Imagine a (literal) stack of plates. If the stack gets too high, it might topple. Therefore, in real life, we would likely start a new stack when the previous stack exceeds some threshold. Implement a data structure `SetofStacks` that mimics this. `SetofStacks` should be composed of several stacks and should create a new stack once the previous one exceeds capacity. `SetofStacks.push()` and ?`SetofStacks.pop()` should behave identically to a single stack (that is, `pop()` should return the same values as it would if there were just a single stack). Implement a function `popAt(int index)` which performs a pop operation on a specific sub-stack. 

### 3.4 – Queue via Stacks 

Implement a `MyQueue` class which implements a queue using two stacks. 

### 3.5 – Sort Stack 

Write a program to sort a stack such that the smallest items are on the top. You can use an additional temporary stack, but you may not copy the elements into any other data structure (such as an array). The stack supports the following operations: `push`, `pop`, `peek`, and `isEmpty`. 

### 3.6 – Animal Shelter 

An animal shelter, which holds only dogs and cats, operates on a strictly "first in, first out" basis. People must adopt either the "oldest" (based on arrival time) of all animals at the shelter, or they can select whether they would prefer a dog or a cat (and will receive the oldest animal of that type). They cannot select which specific animal they would like. Create the data structures to maintain this system and implement operations such as `enqueue`, `dequeueAny`, `dequeueDog`, and `dequeueCat`. You may use the built-in `LinkedList` data structure. 

