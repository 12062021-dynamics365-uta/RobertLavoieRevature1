using System;

namespace Rock_Paper_Scissors_Demo1
{
	class Program
	{
		static void Main(string[] args){
			
			int playerGamesWon = 0;
			int computerGamesWon = 0;
			int numOfGames = 0;

			int convertedNumber = -1;
			bool conversionBool = false;
			int computerPicked = 0;

			while (numOfGames < 3) {

				// getting the actuin play(rock,paper,scissors
				do {
					Console.WriteLine("Please enter enter 1 for ROCK, 2 for PAPER, 3 for SCISSORS");
					string userInput = Console.ReadLine();
					//Console.WriteLine(userInput);
					//validate the use input as a 1, 2, or 3
					//this version of TryParse() takes a string and the second argument is an out variable that is instantiated in that moment.
					conversionBool = Int32.TryParse(userInput, out convertedNumber);
					if (!conversionBool || convertedNumber < 1 || convertedNumber > 3) {
						Console.WriteLine("Hey, buddy... that wasn't a 1 or 2 or 3!");
					}
				} while (!(convertedNumber > 0 && convertedNumber < 4));

				//	Console.WriteLine($"The int converted value inputted is {convertedNumber}");
				//	Console.WriteLine($"Game: " + numOfGames ;
				Random randNum = new Random();
				//	Console.WriteLine(randNum.Next(1, 4));// inclusive of the first (lower) value and exclusive of hte second(upper) value. 

				computerPicked = randNum.Next(1, 4);
				if (computerPicked == convertedNumber) /// tie
				{ 
					Console.WriteLine($"A TIE because the Computer picked " + computerPicked + $"    You picked " + convertedNumber);
				} 
				else if ((computerPicked == 2) && (convertedNumber == 1)) // paper vs rock
				{
					Console.WriteLine($"Computer won with " + ItemDesc(computerPicked) + $"    You lost with " + ItemDesc(convertedNumber));
					computerGamesWon++;
				}
				else if ((computerPicked == 3) && (convertedNumber == 2)) // scissors vs paper
				{
					Console.WriteLine($"Computer won with " + ItemDesc(computerPicked) + $"    You lost with " + ItemDesc(convertedNumber));
					computerGamesWon++;
				}
				else if ((computerPicked == 1) && (convertedNumber == 3)) // rock vs scissors
				{
					Console.WriteLine($"Computer won with " + ItemDesc(computerPicked) + $"    You lost with " + ItemDesc(convertedNumber));
					//Console.WriteLine($"Computer won with " + computerPicked + $"    You lost with" + convertedNumber);
					computerGamesWon++;
				}
				else
				{
					Console.WriteLine($"Computer Lost with " + ItemDesc(computerPicked) + $"    You won with " + ItemDesc(convertedNumber));
					playerGamesWon++;
				}

				numOfGames++;
			}
			Console.WriteLine($"");
			Console.WriteLine($"total: " + numOfGames + $" Games");
			Console.WriteLine($"Computer won: " + computerGamesWon + $" Games");
			Console.WriteLine($"Player won: " + playerGamesWon + $" Games");


			string ItemDesc(int picks)
			{
				switch (picks)
				{
					case 1:
						return $"Rock";
					case 2:
						return $"Paper";
					case 3:
						return $"Scissors";
					default: /* Optional */
						return $"unknown??";
				}
			}
			/**homework - 
			 * 1. get a random number for the computer
			 * 2. compare who won the round
			 * 3. refactor the code to have a best of three game
			 * 4. print out the winner, and how many games were won by each (and ties)
			 * 5. and exit the program.
			 * 
			 * 
			 * 
			 * 
			**/




		}
	}
}
