using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quitApp = false;

            do
            {
                Console.WriteLine("Please specify a file to run (rewards, comments, tasks or else quit)");
                var selectedReports = Console.ReadLine();

                Console.WriteLine("Please specify the quarter :");
                var selectedData = Console.ReadLine();

                var surveyResults = JsonConvert.DeserializeObject<SurveyResults>
                    (File.ReadAllText($"data/{selectedData}.json"));

                switch (selectedReports)
                {
                    case "rewards":
                        GenerateWinnerEmails(surveyResults);
                        break;
                    case "comments":
                        GenerateCommentsReport(surveyResults);
                        break;
                    case "tasks":
                        GenerateTasksReport(surveyResults);
                        break;
                    case "quit":
                        quitApp = true;
                        break;
                    default:
                        Console.WriteLine("Sorry, this is not a valid option.");
                        break;
                }
            } while (!quitApp);



        }
        
        public static void GenerateWinnerEmails(SurveyResults results)
        {

            var selectedEmails = new List<string>();
            int counter = 0;

            Console.WriteLine(Environment.NewLine + "Selected Winners Output:");
            while (selectedEmails.Count < 2 && counter < results.Responses.Count)
            {
                var currentItem = results.Responses[counter];

                if (currentItem.FavoriteProduct == "Cappucino") 
                {
                    selectedEmails.Add(currentItem.EmailAddress);
                    Console.WriteLine(currentItem.EmailAddress);
                }

                counter++;
            }

            File.WriteAllLines("WinnersReports.csv", selectedEmails);

        }

        public static void GenerateCommentsReport(SurveyResults results)
        {
            var comments = new List<string>();

            Console.WriteLine(Environment.NewLine + "Comments Output:");
            for (var i = 0; i < results.Responses.Count; i++)
            {
                var currentResponse = results.Responses[i];

                if (currentResponse.WouldRecommend < 7.0)
                {
                    Console.WriteLine(currentResponse.Comments);
                    comments.Add(currentResponse.Comments);
                }
            }

            foreach (var response in results.Responses)
            {
                if (response.AreaToImprove == results.AreaToImprove)
                {
                    Console.WriteLine(response.Comments);
                    comments.Remove(response.Comments);
                }
            }
        }

        public static void GenerateTasksReport(SurveyResults results)
        {
            //Calculate Values
            double responseRate = results.NumberResponded / results.NumberSurveyed;
            double unansweredCount = results.NumberSurveyed - results.NumberResponded;
            double overallScore = (results.ServiceScore + results.CoffeeScore + results.FoodScore + results.PriceScore) / 4;

            Console.WriteLine($"Response Percentage: {responseRate}");
            Console.WriteLine($"Unanswered Surveys: {unansweredCount}");
            Console.WriteLine($"Overall Score : {overallScore}");


            //Logical Comparisons
            bool higherCoffeeScore = results.CoffeeScore > results.FoodScore;
            bool customersRecommend = results.WouldRecommend >= 7;
            bool noGranolaYesCappucino = results.LeastFavoriteProduct == "Granola" && results.FavoriteProduct == "Cappucino";

            Console.WriteLine($"Coffee score than food: {higherCoffeeScore}");
            Console.WriteLine($"Customers would reccomend us: {customersRecommend}");
            Console.WriteLine($"Hate Granola Love Cappucino: {noGranolaYesCappucino}");


            //Simple Decision Logic
            var tasks = new List<String>();

            if (results.CoffeeScore > results.FoodScore)
            {
                tasks.Add("Investigate Coffee Recioes and Ingredients");
            }

            //branched decision logic
            if (overallScore > 8)
            {
                tasks.Add("Work with leadership to reward staff");
            }
            else
            {
                tasks.Add("Work with employees for improvement ideas");
            }

            //nested if
            if (responseRate < .33)
            {
                tasks.Add("Research options to improve response rate");
            }
            else if (responseRate > .33 && responseRate < .66)
            {
                tasks.Add("Reward participants with free coffee coupons");
            }
            else
            {
                tasks.Add("Reward participants with discount coffee coupons");
            }

            //Streamlining Switch

            tasks.Add(results.AreaToImprove switch
            {
                "RewardsProgram" => "Revisit the rewards deal",
                "Cleaniness" => "Contact the cleaning vendor",
                "MobileApp" => "Contact the consulting firm about app",
                _ => "Investigate individual comments for ideas"
            });

            //switch

            //switch (results.AreaToImprove)
            //{
            //    case "RewardsProgram":
            //        tasks.Add("Revisit the rewards deals.");
            //        break;

            //    case "Cleaniness":
            //        tasks.Add("Contact the cleaning vendor.");
            //        break;

            //    case "MobileApp":
            //        tasks.Add("Contact the consulting firm about app.");
            //        break;

            //    default:
            //        tasks.Add("Investigate individual comments for ideas.");
            //        break;
            //}

            Console.WriteLine(Environment.NewLine + "Tasks Output:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }

            File.WriteAllLines("TasksReport.csv", tasks);
        }
    }
}