namespace ChalkTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Chalk.Red(string.Format("asdf{0}", "ludmal"));
            Chalk.Blue("blue");
            Chalk.Green("green");
            Chalk.Yellow("yellow");
            Chalk.Gray("gray");
        }
    }
}