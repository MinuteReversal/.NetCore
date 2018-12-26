using System;

namespace 多catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new NullReferenceException();
            }
            catch (StackOverflowException ex) { Console.WriteLine(ex.Message); }
            //catch (NullReferenceException ex) { Console.WriteLine(ex.Message); }
            catch (IndexOutOfRangeException ex) { Console.WriteLine(ex); }
            //catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
