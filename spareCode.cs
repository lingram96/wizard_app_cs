//  static void Main(string[] args)
//         {
//             Random numberGen = new Random();

//             int roll1 = 0;
//             int roll2 = 1;
//             int attempts = 0;

//             Console.WriteLine("Press enter to roll the dice.");

//             while (roll1 != roll2 ) {
//                 Console.ReadKey(); 

//                 roll1 = numberGen.Next(1, 7);
//                 roll2 = numberGen.Next(1, 7);

//                 Console.WriteLine("Roll 1: " + roll1);
//                 Console.WriteLine("Roll 2: " + roll2);
//                 attempts++;
//             }

//             Console.WriteLine("It took you " + attempts + " attempts to roll two of a kind.");

//             Console.ReadKey();
//         }


// string[] movies = new string[5];

//             Console.WriteLine("Type in five movies: ");

//             for (int i = 0; i < movies.Length; i++)
//             {
//                 movies[i] = Console.ReadLine();
//             }    

//             Console.WriteLine("Here they are alpabetically: ");

//             Array.Sort(movies);

//             for (int i = 0; i < movies.Length; i++)
//             {
//                 Console.WriteLine(movies[i]);
//             }

// List<string> shoppingList = new List<string>();

//             shoppingList.Add("Dreams");
//             shoppingList.Add("Miracles");
//             shoppingList.Add("Rainbows");

//             for (int i = 0; i < shoppingList.Count; i++)
//             {
//                 Console.WriteLine(shoppingList[i]);
//             }

//             shoppingList.Remove("Dreams");
//             shoppingList.RemoveAt(1);

//             Console.WriteLine("--------------");

//              for (int i = 0; i < shoppingList.Count; i++)
//             {
//                 Console.WriteLine(shoppingList[i]);
//             }


            // Console.WriteLine("How many students are in the class: ");

            // int studentCount = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Please type in the names: ");

            // string[] students = new string[studentCount];

            // for (int i = 0; i < studentCount; i++)
            // {
            //     students[i] = Console.ReadLine();
            // }

            // Console.WriteLine("------");

            // Array.Sort(students);

            // for (int i = 0; i < studentCount; i++)
            // {
            //     Console.WriteLine(students[i]);
            // }



        //      static void Main(string[] args)
        // {
        //     MeetAlien();
        //     Console.WriteLine("--------");
        //     MeetAlien();
        //     Console.WriteLine("--------");
        //     MeetAlien();

        //     Console.ReadKey();
        // }

        // static void MeetAlien()
        // {
        //     Random numberGen = new Random();

        //     string name = "X-" + numberGen.Next(10, 9999);
        //     int age = numberGen.Next(10, 500);

        //     Console.WriteLine("Hi, I'm " + name);
        //     Console.WriteLine("I'm " + age + " years old");
        //     Console.WriteLine("Oh and I'm an alien!");

        // }

        //  static void Main(string[] args)
        // {
        //     int result = Multiply(3, 9);

        //     Console.WriteLine("The result is: " + result);

        //     if(result % 2 == 0){
        //         Console.WriteLine(result + " is an even number.");
        //     } else{
        //         Console.WriteLine(result + " is an odd number.");
        //     }

        //     Console.ReadKey();
        // }

        // static int Multiply(int num01, int num02)
        // {
        //     int result = num01 * num02;
        //     return result;
        // }