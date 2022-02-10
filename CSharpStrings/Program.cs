using System; //all these stuffs are configuring the files. we can specify these things we can use. 

namespace StaticClassAttributes //same name as the project we are using. we are in the project.
                                //these two curly brackets is where we start our coding
{
    public static class Program //class is like a container that we can put our code. 
    {
        static void Main(string[] args) //this is sort of like another container we can put our code. This Main method any code we put inside of these curly brackets it will execute our code. 
        {
            string phrase = "Giraffe Academy";
            Console.WriteLine(phrase.Length); //find the length of string
            Console.WriteLine(phrase); //print the variable called phrase
            Console.WriteLine(phrase.ToUpper()); //modify the string to upper case
            Console.WriteLine(phrase.ToLower()); //modify the string to lower case
            Console.WriteLine(phrase.Contains("Academy")); //tell us if this phrase string contains a set of characters. you need a parameter. we want to find out if this phrase has a string called academy.
            Console.WriteLine(phrase.Contains("Academies")); //vice versa

            Console.WriteLine(phrase[0]); //i can actually access each character. Console should show G
            Console.WriteLine(phrase[2]); //i can actually access each character. Console should show r
            Console.WriteLine(phrase[8]); //i can actually access each character. Console should show A

            //we can use IndexOf() method
            //this will tell us where each character is located.

            Console.WriteLine(phrase.IndexOf("Academy"));   //so we know it start at 8
            Console.WriteLine(phrase.IndexOf("f"));   //so we know it start at 4
            Console.WriteLine(phrase.IndexOf("z"));   //so when we run the program it will be a - 1 number because that just mean this character is not inside the string.


            //substring() method
            Console.WriteLine(phrase.Substring(8));   //basically you can grab one part of the string. i tiwll grab starting at 8 and until the end of the string.
            Console.WriteLine(phrase.Substring(8, 3));   //you can grab another character. so you're saying that you want to grab from 8 to 3. In your Console it would print out as Aca.
                                                      



            Console.ReadLine();




        }




    }


}

/*
 Topic: What is string?
Strings are used for storing text.
A string variable contains a collection of characters surrounded by double quotes:




 */