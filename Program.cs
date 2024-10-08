public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Please enter your grade from 0-100");
        float grade = float.Parse(Console.ReadLine());

        if(grade >= 100){
            Console.WriteLine("Letter grade = A+");
            Console.WriteLine("Wow! 100…That’s impressive! ");
        }

        else if(grade >= 90){
            Console.WriteLine("Letter grade = A");
            Console.WriteLine("Very nice!");
        }

        else if(grade >= 80){
            Console.WriteLine("Letter grade = B");
            Console.WriteLine("Keep it up!");
        }

        else if(grade >= 70){
            Console.WriteLine("letter grade = C");
            Console.WriteLine("You got this, keep working!");
        }

        else if(grade >= 60){
            Console.WriteLine("Letter grade = D");
            Console.WriteLine("Keep trying!");
        }

        else{
            Console.WriteLine("Letter grade = F");
            Console.WriteLine("Don’t give up!");
        }
    }
}