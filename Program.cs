﻿/* bool flag = true;
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
string sku = "01-MN-L";

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

Console.WriteLine($"Product: {size} {color} {type}");