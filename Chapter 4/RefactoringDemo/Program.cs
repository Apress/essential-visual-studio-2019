using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefactoringDemo.Library;

namespace RefactoringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertAnonymousTypeToTupleSample();
            ConvertForLoopToForEach();
            var cost = CalculateTotalCost(8.99m, .13m);
            Console.ReadLine();
        }

        #region Change Method

        private static void ChangeMethodNameSample()
        {
            var firstName = "Gillian";
            var lastName = "Johnson";
            Greeting(firstName, lastName);
        }

        private static void Greeting(string firstName, string lastName)
        {
            Console.WriteLine($"Hello {firstName} {lastName}");
        }

        #endregion

        #region Convert Anonymous Type to Class

        private static void ConvertAnonymousTypeToClassSample()
        {
            var temporaryType = new { FirstName = "Kyle", LastName = "Johnson" };
        }

        #endregion

        #region Convert between Property and Get Method

        public string Name { get; set; }

        private string name;
        public string GetName()
        {
            return name;
        }
        public void SetName(string value)
        {
            name = value;
        }

        #endregion

        #region Convert Local Function to Method

        static decimal CalculateTotalCost(decimal price,
            decimal federalTax = 0, decimal stateTax = 0, decimal cityTax = 0)
        {
            decimal TotalTax(decimal tax1, decimal tax2, decimal tax3)
            {
                return tax1 + tax2 + tax3;
            }
            return price * (1 + TotalTax(federalTax, stateTax, cityTax));
        }

        #endregion

        #region Encapsulate Field

        public double Age;

        #endregion

        #region Extract Method

        public bool Validate(Person person)
        {
            var result = true;

            if (string.IsNullOrEmpty(person.FirstName))
                result = false;
            else if (person.FirstName.Length > 50)
                result = false;

            if (string.IsNullOrEmpty(person.LastName))
                result = false;
            else if (person.LastName.Length > 50)
                result = false;

            return result;
        }

        #endregion

        #region Generate Parameter

        public void GenerateParameter()
        {
            var taxRate = 0.13m;
        }

        #endregion

        #region Add Null Checks for Parameters

        public void AddNullChecksForParametersSample(Person person, string newValue)
        {
            person.FirstName = newValue;
        }

        #endregion

        #region Convert Anonymous Type to Tuple

        private static void ConvertAnonymousTypeToTupleSample()
        {
            var temporaryType = new { FirstName = "Cam", LastName = "Johnson" };
        }

        #endregion

        #region Convert Between For Loop and ForEach

        private static void ConvertForLoopToForEach()
        {
            List<string> data = new List<string>() { "a", "b", "c", "d", "e" };
            for (var i = 0; i < data.Count; i++)
            {
                Console.WriteLine(data[i]);
            }

        }

        private static void ConvertForEachLoopToFor()
        {
            List<string> data = new List<string>() { "a", "b", "c", "d", "e" };
            foreach (var datum in data)
            {
                Console.WriteLine(datum);
            }

        }

        #endregion

        #region Convert Between For ForEach and LINQ

        private static IEnumerable<string> ConvertForEachLoopToLINQ()
        {
            List<string> data = new List<string>() { "a", "b", "c", "d", "e" };
            foreach (var datum in data)
            {
                yield return datum;
            }
            yield break;
        }

        private static IEnumerable<string> ConvertLINQQueryToForEach()
        {
            List<string> data = new List<string>() { "a", "b", "c", "d", "e" };

            return from datum in data select datum;
        }

        #endregion

        #region Convert switch statement to switch expression

        public static void ConvertSwitchStatementToExpression()
        {
            var place = 1;
            string result;
            switch (place)
            {
                case 1: result = "First"; break;
                case 2: result = "Second"; break;
                case 3: result = "Third"; break;
                default: result = "Unknown"; break;
            }

            Console.WriteLine(result);
        }

        #endregion

        #region Inline temporary variable

        public static void InlineTemporaryVariable(double diameter)
        {
            var temp = diameter / 2;
            var area = Math.PI * temp * temp;
        }

        #endregion

        #region Invert conditional expression

        public static void InvertConditionalExpressionExample(int valueToTest, bool canUpdate)
        {
            var continueProcessing = valueToTest > 100 ? false : canUpdate;
        }

        #endregion

        #region Invert if condition

        public static bool InvertIfConditionExample(int valueToTest, bool canUpdate)
        {
            bool result;

            if (valueToTest > 100)
            {
                result = false;
            }
            else
            {
                result = canUpdate;
            }

            return result;
        }

        #endregion

        #region Move Declaration Close to Reference

        public void MoveDeclarationExample()
        {
            int variableToMove;

            ConvertAnonymousTypeToClassSample();
            ConvertForEachLoopToFor();

            variableToMove = 100;


            Console.WriteLine(variableToMove.ToString());
        }

        #endregion

        #region Split or Merge If Statements

        public static void SplitOrMergeIfStatementsExample(int valueToTest, bool canUpdate)
        {
            bool continueProcessing;

            if (valueToTest <= 100 && canUpdate)
            {
                continueProcessing = true;
            }
            else
            {
                continueProcessing = false;
            }

            Console.WriteLine(continueProcessing.ToString());
        }

        #endregion

        #region Use Lambda expression or block body

        delegate int del(int i);
        public static void LambdaExpressionOrBlockBodySample()
        {
            del myFunction = x => x * x;
        }

        #endregion

        #region Remove unused variables
        public static void RemoveUnusedVariablesExample()
        {
            var a = 1;
            var valueToDisplay = "Hello world";
            Console.WriteLine(valueToDisplay);
        }

        #endregion

        #region Use explicit type

        public static void UseExplicitTypeSample()
        {
            var a = 1;
            var z = "Hello world";

            Console.WriteLine($"{a} {z}");

            ParameterSample(a, false, z);
        }

        #endregion

        #region Wrap, indent, and align parameters

        public static void ParameterSample(
            int counter, bool conditional, string display)
        {
            if (conditional)
                Console.WriteLine($"{display} {counter}");
        }

        #endregion

        #region IntelliSense completion for unimported types

        public static void IntellisenseCompletionSample()
        {
            SampleClass c = new SampleClass();
        }

        #endregion

        #region Regex completion through IntelliSense

        public static void RegexCompletionSample()
        {
            var test = "12345";
            Match m = new Regex(@"^([0-9])").Match(test);
        }

        #endregion

        #region Remove Unreachable Code

        private static void UnreachableCodeSample()
        {
            throw new Exception();
            Console.WriteLine("This will never be executed");
        }

        #endregion

    }

    #region Move type to matching file

    public enum MoveTypeEnum
    {
        First,
        Second,
        Third
    }

    #endregion
}

#region Move type to different namespace

namespace RefactoringDemo.New
{
    public class ChangeNamespaceClass
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }
    }
}

#endregion





























