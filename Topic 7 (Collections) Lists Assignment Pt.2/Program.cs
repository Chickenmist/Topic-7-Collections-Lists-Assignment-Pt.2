namespace Topic_7__Collections__Lists_Assignment_Pt._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> vegetables = new List<string>() {"CARROT", "BEET", "CELERY", "RADISH", "CABBAGE"};

            bool running = true;
            int selection = 0, vegetableRemoveByIndex = 0;
            string vegetableRemoveByValue = "", findVegetable = "", addVegetable = "";

            while(running)
            {
                Console.WriteLine("Vegetables:");
                for (int i = 0; i < vegetables.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {vegetables[i]}");
                }

                Console.WriteLine("");
                Console.WriteLine("Menu: ");
                Console.WriteLine("1 - Remove a Vegetable by Index          2 - Remove a Vegetable by Value");
                Console.WriteLine("3 - Search for a Vegetable               4 - Add a Vegetable");
                Console.WriteLine("5 - Sort List                            6 - Clear the list");
                Console.WriteLine("7 - Quit");
                Console.Write("Selection: ");
                int.TryParse( Console.ReadLine(), out selection );

                if (selection <= 0 || selection > 7) //Invalid selection
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid Selection");
                }
                else if (selection == 1) //Remove vegetable by index
                {
                    Console.WriteLine("");
                    
                    while (vegetableRemoveByIndex == 0)
                    {
                        Console.Write("What is the index number of the vegetable you want to remove? ");
                        int.TryParse(Console.ReadLine(), out vegetableRemoveByIndex);
                        
                        if (vegetableRemoveByIndex <= 0 || vegetableRemoveByIndex >= vegetables.Count() - 1)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Invald Selection");
                            Console.WriteLine("");

                            vegetableRemoveByIndex = 0;
                        }
                        else
                        {
                            vegetables.RemoveAt(vegetableRemoveByIndex - 1);
                        }
                    }
                    vegetableRemoveByIndex = 0;
                }
                else if (selection == 2) //Remove vegetable by value
                {
                    Console.WriteLine("");
                    Console.Write("What vegetable do you want to remove? ");
                    vegetableRemoveByValue = Console.ReadLine().ToUpper();

                    if (vegetables.Contains(vegetableRemoveByValue))
                    {
                        vegetables.Remove(vegetableRemoveByValue);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"{vegetableRemoveByValue} cannot be removed as tt cannot be found");
                    }
                }
                else if (selection == 3) //Search for a vegetable
                {
                    Console.WriteLine("");
                    Console.Write("What vegetable do you want to find? ");
                    findVegetable = Console.ReadLine().ToUpper();
                    
                    if (vegetables.Contains(findVegetable))
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"{findVegetable} has been found at index {vegetables.IndexOf(findVegetable) + 1}");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"{findVegetable} could not be found");
                    }
                }
                else if (selection == 4) //Add a vegetable
                {
                    Console.WriteLine("");
                    Console.Write("What is the vegetable you want to add? ");
                    addVegetable = Console.ReadLine().ToUpper();

                    if (vegetables.Contains(addVegetable))
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"The list already contains {addVegetable}");
                    }
                    else
                    {
                        vegetables.Add(addVegetable);
                    }
                }
                else if (selection == 5) //Sort list
                {
                    vegetables.Sort();
                }
                else if (selection == 6) //Clear the list
                {
                    vegetables.Clear();
                }
                else if (selection == 7)
                {
                    running = false;
                }

                Console.WriteLine("");
            }
        }
    }
}