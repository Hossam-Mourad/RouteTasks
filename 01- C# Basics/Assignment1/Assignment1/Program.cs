using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;

namespace CSharpAssignment
{
    class Program
    {
        // Class-level field for scope demonstrations
        static int classField = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║           C# FUNDAMENTALS - ASSIGNMENT WITH ANSWERS                ║");
            Console.WriteLine("║                      20 Questions                                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝\n");



            #region Question 1: Regions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 2: REGIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the purpose of #region and #endregion directives in C#? 
            //    How do they help in code organization?
            /*
             * organize the code to be more clean, clear , readable and minimize the size of code
             * when it closed
             * by separate the sections of the code like in this assignment every Question is in
             * a seperated region.
             */
            //
            // ══════════════════════════════════════════════════════════════════════

            //Nested Region Example

            #region firstRegion
            #region Nested Region
            #endregion
            #endregion

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 2: Variable Declaration - Explicit vs Implicit
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between explicit and implicit variable 
            //    declaration in C#? Provide examples of both.
            /* 
             * explicit that i have to mention the datatype when declare the variable
             * implicit i just type (var) and intialize the variable and the compiler automatic know the datatype
             */
            //
            // ══════════════════════════════════════════════════════════════════════



            // EXPLICIT DECLARATION 
            int x;
            string y;

            // IMPLICIT DECLARATION 
            var xx = 10;
            var yy = "Hossam";

            #endregion

            #region Question 3: Constants
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CONSTANTS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write the syntax for declaring a constant in C#. Why would you use 
            //    a constant instead of a regular variable?
            /*
             * we use the constant variables to protect it from modifying and use for the constants like PI = 3.14
             * it's never change
             */
            //
            // ══════════════════════════════════════════════════════════════════════



            // Constant examples

            const double PI = 3.14;
            const string Myname = "Hossam";

            #endregion

            #region Question 4: Class-level vs Method-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the difference between class-level scope and method-level 
            //    scope with examples.
            //
            /*
             * the class level i can access the variable from any place in the class that 
             * may contain a method or loops or conditions
             * and the method level i can only access it inside the method 
             */
            // ══════════════════════════════════════════════════════════════════════

            //class MyClass {
            //int classVar;
            //    void sum()
            //    {
            //        int MethodVar;
            //        // i can see classVar and MethodVar here inside the Method
            //    }

            //    // i can see only the ClassVar here
            //}

            #endregion

            #region Question 5: Block-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 5: BLOCK-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is block-level scope? Give an example showing a variable that 
            //    is only accessible within a specific block.
            //
            /*
             * the conditions and loops scope
             */
            // ══════════════════════════════════════════════════════════════════════

            if (true)
            {
                int BlockVar = 10;
            }
            // i can't access it here

            #endregion

