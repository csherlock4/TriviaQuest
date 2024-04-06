using System;
using System.Collections.Generic;

public class TriviaGame
{
    
    private class Question
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

    private readonly List<Question> questions = new List<Question>();

    public TriviaGame()
    {
        AddQuestions();
    }

private void AddQuestions()
{
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

}


public void Play()
    {
        Console.WriteLine("As you embark on your journey, you come across a troll who will let you pass only if you answer its questions correctly.\n");

        int score = PlaySection(0, 4); // troll section

        if (score >= 3)
        {
            Console.WriteLine("The troll, impressed by your knowledge, allows you to pass.\n");
            Console.WriteLine("You now face the wizard, who has more challenging questions for you.\n");

            int additionalScore = PlaySection(4, questions.Count);
            score += additionalScore;
            
            Console.WriteLine($"Overall, you answered {score} out of {questions.Count} questions correctly.");

            if (additionalScore == questions.Count - 4) // check score
            {
                Console.WriteLine("Impressed by your knowledge, the wizard allows you to proceed on your journey with his blessing.");
            }
            else
            {
                Console.WriteLine("The wizard, though slightly disappointed, allows you to pass but reminds you to brush up on your magical knowledge.");
            }
        }
        else
        {
            Console.WriteLine("The troll, disappointed by your lack of knowledge, does not allow you to pass. Better luck next time!");
        }
    }

    private int PlaySection(int startQuestion, int endQuestion)
    {
        int sectionScore = 0;

        for (int i = startQuestion; i < endQuestion; i++)
        {
            var question = questions[i];
            Console.WriteLine(question.Text);
            foreach (var option in question.Options)
            {
                Console.WriteLine($"{option.Key}. {option.Value}");
            }

            string answer = Console.ReadLine().ToUpper();

            if (question.CorrectLetter == answer)
            {
                Console.WriteLine("Correct!");
                sectionScore++;
            }
            else
            {
                Console.WriteLine($"Incorrect. The correct answer is: {question.CorrectLetter}) {question.CorrectText}");
            }
        }

        return sectionScore;
    }

    public static void Main(string[] args)
    {
        TriviaGame game = new TriviaGame();
        game.Play();
    }
}
