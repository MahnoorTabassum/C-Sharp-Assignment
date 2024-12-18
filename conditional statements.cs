using System;

class program
{
	static void Main()
	{
		Console.WriteLine("Can you find vegetables in the market?");
		string vegetable = (Console.ReadLine());
		if (vegetable == "yes")
		{
			Console.WriteLine("Buy some vegetables");
		}
		else
		{
			Console.WriteLine("Can you find meat in the market?");
			string meat = (Console.ReadLine());
			if (meat == "yes")
			{
				Console.WriteLine("Buy some meat");
			}
			else
			{

				Console.WriteLine("No vegetables and meat are available, go to mart");
				string mart = (Console.ReadLine());

				if (mart == "yes")
				{
				   Console.WriteLine("Enter the price of item 1:");
                    int item1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the price of item 2:");
                    int item2 = Convert.ToInt32(Console.ReadLine());

                    int TotalAmount = item1 + item2;
                    Console.WriteLine("Total Amount: " + TotalAmount);
                    
					if(TotalAmount<17000)
					{
						Console.WriteLine("Pay 50% with card and 50% with cash.");
						int Cash = TotalAmount / 2;
						int Card = TotalAmount / 2;
						Console.WriteLine("Pay with Cash: " + Cash + " and Card: " + Card);
					}

					else if(TotalAmount > 17000) {
						Console.WriteLine("Pay all with card except 5,000.");
					}
					else if (TotalAmount == 50000)
					{
						int discount = TotalAmount * 75 / 100;
						int AfterDiscount = TotalAmount - discount;
						Console.WriteLine("Total Amount after 75% discount: " + AfterDiscount);
					}
					else
					{
						Console.WriteLine("Total Amount: " + TotalAmount);
					}
				}
			}
		}
	}
}