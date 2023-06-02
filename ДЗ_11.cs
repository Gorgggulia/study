using System;
using System.Collections.Generic;

delegate void MyDel(int m);

class Student
{
    public string Name { get; }
    public List<int> Marks { get; }

    public event MyDel MarkChange;

    public Student(string name)
    {
        Name = name;
        Marks = new List<int>();
    }

    public void AddMark(int mark)
    {
        Marks.Add(mark);
        MarkChange?.Invoke(mark);
    }
}

class Parent
{
    public void OnMarkChange(int mark)
    {
        Console.WriteLine($"Parent: The student received a mark of {mark}");
    }
}

class Accountancy
{
    public void PayingFellowship(int mark)
    {
        if (mark >= 90)
        {
            Console.WriteLine("Accountancy: The student is eligible for a scholarship.");
        }
        else
        {
            Console.WriteLine("Accountancy: The student is not eligible for a scholarship.");
        }
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("John");
        Parent parent = new Parent();
        Accountancy accountancy = new Accountancy();

        student.MarkChange += parent.OnMarkChange;
        student.MarkChange += accountancy.PayingFellowship;

        student.AddMark(80);
        student.AddMark(95);
        student.AddMark(88);
    }
}