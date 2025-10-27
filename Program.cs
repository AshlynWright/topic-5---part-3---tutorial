namespace topic_5___part_3___tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age; 
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 13 && age <= 19)
                Console.WriteLine("You are a teenager.");
            else
                Console.WriteLine("You are not a teenager.");


            string working;
            double money;
            Console.WriteLine("How much money do you have?");
            money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Are you working (yes/no)?");
            working = Console.ReadLine().ToLower();
            if (working == "no" && money >= 20)
                Console.WriteLine("You can go to the movie");
            else
                Console.WriteLine("Sorry, you can't go to the movie.");



            string topping;
            Console.WriteLine("What is the pizza topping?");
            topping = Console.ReadLine();
            if (topping == "pepperoni" || topping == "bacon")
                Console.WriteLine("I would eat this.");
            else
                Console.WriteLine("No thanks.");

            // task 1
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());

            if (age <= 12 || age >= 60)
                Console.WriteLine("The pass is $2.00");
            else
                Console.WriteLine("The pass is $3.50");


            //task 2
            string animal;
            Console.WriteLine("What is your favourite type of animal");
            animal = Console.ReadLine().ToLower();
            if (animal == "cat" || animal == "dog")
                Console.WriteLine("Me Too!");
            else
                Console.WriteLine("To each their own.");


            //task 3
            string weather;
            int temperature;
            Console.WriteLine("What is the temperature like oustide?");
            temperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the weather like (sunny/rainy)?");
            weather = Console.ReadLine();
            if (weather == "sunny" && temperature >= 25)
                Console.WriteLine("It's a nice day for a walk.");
            else
                Console.WriteLine("Maybe stay inside today.");

        }
    }
}
