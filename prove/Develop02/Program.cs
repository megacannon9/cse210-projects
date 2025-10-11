using System;
using System.IO;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // Display Main Menu loop
        bool flag = false;

        //Prompt list for later
        Prompts randomPrompts = new Prompts();
        randomPrompts._smell = "What is something that smelled good today?";
        randomPrompts._hard = "What is something diffucult you did today?";
        randomPrompts._learn = "What is something you learned form your experiences today?";
        randomPrompts._sight = "What is something you saw today?";
        randomPrompts._smile = "What is somehting that made you smile today?";

        randomPrompts._promptList.Add(randomPrompts._smell);
        randomPrompts._promptList.Add(randomPrompts._hard);
        randomPrompts._promptList.Add(randomPrompts._learn);
        randomPrompts._promptList.Add(randomPrompts._sight);
        randomPrompts._promptList.Add(randomPrompts._smile);

        List<string> entries = new List<string>();
        Entry newEntry = new Entry();
        while (flag == false)
        {
            Menu mainMenu = new Menu();
            Console.WriteLine();
            Console.WriteLine("What would you like to do today?");
            mainMenu._write = "1. Write";
            mainMenu._display = "2. Display";
            mainMenu._save = "3. Save";
            mainMenu._load = "4. Load";
            mainMenu._prompt = "5. Prompt";
            mainMenu._help = "6. Help";
            mainMenu._quit = "7. Quit";
            mainMenu.DisplayMenu();

            //If write is chosen, display a blank text box that allows the user to
            //add whatever they would like and saves it to the program.
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "write" || userInput == "1")
            {
                Console.WriteLine("Enjoy writing in your journal.");
                newEntry._entryDateTime = ""; //figure this one out later
                string userWrite = Console.ReadLine();
                newEntry._entryText = newEntry._entryDateTime + "" + userWrite;
                entries.Add(newEntry._entryText);
            }
            //If display is chosen, iterate through all entries in the journal
            else if (userInput.ToLower() == "display" || userInput == "2")
            {
                foreach (string i in entries)
                {
                    Console.WriteLine($"{i}");
                }
            }
            //If save is chosen, save the journal cache into a .txt file.
            else if (userInput.ToLower() == "save" || userInput == "3")
            {
                Console.WriteLine("Create a filename to save your journal to.");
                string userSaveFilename = Console.ReadLine() + ".txt";
                using (StreamWriter outputFile = new StreamWriter(userSaveFilename))
                {
                    foreach (string i in entries)
                    {
                        outputFile.WriteLine($"{i}");
                    }
                }
            }
            //If load is chosen, open a .txt file.
            else if (userInput.ToLower() == "load" || userInput == "4")
            {
                Console.WriteLine("Type the name of the file you are trying to load.");
                string userFilename = Console.ReadLine();
                string[] savedEntries = System.IO.File.ReadAllLines(userFilename + ".txt");
                entries.Clear();
                foreach (string entry in savedEntries)
                {
                    entries.Add(entry);
                    Console.WriteLine(entry);
                }
            
            }

            //If prompt is chosen, display a "randomly generated" 
            //prompt for them to answer about their day. 
            else if (userInput.ToLower() == "prompt" || userInput == "5")
            {
                string selectedPrompt = randomPrompts.GeneratePrompt();
                Console.WriteLine(selectedPrompt);
                newEntry._entryDateTime = ""; //figure this one out later
                string userWrite = Console.ReadLine();
                newEntry._entryText = newEntry._entryDateTime + "" + userWrite;
                entries.Add(newEntry._entryText);
            }
            //If help is chosen, display a list of available commands
            else if (userInput.ToLower() == "help" || userInput == "6")
            {
                Console.WriteLine("Available commands are:");
                Console.WriteLine("Write- Use this command to input a journal entry.");
                Console.WriteLine("Display- Use this command to display any journals made in this session.");
                Console.WriteLine("Save- Use this command to save your journal to a text file. (You don't need to add '.txt' to your filename)");
                Console.WriteLine("Load- use this command to load a text file.");
                Console.WriteLine("Prompt- Use this command to generate a random prompt for you to write your day about.");
                Console.WriteLine("Quit- Use this command to end the program.");
                Console.WriteLine("You can also use the number associated with each command to use it.");
            }

            //If quit is chosen, end the program.
            else if (userInput.ToLower() == "quit" || userInput == "7")
            {
                flag = true;
            }

            //If nothing is picked correctly display error message
            else
            {
                Console.WriteLine("That was not a valid input. Type 'help' or '6' for available commands.");
            }

        }    
    }
}