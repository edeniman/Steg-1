
//en if-sats
if (6 > 3)
{
Console.WriteLine("Hello world");
}
Console.ReadLine(); 



//Username. 
Console.WriteLine("Write Username:");
string name;

name= Console.ReadLine();
string Username= "kalleanka";

if (Username == name)
{
    Console.WriteLine("Welcome");
}
else
{
    Console.WriteLine("Incorrect, try again!");
}
Console.ReadLine();



// Username + Password
string lösenord = "12345";
string password;
password= Console.ReadLine();

if (lösenord == password){
    Console.WriteLine("Welcome + username");
}
else
{
    Console.WriteLine("Wrong username or password!");
}
Console.ReadLine();


//for loop
int gånger = 0;
for (gånger<32); 
{
    Console.WriteLine("Hello World");
    gånger++;
}
Console.ReadLine();

//while loop
string password = "";
while password != "12345"; 
{
    System.Console.WriteLine("Incorrect password. Try again!");
    Console.ReadLine();
}



//loop körs 5 gånger
for (int i = 0; i < 5; i++) 
{
    Console.Write("Please enter a number: ");
    string input = Console.ReadLine();
            
    int number;
    if (int.TryParse(input, out number)) 
    {
        if (number > 5) 
        {
            Console.WriteLine("högre än 5!");
        }
    }
}



// loop som körs så länge användaren skriver in en string
string input;
        int number;

        do 
        {
            Console.Write("skriv ett tal: ");
            input = Console.ReadLine();

            if (!int.TryParse(input, out number)) 
            {
                Console.WriteLine("Ogiltig inmatning!");
            }

        } 
        while (!int.TryParse(input, out number)); 
        {
            Console.WriteLine($"Du angav ett giltigt nummer: {number}");
        }



//slutövning - gissa sifffran
    {
        int targetNumber = new Random().Next(1, 100);
        int userGuess;

        Console.WriteLine("Gissa ett nummermellan 1 och 100:");

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out userGuess))
            {
                if (userGuess < targetNumber) Console.WriteLine("För låg!");
                else if (userGuess > targetNumber) Console.WriteLine("För hög!");
                else
                {
                    Console.WriteLine("Grattis! exakt rätt!");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning, försök igen!");
            }
        }
    }

   











