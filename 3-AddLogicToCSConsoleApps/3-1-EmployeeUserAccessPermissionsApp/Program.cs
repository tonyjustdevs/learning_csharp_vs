Console.WriteLine("");
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("--- Welcome to Tony's Employee-User-Permissions App ---");
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("");
//////////////////////// START PROGRAM ////////////////////////

// ref: https://learn.microsoft.com/en-us/training/modules/csharp-evaluate-boolean-expressions/6-challenge-2

/*  
You will need to use the Contains() helper method  to determine whether the value 
assigned to the permission string contains one of the permission values specified 
by the "business rules". 
  For example, the expression permission.Contains("Admin")
  will return true when using the initial data values specified in the code above. 

Business Rules:
  user: "Admin"   &&  level > 55    ->  "Welcome, Super Admin user."
  user: "Admin"   &&  level <= 55,  ->  "Welcome, Admin user"
  user: "Manager"  &&  level >= 20, ->  "Contact an Admin for access."
  user: "Manager"  &&  level < 20,  ->  "You do not have sufficient privileges."
  user: !("Admin" || "Manager")     ->  "You do not have sufficient privileges."

#TODO:
#Task 1: "...the initial configuration data..."
    "Welcome, Admin user"
#Task 2: "...Test for the other business rules..."

#Example Snippet
string role = "Editor";
string permissions = role == "Admin"
    ? "Full access"
    : role == "Editor"
        ? "Edit access"
        : role == "Viewer"
            ? "View-only access"
            : "No access";

Console.WriteLine(permissions); // Outputs: Edit access

*/

//////////////////////// 1. PARAMS ////////////////////////////
// string permission = "Admin|Manager";   // starter-code
int level = 55;                           // starter-code
string permission = "Admin";              // initial-configuration

// [RULE] permission: "Admin"   &&  level > 55    ->  "Welcome, Super Admin user."
// permission = "Admin"; level = 420;
// System.Console.WriteLine("Expected: 'Welcome, Super Admin user.'");

// [RULE] permission: "Admin"   &&  level <= 55,  ->  "Welcome, Admin user"
// permission = "Admin"; level = 33;
// System.Console.WriteLine("Expected: 'Welcome, Admin user'");

// [RULE] permission: "Manager"  &&  level >= 20, ->  "Contact an Admin for access."
// permission = "Manager"; level = 20;
// System.Console.WriteLine("Expected: 'Contact an Admin for access.'");

// [RULE] permission: "Manager"  &&  level < 20,  ->  "You do not have sufficient privileges."
// permission = "Manager"; level = 19;
// System.Console.WriteLine("Expected: 'You do not have sufficient privileges.'");

// [RULE] permission: !("Admin" || "Manager")     ->  "You do not have sufficient privileges."
// permission = "Hacker"; level = 69;
// System.Console.WriteLine("Expected: 'You do not have sufficient privileges.'");

// [RULE] permission: !("Admin" || "Manager")     ->  "You do not have sufficient privileges."
// permission = "Admin "; level= 100;
// System.Console.WriteLine("Expected: 'You do not have sufficient privileges.'");


// static params
string output = "Something went wrong!";

//////////////////////// 2. METHODS ///////////////////////////
if (permission=="Admin")
{
  if (level > 55)
  {
    output = "Welcome, Super Admin user";
  } else
  {
    output = "Welcome, Admin user";;
  }
} else if (permission=="Manager")
{
  if (level >= 20)
  {
    output = "Contact an Admin for access.";
  } else
  {
    output = "You do not have sufficient privileges.";
  }
} else
{
  output = "You do not have sufficient privileges.";
}
// permission: "Admin"   &&  level > 55    ->  "Welcome, Super Admin user."
// permission: "Admin"   &&  level <= 55,  ->  "Welcome, Admin user"
// permission: "Manager"  &&  level >= 20, ->  "Contact an Admin for access."
// permission: "Manager"  &&  level < 20,  ->  "You do not have sufficient privileges."
// permission: !("Admin" || "Manager")     ->  "You do not have sufficient privileges."

//////////////////////// 3. OUTPUT ////////////////////////////
System.Console.Write(output);
System.Console.WriteLine($"\t(permission: {permission}, level:{level})");




//////////////////////// END PROGRAM //////////////////////////
Console.WriteLine("");
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("--- Leaving Tony's Employee-User-Permissions App ------");
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("");

