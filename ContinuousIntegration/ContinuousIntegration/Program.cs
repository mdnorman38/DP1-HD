using System;

namespace ContinuousIntegration
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            var p = new MainClass();

            string returned = p.AddNewline("This is a test");
            Console.WriteLine(returned);

            int result = p.MultiplyInput(5, 5);
            Console.WriteLine(result);

        }

        //Function to replace space in string with new line
		public string AddNewline(string input)
		{
			string[] data = input.Split();
			string output = "";

			for (int i = 0; i < data.Length; i++)
			{
				output += data[i] + "\n";
			}
			return output;
		}

        //Function to multiply two integer inputs
        public int MultiplyInput(int x, int y)
        {
            return (x * y);
        }

    }
}
