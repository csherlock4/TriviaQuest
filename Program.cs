/*
* File Name: Program.cs
* Author: Cassandra Sherlock and Sam Clark
* Date Created: March 27, 2024
* Last Modified: April 10, 2024
* Description : A C# console-based game, where mystical creatures test the players trivia knowledge. 
*/
using System;
using System.Collections.Generic;

public class Question
{
    public string Text { get; set; }
    public Dictionary<string, string> Options { get; set; }
    public string CorrectLetter { get; set; }
    public string CorrectText { get; set; }

    public Question(string text, Dictionary<string, string> options, string correctLetter, string correctText)
    {
        Text = text;
        Options = options;
        CorrectLetter = correctLetter.ToUpper();
        CorrectText = correctText;
    }
}

public class TriviaGame
{
    private readonly List<Question> questions = new List<Question>();

    private void AddQuestions()
    {
//------Troll-------------------------------------------------------------------------------//
    questions.Add(new Question(
        "Which pepper is the hottest?",
        new Dictionary<string, string>
        {
            { "A", "Pepper X"},
            { "B", "Caroline Reaper" },
            { "C", "Bhut Jolokia" },
            { "D", "Trinidad Scorpion" }
        },
        "A", "Pepper X"));  

    questions.Add(new Question(
        "Mount Everest is found in which mountain range?",
        new Dictionary<string, string>
        {
            { "A", "The Alps" },
            { "B", "The Rocky Mountains" },
            { "C", "The Himalayas" },
            { "D", "The Andes" }
        },
        "C", "The Himalayas"));

    questions.Add(new Question(
        "What is the collective name for a group of crows?",
        new Dictionary<string, string>
        {
            { "A", "Pack" },
            { "B", "Murder" },
            { "C", "Flock" },
            { "D", "Gaggle" }
        },
        "B", "Murder"));

    questions.Add(new Question(
        "What is the max slope angle an average mountain goat can walk on?",
        new Dictionary<string, string>
        {
            { "A", "Less than 10" },
            { "B", "10 - 30 degrees" },
            { "C", "30 - 60 degrees" },
            { "D", "60 - 80 degree" }
        },
        "D", "60 - 80 degrees"));

//------Wizard------------------------------------------------------------------------------//
	 questions.Add(new Question(
        "Which of these items was NOT a prop used by Harry Houdini?",
        new Dictionary<string, string>
        {
            { "A", "Handcuffs" },
            { "B", "Water tanks" },
            { "C", "Straightjackets" },
            { "D", "Magic Wands" }
        },
        "D", "Magic Wands"));

    questions.Add(new Question(
        "In mythology, what is the name of King Arthur’s sword?",
        new Dictionary<string, string>
        {
            { "A", "Excalibur" },
            { "B", "Mjolnir" },
            { "C", "Glamdring" },
            { "D", "Anduril" }
        },
        "A", "Excalibur"));

    questions.Add(new Question(
        "What is the term for a magical symbol used to invoke spirits or powers?",
        new Dictionary<string, string>
        {
            { "A", "Enchantment" },
            { "B", "Hex" },
            { "C", "Sigil" },
            { "D", "Talisman" }
        },
        "C", "Sigil"));

    questions.Add(new Question(
        "Which wizard is a prominent character in J.R.R. Tolkien’s legendarium?",
        new Dictionary<string, string>
        {
            { "A", "Albus Dumbledore" },
            { "B", "Merlin" },
            { "C", "Gandalf" },
            { "D", "Volo" }
        },
        "C", "Gandalf"));

//------Sphinx------------------------------------------------------------------------------//
    questions.Add(new Question(
        "Who was the first emperor of Rome?",
        new Dictionary<string, string>
        {
            { "A", "Julius Caesar" },
            { "B", "Caligula" },
            { "C", "Nero" },
            { "D", "Augustus" }
        },
        "D", "Augustus"));

    questions.Add(new Question(
        "Who discovered the Americas in 1492?",
        new Dictionary<string, string>
        {
            { "A", "Christopher Columbus" },
            { "B", "Vasco da Gama" },
            { "C", "Marco Polo" },
            { "D", "Ferdinand Magellan" }
        },
        "A", "Christopher Columbus"));

    questions.Add(new Question(
        "Who was the first female ruler of Egypt known by name?",
        new Dictionary<string, string>
        {
            { "A", "Cleopatra" },
            { "B", "Nefertiti" },
            { "C", "Hatshepsut" },
            { "D", "Sobekneferu" }
        },
        "C", "Hatshepsut"));

    questions.Add(new Question(
        "The Magna Carta was signed in which year?",
        new Dictionary<string, string>
        {
            { "A", "1487" },
            { "B", "1320" },
            { "C", "1066" },
            { "D", "1215" }
        },
        "D", "1215"));

//------Serpent-----------------------------------------------------------------------------//
    questions.Add(new Question(
        "What species of fish live deepest in the ocean?",
        new Dictionary<string, string>
        {
            { "A", "Cuttlefish" },
            { "B", "Goldfish" },
            { "C", "Anglerfish " },
            { "D", "Tuna" }
        },
        "C", "Anglerfish"));
    
    questions.Add(new Question(
        "Which is the largest ocean on Earth?",
        new Dictionary<string, string>
        {
            { "A", "Atlantic" },
            { "B", "Pacific" },
            { "C", "Arctic" },
            { "D", "Indian" }
        },
        "B", "Pacific"));

    questions.Add(new Question(
        "Which reddish-brown color gets its name from a pigment extracted from cuttlefish?",
        new Dictionary<string, string>
        {
            { "A", "Sienna" },
            { "B", "Sepia" },
            { "C", "Umber" },
            { "D", "Ochre" }
        },
        "B", "Sepia"));

    questions.Add(new Question(
        "The deepest known point in the world's oceans is called what?",
        new Dictionary<string, string>
        {
            { "A", "Atlantic Trench" },
            { "B", "Arctic Trench" },
            { "C", "Mariana Trench" },
            { "D", "Pacific Trench" }
        },
        "C", "Mariana Trench"));

//------Elder God---------------------------------------------------------------------------// These are placeholders, need to add space questions.
    questions.Add(new Question(
        "What is the largest known structure in the observable universe?",
        new Dictionary<string, string>
        {
            { "A", "The Milky Way Galaxy" },
            { "B", "The Great Wall of Andromeda" },
            { "C", "Hercules-Corona Borealis Great Wall" },
            { "D", "UY Scuti" }
        },
        "C", "Hercules-Corona Borealis Great Wall"));
    
    questions.Add(new Question(
        "How many moons does Jupiter have?",
        new Dictionary<string, string>
        {
            { "A", "0" },
            { "B", "3" },
            { "C", "1" },
            { "D", "92" }
        },
        "D", "92"));

    questions.Add(new Question(
        "What is the main component of the fuel that powers stars?",
        new Dictionary<string, string>
        {
            { "A", "Helium" },
            { "B", "Hydrogen" },
            { "C", "Oxygen" },
            { "D", "Carbon" }
        },
        "B", "Hydrogen"));

    questions.Add(new Question(
        "What color is the sunset on Mars?",
        new Dictionary<string, string>
        {
            { "A", "Red" },
            { "B", "Yellow" },
            { "C", "Blue" },
            { "D", "Green" }
        },
        "C", "Blue"));
}

