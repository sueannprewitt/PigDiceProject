using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceProject {
	class Program {
		Random rnd = new Random();


		int GenerateDieNumber() {
			var DieNumber = rnd.Next(6) + 1;
			Debug($"The die number is {DieNumber}");
			return DieNumber;
		}
		
			void Debug(string message) {
			Console.WriteLine(message);
		}
		
			
			void RunGameOnce()
			{
			var total = 0;
			var DieNumber = GenerateDieNumber();
			while(DieNumber != 1) {
				total = total + DieNumber;
				DieNumber = GenerateDieNumber();
			}
			Debug($"Total game score is {total}");

		}
		void Run() {
			bool PlayAgain = true;
			while (PlayAgain == true) {
				RunGameOnce();
				Console.Write($"Do you want to play again? Y/N : ");
				var answer = Console.ReadLine();
				if (answer == "Y" || answer == "y") {
					PlayAgain = true;
				} else {
					PlayAgain = false;
				}
			}
		}

					static void Main(string[] args) {
			new Program().Run();
		}

	} 
}
