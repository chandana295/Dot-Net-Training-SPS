namespace Practice
{
    public static class A
    {
        public static string ApplicationName { get; private set; }
        public static void SetAppName(string appName)
        {
            ApplicationName = appName;
        }
        public static void DisplayAppName()
        {
            if (string.IsNullOrEmpty(ApplicationName))
            {
                Console.WriteLine("Application name is not set.");
            }
            else
            {
                Console.WriteLine($"Application Name: {ApplicationName}");
            }
        }
        internal class Program
        {

            static void Main(string[] args)
            {
                Console.WriteLine("Enter the Appilcation name :");
                string appName = Console.ReadLine();
                A.SetAppName(appName);
                A.DisplayAppName();
               

            }
        }
    }
}