    public void Play()
    {
        Console.WriteLine("As you embark on your journey, you come across a mystical being at each turn, challenging your knowledge to let you pass.\n");

        if (!PlaySection(0, 4, "troll"))
        {
            Console.WriteLine("Sadly, you did not pass the troll's challenge. Better luck next time!");
            return; // Stops the game
        }

        Console.WriteLine("You now face the wizard, who has more challenging questions to test your arcane knowledge.\n");
        if (!PlaySection(4, 8, "wizard"))
        {
            Console.WriteLine("Sadly, you did not pass the wizard's challenge. Better luck next time!");
            return; // Stops the game
        }

        Console.WriteLine("Having impressed the wizard, you find yourself before a Sphinx, a more formidable foe! It poses questions of history and lore.\n");
        if (!PlaySection(8, 12, "Sphinx"))
        {
            Console.WriteLine("Sadly, you did not pass the Sphinx's challenge. Better luck next time!");
            return; // Stops the game
        }

        Console.WriteLine("With the Sphinx satisfied, you venture onward, stopping at a beach, a large sea serpant towers out of the water staring down at you.\n");
        if (!PlaySection(12, 16, "Sea Serpant"))
        {
            Console.WriteLine("Sadly, you did not pass the Sea Serpant's challenge. Better luck next time!");
            return; // Stops the game
        }

        Console.WriteLine("Having impressed the Serpant, you ascend to the heavens with your new found knowldge. Unfortunatly you find yourself before an Elder God, you feel insignificant now.\n");
        if (!PlaySection(16, 20, "Elder God"))
        {
            Console.WriteLine("Sadly, you did not pass the Elder God's challenge. There will be no 'next time'!"); 
            return; // Stops the game
        }

        // If the player passes all sections.
        Console.WriteLine("Impressed by your vast knowledge, the mystical beings allow you to proceed on your journey with their blessings.");
    }

    private bool PlaySection(int startQuestion, int endQuestion, string guardian)
    {
        Console.WriteLine($"This {guardian} will let you pass only if you answer its questions correctly.\n");
        
        int score = 0;
        for (int i = startQuestion; i < endQuestion; i++)
        {
            var question = questions[i];
            Console.WriteLine(question.Text);
            foreach (var option in question.Options)
            {
                Console.WriteLine($"{option.Key}. {option.Value}");
            }

            Console.Write("Your answer: ");
            string answer = Console.ReadLine().ToUpper();

            if (question.CorrectLetter == answer)
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect. The correct answer is: {question.CorrectLetter}) {question.CorrectText}\n");
            }
        }

        if (score >= 3)
        {
            Console.WriteLine($"The {guardian}, impressed by your knowledge, allows you to pass.\n");
            return true;
        }
        else
        {
            Console.WriteLine($"The {guardian}, disappointed by your lack of knowledge, does not allow you to pass.\n");
            return false;
        }
    }

    public static void Main(string[] args)
    {
        TriviaGame game = new TriviaGame();
        game.AddQuestions();
        game.Play();
    }
}