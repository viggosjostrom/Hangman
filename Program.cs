using System.ComponentModel.DataAnnotations;

Console.WriteLine("Välj ett genererat ord i listan genom att skriva in respektive siffra");
string[] words = File.ReadAllLines("../../../words.txt");
int number = 1;
foreach (string line in words) // printar ut alla lines
{
    
    
    Console.WriteLine(number +". " + line);
    number++;
   
    

}


Random rnd = new Random();
int userChoice = rnd.Next(6);





string word = string.Empty;



if (userChoice != 1 && userChoice == 2 && userChoice == 3 && userChoice == 4 && userChoice == 5)
{
    Console.WriteLine("Fel inmatning");
   
}
if (userChoice == 1)
{
    word = words[0];
}
if (userChoice == 2)
{
    word = words[1];
}
if (userChoice == 3)
{
    word = words[2];
}
if (userChoice == 4)
{
    word = words[3];
}
if (userChoice == 5)
{
    word = words[4];
}
if (userChoice == 6)
{
    word = Console.ReadLine();
}



while (word.Length == 0)
{
    Console.WriteLine("Var vänlig och välj en siffra.");
   


}
var currentGuess = string.Empty;

while (currentGuess.Length < word.Length)
{

    currentGuess = currentGuess + "_";
}

var lives = 10;
var hasWon = false;



while (lives > 0 && !hasWon)
{
    Console.Clear();
    Console.WriteLine(currentGuess);
    Console.WriteLine("current lives: " + lives);
    Console.Write("Please enter a letter as a guess: ");
    var guess = Console.ReadLine().ToLower();
    var guessWasRight = false;

    if (guess == word)
    {
        hasWon = true;
        Console.WriteLine("You have won!");
        // om gissningen är samma som ordet så har vi vunnit (ändra så att while loopen avbryts genom att "hasWon" ska bli true.
        // annars går vi ner till "else" och kör loopen för att hitta bokstäver

    }
    else
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (guess == word[i].ToString())
            {
                currentGuess = currentGuess.Remove(i, 1).Insert(i, guess);
                guessWasRight = true;
            }
        }
        if (!guessWasRight)
        {
            lives--;
            if (lives == 0)
            {
                Console.WriteLine("You have lost!");
            }
        }
        if (currentGuess == word) 
        {
            hasWon = true; // om vi har börjat fylla på med bokstäver men sen gissar hela ordet så ska loopen avbrytas genom hasWon blir true
            currentGuess = word; 
            Console.WriteLine("You have won!");
        }




    }
}


