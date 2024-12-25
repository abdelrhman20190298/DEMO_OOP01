namespace DEMO_OOP01
{
    internal class Program
    {
        public static void DoSomeCode()
        {
            try
            {
                int X, Y, Z;
                X = int.Parse(Console.ReadLine());  //FormatException
                Y = int.Parse(Console.ReadLine());
                Z = X / Y; //ZeroDeviedExceptin
                int[] Number = { 1, 2, 3 };
                Number[10] = 100;  //IndexOutOfRangeException
            
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Store DB
            }

            static void Main(string[] args)
        {
                #region Exception Handling
                DoSomeCode();
            #endregion
        }
    }
}
