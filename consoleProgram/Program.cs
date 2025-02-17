using System;
using System.IO;

class Program
{
    public static void Main()
    {
     
        Console.WriteLine("Enter the path of the CSV file");
        string? filePath = Console.ReadLine();

        try
        {
        
            string[] lines = File.ReadAllLines(filePath);

            
            Student[] students = new Student[lines.Length - 1]; 

            
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                string[] parts = line.Split(',');

               

               
                string name = parts[0].Trim();
                string surname =  parts[1].Trim();
                string score = parts[2].Trim();

              
                students[i - 1] = new Student(
                    name,
                    surname,
                    int.Parse(score) 
                );

                //save student to database, did't have a database intalled on my computer
                //time run out, used h2 in memory on the springboot api
        
            }

            Array.Sort(students, (s1,s2) => s2.Score.CompareTo(s1.Score));


           foreach(var i in students)
           {
            
            if(i.Score == students[0].Score)
            {
                Console.WriteLine(i.Surname);
            }

           }

           Console.WriteLine("Score: " + students[0].Score);

           


           
            
            

            

           
        }
        catch (Exception ex)
        {
            
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Score { get; set; }

    public Student(string name, string surname, int score)
    {
        this.Name = name;
        this.Surname = surname;
        this.Score = score;
    }
}
