namespace assignment6
{

    #region number 1
    // 1. Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

    //public enum WeekDays
    //{
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday
    //}

    #endregion

    #region number 3
    // 3. Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

    //public enum Season
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter
    //}

    #endregion

    #region number 4
    // 4. Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
    //    Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

    //[Flags]
    //public enum Permissions
    //{
    //    Read = 1,
    //    Write = 2,
    //    Delete = 4,
    //    Execute = 8
    //}

    #endregion

    #region number 5
    // 5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

    //public enum Colors
    //{
    //    Red,
    //    Green,
    //    Blue
    //}
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region number 1
            // 1. Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            #endregion

            #region number 2
            // 2. Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] persons = new Person[3];

            //persons[0] = new Person { Name = "Alice", Age = 30 };
            //persons[1] = new Person { Name = "Bob", Age = 25 };
            //persons[2] = new Person { Name = "Charlie", Age = 35 };

            //foreach (var person in persons)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}

            #endregion

            #region number 3
            // 3. Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter): ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: From March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: From June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: From September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: From December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered.");
            //}
            #endregion

            #region number 4
            // 4. Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //    Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

            //Permissions userPermissions = Permissions.Read | Permissions.Write;

            //userPermissions |= Permissions.Delete;

            //userPermissions &= ~Permissions.Write;

            //bool hasExecutePermission = (userPermissions & Permissions.Execute) == Permissions.Execute;

            //Console.WriteLine($"Has Execute Permission: {hasExecutePermission}");

            //Console.WriteLine($"Current Permissions: {userPermissions}");

            #endregion

            #region number 5
            // 5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Enter a color: ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Colors color))
            //{
            //    if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
            //    {
            //        Console.WriteLine($"{color} is a primary color.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is not a primary color.");
            //}

            #endregion

            #region number 6
            // 6. Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Point point1 = new Point();
            //Point point2 = new Point();

            //// Get first point from user
            //Console.WriteLine("Enter the X coordinate of the first point: ");
            //point1.X = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Y coordinate of the first point: ");
            //point1.Y = double.Parse(Console.ReadLine());

            //// Get second point from user
            //Console.WriteLine("Enter the X coordinate of the second point: ");
            //point2.X = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Y coordinate of the second point: ");
            //point2.Y = double.Parse(Console.ReadLine());

            //// Calculate distance
            //double dx = point1.X - point2.X;
            //double dy = point1.Y - point2.Y;
            //double distance = Math.Sqrt(dx * dx + dy * dy);

            //Console.WriteLine($"The distance between the points is {distance:F2}");
            #endregion

            #region number 7
            // 7. Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person[] persons = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter the name of person {i + 1}: ");
            //    string name = Console.ReadLine();
            //    Console.WriteLine($"Enter the age of person {i + 1}: ");
            //    int age = int.Parse(Console.ReadLine());
            //    persons[i] = new Person { Name = name, Age = age };
            //}

            //Person oldestPerson = persons[0];

            //foreach (var person in persons)
            //{
            //    if (person.Age > oldestPerson.Age)
            //    {
            //        oldestPerson = person;
            //    }
            //}

            //Console.WriteLine($"The oldest person is {oldestPerson.Name} with an age of {oldestPerson.Age}");
            #endregion
        }
    }
}