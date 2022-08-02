// *Three Basic Arrays
// Create an array to hold integer values 0 through 9
// Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
// Create an array of length 10 that alternates between true and false values, starting with true

int[] nums = {0,1,2,3,4,5,6,7,8,9};

string[] names = {"Tim", "Martin", "Nikki","Sara"};

bool[] bools = {true,false,true,false,true,false,true,false,true,false};



//* List of Flavors
// Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
// Output the length of this list after building it
// Output the third flavor in the list, then remove this value
// Output the new length of the list (It should just be one fewer!)\

List<string> flavors = new List<string>();
flavors.Add("chocolate");
flavors.Add("mango");
flavors.Add("strawberry");
flavors.Add("peach");
flavors.Add("orange");

Console.WriteLine(flavors.Count);
Console.WriteLine(flavors[2]);
flavors.Remove(flavors[2]);
Console.WriteLine(flavors.Count);

//* User Info Dictionary
// Create a dictionary that will store both string keys as well as string values
// Add key/value pairs to this dictionary where:
// each key is a name from your names array
// each value is a randomly elected flavor from your flavors list.
// Loop through the dictionary and print out each user's name and their associated ice cream flavor


Dictionary<string,string> somedict = new Dictionary<string,string>();
somedict.Add("tim","mango");
somedict.Add("Martin","chocolate");
somedict.Add("Nikki","orange");
somedict.Add("Sara","strawberry");

foreach(KeyValuePair<string,string> entry in somedict){
    Console.WriteLine(entry.Key + " " + entry.Value );
}