            #region Question 6: Variable Lifetime - Local vs Static
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable lifetime? Explain the lifetime of local variables 
            //    vs static variables.
            /*
             * variable lifetime is the interval of time when the variable be allocated in the memory
             * Local variables lifetime end by the end of the block it inside
             * static lifetime end by the end of the run (app lifetime)
             */
            //
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 7: Garbage Collector
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 7: GARBAGE COLLECTOR
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the Garbage Collector in C#? How does it affect the 
            //    lifetime of objects?
            /*
             * it manage and clean the memory from the variables that its lifetime end.
             * 2 if there is an object in the heab and no refrences point to it garbage collector will remove it
             */
            //
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 8: Variable Shadowing
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 8: VARIABLE SHADOWING
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable shadowing in C#? Does C# allow shadowing in 
            //    nested blocks within the same method?
            //
            /*
             * it's when we hava two diffrent variables with the same name in a nested scopes
             * yes
             */
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 9: C# Naming Rules
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 9: C# NAMING RULES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List five rules that must be followed when naming variables in C#.
            //
            /*
             * first character have to be letter or underscore
             * no spaces or special characters
             * when use a keyword must start with @
             * Sensetive
             * the name represent the variable job 
             * no uncommon appreviations
             */
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 10: Naming Conventions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 10: NAMING CONVENTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What naming conventions are recommended for: (a) local variables, 
            //    (b) class names, (c) constants?
            //
            /*
             * a - camelCase
             * b - PascalCase
             * c - PascalCase
             */
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 11: Error Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 11: ERROR TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Compare and contrast syntax errors, runtime errors, and logical 
            //    errors. Provide an example of each.
            //
            /*
             * syntax error when we type something unvalid like wrong name of variable or method or class
             * or when we forget the semi-colon 
             * like int x or cw(x);
             * first we forget ; 
             * second there is no thing named cw.
             * and it's easy to found and solve because the app never run with syntax error and it happen in the runtime
             * ------------------------------------------
             * runtime error when we type things unknown in the world like divide by 0 or use null or access wrong index
             * int x = 10 / 0;
             * it happen during the running and the app crashed
             * ------------------------------------------
             * logical error is the wrong solution of problem like when i divide by 3 instead of 2 
             */
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 12: Exception Handling Importance
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 12: EXCEPTION HANDLING IMPORTANCE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is exception handling important in C#? What would happen if 
            //    you don't handle exceptions?
            //
            /* 
             * to avoid the program crash and showing readable message to users
             */
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 13: try-catch-finally
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 13: TRY-CATCH-FINALLY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example demonstrating try-catch-finally. Explain when 
            //    the finally block executes.
            //
            /*
             * finally block always execute
            try
            {
                int tt = 0;
                int tmp = 10 / tt;
            } catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by 0 impossible");
            }
            finally
            {
                Console.WriteLine("Always Execute");
            }
            */
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 14: Common Built-in Exceptions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 14: COMMON BUILT-IN EXCEPTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List and explain five common built-in exceptions in C# with 
            //    scenarios when each would occur.
            /*
             * DivideByZeroException when we divide by 0
             * IndexOutOfRangeException when acces an invalid index
             * FormatException when we parse string to integer like int x = int.parse("hossam");
             * FileNotFoundException when we type wrong path of the file
             * ArguementNullException when pass null to method
             */
            //
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 15: Multiple catch Blocks
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 15: MULTIPLE CATCH BLOCKS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is the order of catch blocks important when handling multiple 
            //    exceptions? Write code showing correct ordering.
            /*
             * because if i use the general exception first it catch any exception and never go two the next block
             *
             *
            try
            {

            } catch (DivideByZeroException)
            {

            }
            catch (ArgumentNullException)
            {

            } catch (IndexOutOfRangeException)
            {

            }
            catch (Exception)
            {

            }
            */

            //
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 16: throw Keyword
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 16: THROW KEYWORD
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between 'throw' and 'throw ex' when 
            //    re-throwing an exception? Which one preserves the stack trace?
            /*
             * throw keeps the original exception location but "throw ex" loses it
             * throw
             */
            //
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 17: Stack and Heap Memory
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 17: STACK AND HEAP MEMORY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the differences between Stack and Heap memory in C#. 
            //    What types of data are stored in each?
            /*
             * Stack store Methods calls, variables and refrences to objects and it's auto cleaned with usind LIFO
             * Heap store the objects and managed with garbage Collector
             */
            //
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 18: Value Types vs Reference Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 18: VALUE TYPES VS REFERENCE TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example showing how value types and reference types 
            //    behave differently when assigned to another variable.
            /*
            int value = 10;
            int value2 = value;
            value2 = 100;
            Console.WriteLine(value);
            Console.WriteLine(value2);
            // seperate space in memory so no change in the first
            int []arr = {1, 2, 3};
            int[] arr2 = arr;
            arr2[0] = 45;
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);
            */
            // same object so change in one reflect in the other
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 19: Object in C#
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 19: OBJECT IN C#
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is 'object' considered the base type of all types in C#? 
            //    What methods does every type inherit from System.Object?
            /*
             * because object was used as workaround before generics and have a some functions must be in any type
             * Equals(), ToString(), GetType()
             */
            //
            // ══════════════════════════════════════════════════════════════════════

            #endregion

        }
    }
}