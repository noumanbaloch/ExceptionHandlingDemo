using System;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine("Dividing By Zero = " + CallDivideByZero(2, 0));
                //ReadFile();
                FindByIndex(-1);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            
            Console.ReadKey();
        }

        static double CallDivideByZero(int x, int y)
        {
            return DivideByZero(x, y);
        }

        static double DivideByZero(int x, int y)
        {
            int result = 0;
            result = x / y;
            return result;
        }

        static void ReadFile()
        {
            try
            {
                Console.WriteLine("Open the file");
                Console.WriteLine("File opening in progress....");
                Console.WriteLine("Reading data from file....");
                throw new Exception();
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("Close the file"); // that you must want to execute
            }
        }

        static int FindByIndex(int index)
        {
            int value = 0;
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            try
            {
                value = array[index];
            }
            catch (IndexOutOfRangeException ex) when (index < 0)
            {

                throw new ArgumentOutOfRangeException("Index cannot be a negative number ", ex);
            }
            
            catch(IndexOutOfRangeException ex)
            {
                throw new ArgumentOutOfRangeException("Index exceed the max array length ", ex);
            }

            catch (Exception ex)
            {
                throw new Exception();
            }



            return value;
        }
    }
}
