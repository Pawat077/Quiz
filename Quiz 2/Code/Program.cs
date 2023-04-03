class Program {
        static void Main() {
            double input;
            double sum = 0;
            double max = double.MinValue;
            double min = double.MaxValue;
            int count = 0;
        

            while (true)
            {
                Console.Write("Enter a number (or 'End' to finish): ");
                string userInput = Console.ReadLine();
                
                if (userInput.ToLower() == "end")
                {
                    break;
                }
                
                if (double.TryParse(userInput, out input))
                {
                    count++;
                    sum += input;
                    if (input > max)
                    {
                        max = input;
                    }
                    if (input < min)
                    {
                        min = input;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            
            while (true)
            {
                Console.Write("Would you like to do (FindMax, FindMin, or FindMean): ");
                string mode = Console.ReadLine();
                
                if (mode.ToLower() == "findmax")
                {
                    Console.WriteLine("The maximum number entered was: " + max);
                    break;
                }
                else if (mode.ToLower() == "findmin")
                {
                    Console.WriteLine("The minimum number entered was: " + min);
                    break;
                }
                else if (mode.ToLower() == "findmean")
                {
                    Console.WriteLine("The mean of the numbers entered was: " + (sum / count));
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
    }

