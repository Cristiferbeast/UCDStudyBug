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
            _questions = new List<Models.PreliminaryQuestion>
            {
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Bonding (Lewis Structures and Electron Configurations)",
                    QuestionText = "Considering ICl4- What would be the number of lone pairs on the Iodine",
                    Options = new List<string> {
                        "0, all single bonds",
                        "0, 1 double bond",
                        "1, all single bonds",
                        "2, all single bonds",
                        "The structure would form a Pentagon"
                    },
                    CorrectAnswerIndex = 4,
                    CloseAnswerIndexes = new List<int> { 3 } // 12 is the mass number, close but not correct
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Bonding (Lewis Structures and Electron Configurations)",
                    QuestionText = "The Central Atom in Carbon Dioxide is Surrounded by",
                    Options = new List<string> {
                        "2 single bonds and 2 lone pairs",
                        "1 double bond, 1 single bond, and 1 lone pair",
                        "1 double bond, 1 single bond, and 2 lone pairs",
                        "2 double bonds, no lone pairs",
                        "2 double bonds, 1 lone pair"
                    },
                    CorrectAnswerIndex = 4,
                    CloseAnswerIndexes = new List<int> { } // 12 is the mass number, close but not correct
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Coordination Chemistry",
                    QuestionText = "Given K3[Co(H2O)4Cl2] what is the coordination number of the central metal ion",
                    Options = new List<string> {
                        "2",
                        "3",
                        "4",
                        "6",
                        "9"
                    },
                    CorrectAnswerIndex = 4,
                    CloseAnswerIndexes = new List<int> { } // 12 is the mass number, close but not correct
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Other - Formula Writing",
                    QuestionText = "What is the formula for Dichlorobis(phenathroline)chromium(III) chloride",
                    Options = new List<string> {
                        "[Cr(phen)2]Cl3",
                        "[CrCl3(phen)2]",
                        "Cl[CrCl2(phen)2]",
                        "[CrCl2(phen)2]Cl",
                        "[CrCl(phen)2]Cl2"
                    },
                    CorrectAnswerIndex = 4,
                    CloseAnswerIndexes = new List<int> { } // 12 is the mass number, close but not correct
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Redox Reactions",
                    QuestionText = "Write a Balanced Half-Reaction for the Reduction of Hydrogen Peroxide to water in an acidic solution",
                    Options = new List<string> {
                        "2 H2O2 -> 2 H2O + O2",
                        "2 H2O2 + 2e- -> 2 H2O + O2",
                        "H2O2 + 2 H+ + 2e- -> 2 H2O",
                        "H2O2 + 4 H+ + 2e- -> 2 H2O + H2",
                        "H2O2 + 2 H+ + 4e- -> 2 H2 + O2"
                    },
                    CorrectAnswerIndex = 3,
                    CloseAnswerIndexes = new List<int> { } // 12 is the mass number, close but not correct
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Bonding (Lewis Structures and Electron Configurations)",
                    QuestionText = "Which of the following will have a Lewis Structure most like that of the hydroxonium ion H3O+",
                    Options = new List<string> {
                        "NO3-",
                        "NH3",
                        "SO3",
                        "CO3 2-",
                        "H2CO"
                    },
                    CorrectAnswerIndex = 2,
                    CloseAnswerIndexes = new List<int> { } // 12 is the mass number, close but not correct
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Redox Reactions",
                    QuestionText = "Which of the following metals or metal ions will reduce Fe2+ \n Cu2+ + 2e- -> Cu E* = +0.34 V \n Sn2+ + 2e- -> Sn E* = -0.14V \n Fe2+ + 2e- -> Fe E* = -1.66V \n Al3+ + 3e- -> Al E* = -1.66V \n Mg2+ + 2e- -> Mg E*=-2.37 V",
                    Options = new List<string> {
                        "Cu and Sn",
                        "Cu2+ and Sn2+",
                        "Al3+ and Mg2+",
                        "Al and Mg",
                        "Sn and Al3+"
                    },
                    CorrectAnswerIndex = 4,
                    CloseAnswerIndexes = new List<int> { } // 12 is the mass number, close but not correct
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "VSEPR",
                    QuestionText = "Use VSEPR Theory to Predict the Electron-Pair Geometry and the Molecular Geometry of ICl3-",
                    Options = new List<string> {
                        "Electron Pair : Trigonal Planar, Molecular Geometry : Trigonal Planar",
                        "Electron Pair : Tetrahedral, Molecular Geometry : Trigonal Planar",
                        "Electron Pair : Octrahedral, Molecular Geometry: Trigonal Planar",
                        "Electron Pair : Trigonal Bipyramidal, Molecular Geometry : T-Shaped",
                    },
                    CorrectAnswerIndex = 4,
                    CloseAnswerIndexes = new List<int> { } // 12 is the mass number, close but not correct
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Electrochemical Cells",
                    QuestionText = "Al3+ is reduced to Al at an electrode; if a current of 2 amperes is passed for 48 hours what is the mass of aluminium that is deposited at the electrode; assume 100% efficiency",
                    Options = new List<string> {
                        "3.58g",
                        "32.2g",
                        "48.3g",
                        "96.6g",
                        "2.9 *10^2 g"
                    },
                    CorrectAnswerIndex = 2,
                    CloseAnswerIndexes = new List<int> { } // 12 is the mass number, close but not correct
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Redox Reactions",
                    QuestionText = "What is the Balanced Chemical Equation for the Following Reaction in a Acidic Solution \n Cr2O7 ^2- + Br- -> Cr3+ + Br2",
                    Options = new List<string> {
                        "Cr2O7^2- + 2 Br- -> 2 Cr 3+ + Br2",
                        "Cr2O7^2- + 6 Br- + 14 H+ -> 3 Br2 + 2 Cr3+ + 7H2O",
                        "Cr2O7^2- + 2 Br- + 14 H+ -> 2 Cr3+ + Br2 + 7 H2O",
                        "Cr2O7^2- + 2 Br- + 7H+ -> 2 Cr3+ + Br2 + 7 OH-",
                        "Cr2O7^2- + 6 Br- + 7H+ -> 2 Cr3+ + 3 Br2 + 7 OH-"
                    },
                    CorrectAnswerIndex = 2,
                    CloseAnswerIndexes = new List<int> { } // 12 is the mass number, close but not correct
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Redox Reactions",
                    QuestionText = "Given the following two half-reactions, determine which overall spotaneous reaction is correct \n Cd2+ + 2e- -> Cd E* -1.21V \n Sn2+ + 2e- -> Sn E* = -0.14V",
                    Options = new List<string> {
                        "Cd2+ + Sn -> Cd + Sn2+ E=1.07V",
                        "Cd2+ + Sn -> Cd + Sn2+ E=1.35V",
                        "Cd + Sn2+ -> Cd2+ + Sn E=1.07V",
                        "Cd + Sn2+ -> Cd2+ + Sn E=-1.07V",
                        "Cd + Sn2+ -> Cd2+ + Sn E=1.35V",
                    },
                    CorrectAnswerIndex = 3,
                    CloseAnswerIndexes = new List<int> { } // 12 is the mass number, close but not correct
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Redox Reactions",
                    QuestionText = "Write a balanced equation for the following reaction in a acidic solution \n Cr2O7^2- + I2 -> Cr3+ + IO3-",
                    Options = new List<string> {
                        "Cr2O7^2- + I2 + 2H+ -> 2 Cr3+ + 2IO3- + H2O",
                        "2 Cr2O7^2- + 2 I2 -> 4 Cr3+ + 4IO3- + O2",
                        "5 Cr2O7^2- + 3 I2 + 34 H+ -> 10 Cr3+ + 6 IO3- + 17 H2O",
                        "2 Cr2O7^2- + 2 I2 + 4 H+ -> 4 Cr3+ + 4 IO3- + 2 H2O",
                    },
                    CorrectAnswerIndex = 3,
                    CloseAnswerIndexes = new List<int> { } // 12 is the mass number, close but not correct
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "VSEPR",
                    QuestionText = "Use VSEPR to predict the Electron Pair and Molecular Geometry of the Nitrite Ion NO2-",
                    Options = new List<string> {
                        "EP: Linear, MG: Linear",
                        "EP: Trigonal Planar, MG: Bent",
                        "EP: Trigonal Planar, MG: Linear",
                        "EP: Tetrahedral, MG: Bent",
                    },
                    CorrectAnswerIndex = 2,
                    CloseAnswerIndexes = new List<int> { } // 12 is the mass number, close but not correct
                },
                new Models.PreliminaryQuestion
                {
                    CategoryName = "Electrochemical Cells",
                    QuestionText = "What is the charge in coulombs required to deposit 0.301g Cu from a solution of Cu2+",
                    Options = new List<string> {
                        "914 C",
                        "9.82 * 10^-8 C",
                        "3.97 * 10^-4 C",
                        "228 C",
                        "457 C"
                    },
                    CorrectAnswerIndex = 1,
                    CloseAnswerIndexes = new List<int> { } // 12 is the mass number, close but not correct
                },
            };
        }
        public Dictionary<string, CategoryScore> CalculateCategoryScores(List<QuestionResult> questionResults)
        {
            var categoryScores = new Dictionary<string, CategoryScore>();

            var groupedByCategory = questionResults.GroupBy(q => q.CategoryName);

            foreach (var group in groupedByCategory)
            {
                var categoryName = group.Key;
                var questions = group.ToList();

                var totalPoints = questions.Sum(q => q.Points);
                var averagePoints = questions.Any() ? totalPoints / questions.Count : 0;
                var totalTime = questions.Select(q => q.TimeSpent).Aggregate(TimeSpan.Zero, (sum, time) => sum + time);

                // Determine overall result based on average performance
                var bestResult = questions.OrderBy(q => q.Result).First().Result;

                categoryScores[categoryName] = new CategoryScore
                {
                    CategoryName = categoryName,
                    Points = totalPoints,
                    TotalQuestions = questions.Count,
                    AveragePoints = averagePoints,
                    TimeSpent = totalTime,
                    Result = bestResult
                };
            }

            return categoryScores;
        }
        private void InitializeChemistryQuestionsHalf1()
        {
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