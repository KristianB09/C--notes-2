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

 Console.WriteLine("Please enter a whole number between 5 and 10");
 int numericValue = 0;
 bool validNumber = false;

 do {
    string? readLine = Console.ReadLine();
    validNumber = int.TryParse(readLine, out numericValue);
    
    

 } while (validNumber == false);