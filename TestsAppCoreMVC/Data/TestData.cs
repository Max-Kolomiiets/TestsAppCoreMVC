using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestsAppCoreMVC.Models;

namespace TestsAppCoreMVC.Data
{
    public static class TestData
    {
        public static List<Test> Tests = new List<Test>();
        public static List<Question> Questions = new List<Question>();
        public static List<Answer> Answers = new List<Answer>();

        public static void Init(int count)
        {
            int testId = 1;
            int answerId = 1;
            int questionId = 1;

            var answerFaker = new Faker<Answer>()
                .RuleFor(p => p.Id, _ => answerId++)
                .RuleFor(p => p.Name, f => f.Lorem.Sentence())
                .RuleFor(p => p.IsCorrect, f => f.Random.Bool());


            var questionFaker = new Faker<Question>()
                .RuleFor(p => p.Id, _ => questionId++)
                .RuleFor(p => p.Name, f => f.Lorem.Sentence(5, 2))
                .RuleFor(p => p.Answers, f => answerFaker.Generate(f.Random.Number(4, 6)).ToList());

            var testFaker = new Faker<Test>()
                .RuleFor(p => p.Id, _ => testId++)
                .RuleFor(p => p.Name, f => f.Lorem.Word())
                .RuleFor(p => p.Description, f => f.Lorem.Sentence(15, 7))
                .RuleFor(p => p.Questions, f => questionFaker.Generate(f.Random.Number(8 , 12)).ToList());

            Tests.AddRange(testFaker.Generate(count));
            foreach (var test in Tests)
            {
                foreach (var question in test.Questions)
                {
                    foreach (var answer in question.Answers)
                    {
                        answer.QuestionId = question.Id;
                    }
                    question.TestId = test.Id;
                }
            }
            foreach (var item in Tests) 
            {
                Questions.AddRange(item.Questions);
                item.Questions = null;
            }

            foreach (var question in Questions)
                Answers.AddRange(question.Answers);

            foreach (var question in Questions)
            {
                question.Answers = null;
            }
        }
    }       
}
