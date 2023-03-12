﻿/*
 Make a new console application called StudentGroup
Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names (strings).
Get a number from the console between 1 and 2 and print the students from that group in the console.
Ex: studentsG1 ["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
Test Data:
Enter student group: ( there are 1 and 2 )
1
Expected Output:
The Students in G1 are:
Zdravko
Petko
Stanko
Branko
Trajko
 */

string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = { "Ana", "Marta", "Petra", "Ivana", "Klara" };

Console.Write("Enter student group (1 or 2): ");
int groupNumber = int.Parse(Console.ReadLine());

if (groupNumber == 1)
{
    Console.WriteLine("The students in G1 are:");
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (groupNumber == 2)
{
    Console.WriteLine("The students in G2 are:");
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Invalid group number.");
}