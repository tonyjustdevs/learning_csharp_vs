Console.WriteLine("");
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("--- Welcome to Tony's Employee-User-Permissions App ---");
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("");
//////////////////////// START PROGRAM ////////////////////////

// ref: https://learn.microsoft.com/en-us/training/modules/csharp-evaluate-boolean-expressions/6-challenge-2
// tip: To sufficiently test all of the combinations for permission and level

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
string permission = "Admin|Manager";  // starter-code
int level = 55;                       // starter-code

//////////////////////// 2. METHODS ///////////////////////////

//////////////////////// 3. OUTPUT ////////////////////////////






//////////////////////// END PROGRAM //////////////////////////
Console.WriteLine("");
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("--- Leaving Tony's Employee-User-Permissions App ------");
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("");

