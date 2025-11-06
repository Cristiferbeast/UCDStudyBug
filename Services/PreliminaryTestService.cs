using StudyBuddy.Models;
using System;

namespace StudyBuddy.Services
{
    public class PreliminaryTestService
    {
        private List<Models.PreliminaryQuestion> _questions = new();
        private Random _random = new Random();


        public PreliminaryTestService()
        {
            InitializeChemistryQuestions();
        }

        public List<PreliminaryQuestion> GetAllQuestions()
        {
            return _questions;
        }

        // NEW METHOD: Get questions in random order
        public List<PreliminaryQuestion> GetShuffledQuestions()
        {
            // Create a copy of the list so we don't modify the original
            var shuffled = new List<PreliminaryQuestion>(_questions);

            // Fisher-Yates shuffle algorithm
            int n = shuffled.Count;
            while (n > 1)
            {
                n--;
                int k = _random.Next(n + 1);
                var temp = shuffled[k];
                shuffled[k] = shuffled[n];
                shuffled[n] = temp;
            }

            return shuffled;
        }

        private void InitializeChemistryQuestions()
        {
            // Sample 23 chemistry questions - you can customize these!
            _questions = new List<Models.PreliminaryQuestion>
            {
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Molecules and Molecular Transformations",
                    QuestionText = "If given that the radius of 1 atom of Hydrogen is 120pm what would be the covalent bond length of a H2 Bond in cm",
                    Options = new List<string> { 
                        "1.2*10^10",
                        "1.2*10^-10",
                        "1.2*10^-8",
                        "1.2*10^8"
                    },
                    CorrectAnswerIndex = 3,
                    CloseAnswerIndexes = new List<int> { 2,4 } // 12 is the mass number, close but not correct
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Counting of Molecules, Concentrations",
                    QuestionText = "You are given 68.97 grams of Na and 70.9 grams of Cl how many grams of resulting Salt would approximately be produced by this reaction",
                    Options = new List<string> { 
                        "116.88",
                        "56",
                        "58.44",
                        "175.32" 
                    },
                    CorrectAnswerIndex = 3,
                    CloseAnswerIndexes = new List<int> { 4 } // Hydrogen bonds are related
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Acids and Bases",
                    QuestionText = "You are given a 10g Solution that is 6% Hydrogen by Mass with the rest of the solution being made out of Oxygen, what would be the pH of this mixture?",
                    Options = new List<string> { 
                        "13.94",
                        "0.19",
                        "1.9",
                        "8.9"
                    },
                    CorrectAnswerIndex = 3,
                    CloseAnswerIndexes = new List<int> { 1 } // Halogens are next to noble gases
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Gases",
                    QuestionText = "A scientist has a tube of Oxygen Gas at 27C, if given that R = 8.31 what is the approximate value of the average speed of One Molecule of Oxygen Gas.",
                    Options = new List<string> {
                        "400",
                        "6.5*10^2",
                        "500",
                        "4.4 *10^2"
                    },
                    CorrectAnswerIndex = 4,
                    CloseAnswerIndexes = new List<int> {1 }
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Chemical Kinetics",
                    QuestionText = "A scientist is watching the decomposition of C6H5N2Cl + H20 -> C6H5OH + HCL + N2; during the progress of the experiment the scientist notes the volume of H20 remains nearly constant, what kind of Kinetics would this be? ",
                    Options = new List<string> { 
                        "First Order",
                        "Pseudo First Order",
                        "Second Order",
                        "Pseudo Second Order" 
                    },
                    CorrectAnswerIndex = 2,
                    CloseAnswerIndexes = new List<int> { }
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Thermodynamics",
                    QuestionText = "How much energy would be required to move 3 sodium ions (Na+) out of a cell membrane that has an internal Na+ Concentration of 10mM and a external concentration of 145mM with a membrane potential of -70mV at 17*C. Gas Constant = 8.314 ",
                    Options = new List<string> { 
                        "6.8*10^-20 J",
                        "6.8*10^-20 KJ",
                        "3.4*10^-20 J",
                        "3.4*10*-20 KJ" 
                    },
                    CorrectAnswerIndex = 1,
                    CloseAnswerIndexes = new List<int> { 2 }
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "VSPER",
                    QuestionText = "Consider the Molecular Geometry of SF4, what would be the angle lengths present?",
                    Options = new List<string> { 
                        "109.5", 
                        "90", 
                        "107",
                        "102 and 173" 
                    },
                    CorrectAnswerIndex = 4,
                    CloseAnswerIndexes = new List<int> { }
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Oxidation and Reduction Reactions",
                    QuestionText = "In the Reaction H202 + 2F2 -> OF2 + 2HF; consider the change in oxidation on the oxygen, from left to right what change is it undergoing and by what value",
                    Options = new List<string> {
                        "Oxidation of 3 ", 
                        "Reduction of 3 ",
                        "Oxidation of 1",
                        "Reduction of 1",
                        "Spectator Ion"
                    },
                    CorrectAnswerIndex = 1,
                    CloseAnswerIndexes = new List<int> { 2 }
                }
            };
        }

        public int CalculatePoints(TimeSpan timeTaken, bool isCorrect, bool isClose)
        {
            var seconds = timeTaken.TotalSeconds;

            if (seconds < 60)
            {
                if (isCorrect) return 125;
                if (isClose) return 60;
                return 0;
            }
            else if (seconds < 120)
            {
                if (isCorrect) return 100;
                if (isClose) return 50;
                return 0;
            }
            else if (seconds < 300) // 5 minutes
            {
                if (isCorrect) return 90;
                if (isClose) return 45;
                return 0;
            }
            else
            {
                if (isCorrect) return 70;
                if (isClose) return 35;
                return 0;
            }
        }

        public AnswerResult DetermineAnswerResult(TimeSpan timeTaken, bool isCorrect, bool isClose)
        {
            var seconds = timeTaken.TotalSeconds;

            if (seconds < 20)
            {
                return isCorrect ? AnswerResult.VeryQuickCorrect :
                       isClose ? AnswerResult.VeryQuickClose : AnswerResult.Wrong;
            }
            else if (seconds < 60)
            {
                return isCorrect ? AnswerResult.QuickCorrect :
                       isClose ? AnswerResult.QuickClose : AnswerResult.Wrong;
            }
            else if (seconds < 300)
            {
                return isCorrect ? AnswerResult.NormalCorrect :
                       isClose ? AnswerResult.NormalClose : AnswerResult.Wrong;
            }
            else
            {
                return isCorrect ? AnswerResult.SlowCorrect :
                       isClose ? AnswerResult.SlowClose : AnswerResult.Wrong;
            }
        }
    }
}