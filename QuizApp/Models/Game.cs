using System;
using System.Collections.Generic;

namespace QuizApp.Models
{
    public class Game
    {
        public Game()
        {
            Random random = new Random();

            while (AvailableQuestions.Count > 0)
            {
                int index = random.Next(AvailableQuestions.Count);
                QuestionsToBeAsked.Enqueue(AvailableQuestions[index]);
                AvailableQuestions.RemoveAt(index);

                if (QuestionsToBeAsked.Count == 15)
                {
                    break;
                }
            }
        }

        public string PlayerName { get; set; } = "Foxey";
        public int LevelAchieved { get; set; }
        public bool RightAnswerIsChosen { get; set; } = false;
        public bool PhoneHelpIsAvailable { get; set; } = true;
        public bool AudienceHelpIsAvailable { get; set; } = true;
        public bool HalferHelpIsAvailable { get; set; } = true;
        public Question ActualQuestion { get; set; }
        public Queue<Question> QuestionsToBeAsked { get; set; } = new Queue<Question>();
        public List<Question> AvailableQuestions { get; set; } = new List<Question>()
        {
            new Question()
            {
                Text = "What instrument does Kriszta Csere play?",
                Answer1 = "flute",
                Answer2 = "piano",
                Answer3 = "guitar",
                Answer4 = "shamisen"
            },
            new Question()
            {
                Text = "What is Papp Kriszti's hobby?",
                Answer1 = "books",
                Answer2 = "running marathons",
                Answer3 = "knitting",
                Answer4 = "films"
            },
            new Question()
            {
                Text = "What was Magdalena Dzsindzsisz's job for 14 years?",
                Answer1 = "working for Index",
                Answer2 = "postman",
                Answer3 = "cook",
                Answer4 = "officer at agriculture ministry"
            },
            new Question()
            {
                Text = "What kind of pets does Nezih Ozsarac have?",
                Answer1 = "2 dogs",
                Answer2 = "3 rats",
                Answer3 = "1 parrot",
                Answer4 = "1 cameloen"
            },
            new Question()
            {
                Text = "What kind of language does Zsombor Bencsik speak?",
                Answer1 = "finnish",
                Answer2 = "chinese",
                Answer3 = "german",
                Answer4 = "slovak"
            },
            new Question()
            {
                Text = "Where did Marton Szekely live?",
                Answer1 = "Russia",
                Answer2 = "US",
                Answer3 = "Cambodia",
                Answer4 = "Austria"
            },
            new Question()
            {
                Text = "What kind of instrument did Agi Kassai play?",
                Answer1 = "8 years, violin",
                Answer2 = "2 years, piano",
                Answer3 = "6 years, double bass",
                Answer4 = "half a year, trumpet"
            },
            new Question()
            {
                Text = "What is the name of Laszlo Papp's dog?",
                Answer1 = "Chewbacca",
                Answer2 = "Marilyn Mason",
                Answer3 = "Gyere ide",
                Answer4 = "Cica"
            },
            new Question()
            {
                Text = "How does Laszlo Szelecsenyi commute?",
                Answer1 = "by bicycle",
                Answer2 = "takes the tram",
                Answer3 = "gets a taxi",
                Answer4 = "scooter"
            },
            new Question()
            {
                Text = "What is the hobby of Adam Suki?",
                Answer1 = "kendama",
                Answer2 = "biochemistry",
                Answer3 = "collects stamps",
                Answer4 = "collects atique books"
            },
            new Question()
            {
                Text = "Where did Attila Kezer live?",
                Answer1 = "England",
                Answer2 = "Malta",
                Answer3 = "Szamosveresmart",
                Answer4 = "Stockholm"
            },
            new Question()
            {
                Text = "What kind of pet does Attila Korom have?",
                Answer1 = "a pug",
                Answer2 = "a chihuahua",
                Answer3 = "a dalmatian",
                Answer4 = "an argentine dog"
            },
            new Question()
            {
                Text = "What does Peter Keller like to cook?",
                Answer1 = "spaghetti",
                Answer2 = "beef wellington",
                Answer3 = "scrambled eggs",
                Answer4 = "instant soup"
            },
            new Question()
            {
                Text = "What kind of pet did Luca Nagy have?",
                Answer1 = "a horse for 20 years",
                Answer2 = "a cat who is 5 year old",
                Answer3 = "a dog for 10 years",
                Answer4 = "hamster for 4 years"
            },
            new Question()
            {
                Text = "What kind of sport did Szigeti Tamara do?",
                Answer1 = "jujitsu for 5 years",
                Answer2 = "watersurfing every summer",
                Answer3 = "kungfu for 3 years",
                Answer4 = "water ballet for 12 years"
            },
            new Question()
            {
                Text = "What is a true statement about Alex Toth?",
                Answer1 = "he lived in five countries in five years",
                Answer2 = "he does extreme sports",
                Answer3 = "his favorite film is PS I love you",
                Answer4 = "he has a rock band"
            },
            new Question()
            {
                Text = "What is Barna Benko's job?",
                Answer1 = "transportation engineer",
                Answer2 = "operator at jazmin.com",
                Answer3 = "music teacher",
                Answer4 = "tax revisor"
            },
            new Question()
            {
                Text = "What is Reka Garamvolgyi favourite animal?",
                Answer1 = "horse",
                Answer2 = "turtle",
                Answer3 = "cat",
                Answer4 = "butterfly"
            },
            new Question()
            {
                Text = "What is Gyula Nemes zodiac sign?",
                Answer1 = "aries",
                Answer2 = "scorpio",
                Answer3 = "gemini",
                Answer4 = "sagittarius"
            },
            new Question()
            {
                Text = "What is Albert Bach’s dog’s breed?",
                Answer1 = "french bulldog",
                Answer2 = "vizsla",
                Answer3 = "doberman",
                Answer4 = "golden retriever"
            },
            new Question()
            {
                Text = "What kind of sport Andras Krausz does?",
                Answer1 = "karate",
                Answer2 = "cheerleading",
                Answer3 = "ballet",
                Answer4 = "pilates"
            },
            new Question()
            {
                Text = "How many children Akos Mate has?",
                Answer1 = "2",
                Answer2 = "0",
                Answer3 = "1",
                Answer4 = "3"
            },
            new Question()
            {
                Text = "What kind of animal Peter Berto keep at home?",
                Answer1 = "leopard gecko",
                Answer2 = "baby tiger",
                Answer3 = "white lion",
                Answer4 = "jaguar"
            },
            new Question()
            {
                Text = "Where does Tatyjana Nagyne Faklijer live?",
                Answer1 = "Veresegyhaza",
                Answer2 = "Szeged",
                Answer3 = "Sopron",
                Answer4 = "Budapest"
            },
            new Question()
            {
                Text = "What project Krisztian Szucs working on at Huli?",
                Answer1 = "selection",
                Answer2 = "student-hapiness-management",
                Answer3 = "student-checkout-management",
                Answer4 = "student-management-event-service"
            },
            new Question()
            {
                Text = "What sport Kristof Zagon would like to start?",
                Answer1 = "windsurfing",
                Answer2 = "air yoga",
                Answer3 = "swimming",
                Answer4 = "sleeping"
            },
            new Question()
            {
                Text = "What is Lorand Szilagyi favourite soup?",
                Answer1 = "meat soup",
                Answer2 = "instant soup",
                Answer3 = "polip soup",
                Answer4 = "stone soup"
            },
            new Question()
            {
                Text = "Did Balazs Korbuly buy bitcoin?",
                Answer1 = "not, but he really sorry about that",
                Answer2 = "sure",
                Answer3 = "a lot",
                Answer4 = "not, and he didn’t want"
            },
            new Question()
            {
                Text = "What was Gergo Toth’s kindergarten sign?",
                Answer1 = "domino",
                Answer2 = "laser sword",
                Answer3 = "were-wolf",
                Answer4 = "car"
            },
            new Question()
            {
                Text = "What is the github username of  Balazs Bognar?",
                Answer1 = "CarrotTheHero",
                Answer2 = "balazsbognar",
                Answer3 = "balazsbognar17",
                Answer4 = "bazsigithub"
            },
            new Question()
            {
                Text = "What is Evelin Hlacsok favourite movie?",
                Answer1 = "Lost in translation",
                Answer2 = "101 dalmatians",
                Answer3 = "The ring",
                Answer4 = "The ring 2"
            },
            new Question()
            {
                Text = "When Csilla Varga had braces?",
                Answer1 = "at university",
                Answer2 = "still has",
                Answer3 = "at primary school",
                Answer4 = "never had"
            },
            new Question()
            {
                Text = "What game Tamas Deak play the most at Green Fox?",
                Answer1 = "WoW",
                Answer2 = "Fifa",
                Answer3 = "Pre2",
                Answer4 = "Super Mario"
            },
            new Question()
            {
                Text = "What game Tamas Deak play the most at Green Fox?",
                Answer1 = "WoW",
                Answer2 = "Fifa",
                Answer3 = "Pre2",
                Answer4 = "Super Mario"
            },
        };
        public bool IsWon { get; set; } = false;
        public bool IsOver { get; set; } = false;
        public int PhoneHelpResult { get; set; }
        public int AudienceHelpResult { get; set; }
    }
}
