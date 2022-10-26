

namespace Collections.Classes{
    class Program{
        public static void Main(string[] args){
            //  An Array that hold the integers of 0-9
            int[] nums = new int[] {0,1,2,3,4,5,6,7,8,9};
            // loop through the array and print to the results to the console
            for(int i = 0; i < nums.Length;i++)
            Console.WriteLine(nums[i]);
            
            // An Array that hold the string of names
            string[] names = new string[] {"Tim","Martin", "Nikki", "Sara"};
            // loop through the array and print to the results to the console
            for (int j = 0; j < names.Length;j++)
            Console.WriteLine(names[j]);

            // An array the hold bool values and loops through them then print to the console
            bool[] trueFalse = new bool[] {true,false,true,false,true,false,true,false,true,false};
            for(int b = 0; b < trueFalse.Length; b++)
            Console.WriteLine(trueFalse[b]);

            // A List of strings 
            List<string> iceCreamFlavors = new List<string>();
            // Adds a string to the list
            iceCreamFlavors.Add("Chocolate");
            iceCreamFlavors.Add("Vanilla");
            iceCreamFlavors.Add("Strawberry");
            iceCreamFlavors.Add("Cookies n' Cream");
            iceCreamFlavors.Add("Chocolate Chip");
            iceCreamFlavors.Add("Neapolitan");
            iceCreamFlavors.Add("Cake Batter");

            // Show the amount items in the list that are available with .Count
            Console.WriteLine($"The amount of flavors available are: {iceCreamFlavors.Count}");
            // Show the third item in the list
            Console.WriteLine($"The most favorite flavor today is: {iceCreamFlavors[2]}");
            // Remove an item in the list with RemoveAt that uses an index to find which item is in that spot and removes it
            iceCreamFlavors.RemoveAt(2);
            // Shows the new item count
            Console.WriteLine($"There are only {iceCreamFlavors.Count} available flavor today");

            // A Dictionary that stores 2 strings 
            Dictionary<string,string> Customers = new Dictionary<string,string>();
            // randomizer
            Random rand = new Random();
            // Adds the names for the name array and randomize the iceCreamFlavors array foreach name
            Customers.Add(names[0], iceCreamFlavors[rand.Next(iceCreamFlavors.Count)]);
            Customers.Add(names[1], iceCreamFlavors[rand.Next(iceCreamFlavors.Count)]);
            Customers.Add(names[2], iceCreamFlavors[rand.Next(iceCreamFlavors.Count)]);
            Customers.Add(names[3], iceCreamFlavors[rand.Next(iceCreamFlavors.Count)]);

            // loops through the dictionary and outputs the key with is the name and value which is the flavor to the console
            foreach(var items in Customers){
                Console.WriteLine($"{items.Key} likes {items.Value} icecream");
        }
    }
}
}