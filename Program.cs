/* bool flag = true;
int value = 0;
if(flag) {
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside of the code block: {value}"); */

/* bool flag = true;
if (flag)
    Console.WriteLine(flag);
 */

/* int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

 foreach (int number in numbers) {

    total += number;

    if (number == 42) {
        found = true;
    }
 }

 if(found) {
    Console.WriteLine("Set contains 42");
 }

 Console.WriteLine($"Total: {total}"); */

/*  int employeeLevel = 100;

 string employeeName = "John Smith";

 string title = "";

 switch (employeeLevel) {
    case 100: 
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400: 
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
 }

 Console.WriteLine($"{employeeName}, {title}"); */

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
/* string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0]) {
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-shirt";
        break;
    case "03":
        type = "Sweat shirt";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1]) {
    case "BL":
        color = "black";
        break;
    case "MN": 
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch(product[2]) {
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One size fits all";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}"); */

/* string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = names.Length - 1; i >= 0; i--) {
    Console.WriteLine(names[i]);
}


for (int i = 0; i < names.Length; i++)
    if (names[i] =="David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name); */

// Oppgave Code challenge module 3 for loop

/* for (int i = 1; i <= 100; i++) {
    if(i % 3 == 0 && i % 5 == 0) {
        Console.WriteLine($"{i} FizzBuzz");
    } else if (i % 5 == 0) {
        Console.WriteLine($"{i} Buzz");
    } else if (i % 3 == 0) {
        Console.WriteLine($"{i} Fizz");
    } else {
        Console.WriteLine(i);
    }
}
 */

// Oppgave Code challenge module 3 do while loop

/* Random random = new Random();

int current = random.Next(1, 11);

do {
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while(current != 7);
 */
/* while (current >= 3) {
    Console.WriteLine(current);
    current = random.Next(1, 11);
} 

Console.WriteLine($"Last number: {current}"); */

/* int hero = 10;

int monster = 10;

Random attack = new Random();



do {
    int damage = attack.Next(1, 11);
    monster -= damage;
    Console.WriteLine($"The monster was damaged and lost {damage} health. It now has {monster} health left.");
    
    if(monster <= 0) {
        Console.WriteLine($"The hero wins with {hero} health left!");
        break;
    }

    damage = attack.Next(1, 11);

    hero -= damage;
    Console.WriteLine($"The hero was damaged and lost {damage} health. They now have {hero} health left.");

    if(hero <= 0) {
        Console.WriteLine($"The monster wins with {monster} health left!");
    }

} while(hero > 0 && monster > 0); */

// Code challenge 2

/* string? readResult;
bool validEntry = false;

Console.WriteLine("Enter a string");

do {
    readResult = Console.ReadLine();
    if(readResult != null) {
        if(readResult.Length >= 3) {
            validEntry = true;
        } else {
            Console.WriteLine("You must write atleast 3 characters. Please try again");
        }
    }
} while (validEntry == false);
 */

// Code challenge 1 task 4

/* Console.WriteLine("Please enter a whole number between 5 and 10");
 int numericValue = 0;
 bool validNumber = false;

 do {
    string? readLine = Console.ReadLine();
    validNumber = int.TryParse(readLine, out numericValue);
    if(validNumber == false) {
        Console.WriteLine("That is not a valid number! Please use whole/integer numbers. Try again...");
    }

    

    if (validNumber == true) {
        if(numericValue >= 5 && numericValue <= 10) {
            break;
        } else if (numericValue < 5 || numericValue > 10) {
            Console.WriteLine("The value you entered is either smaller than 5 or larger than 10. Please input a number between 5 and 10");
        }
    }

 } while (!validNumber || numericValue < 5 || numericValue > 10);

 Console.WriteLine("Your number has been accepted.");
 */

// Code challenge 2 task 4

/* Console.WriteLine("Enter your role name (Aministrator, Manager or User)");

bool validRole = false;

do {
   string? userInput = Console.ReadLine();
   if(userInput != null) {
    userInput = userInput.Trim().ToLower();
   }
   if(userInput  == "administrator" || userInput == "manager" || userInput == "user") {
    validRole = true;
   } else {
    Console.WriteLine($"The role you entered, \"{userInput}\" is not valid. Please input a valid answer  (Aministrator, Manager or User)");
   }



} while(!validRole);

Console.WriteLine("Your input value has been accepted."); */

// Code challenge 3 task 4

/* string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (string currentString in myStrings)
{
    int periodLocation = currentString.IndexOf(".");

    string tempString = currentString;
    string mySentence;

    while (periodLocation != -1)
    {
        mySentence = tempString.Substring(0, periodLocation);

        tempString = tempString.Substring(periodLocation + 1);
        tempString = tempString.TrimStart();

        periodLocation = tempString.IndexOf("."); 

        Console.WriteLine(mySentence);
    }

    mySentence = tempString.Trim();
    Console.WriteLine(mySentence);
} */


// GUIDED PROJECT MODULE 3

// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

    }


    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do
{

    // display the top-level menu options

    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    /*     Console.WriteLine($"You selected menu option {menuSelection}.");
        Console.WriteLine("Press the Enter key to continue");

        // pause code execution
        readResult = Console.ReadLine(); */
    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "2":
            // Add a new animal friend to the ourAnimals array
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "3":
            // Ensure animal ages and physical descriptions are complete
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "5":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        default:

            break;
    }
} while (menuSelection != "exit");