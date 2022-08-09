using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
			//Variable Declarations (Names).
			string vacationDestination;
			int vacationDuration;
			bool isAfraidOfFlight;
			decimal myDecimal;
			double myDoubleDecimal;
			char myCharacter;


			//Variable Assignments (initializations).
			vacationDestination = "Singapore";
			vacationDuration = 4;
			isAfraidOfFlight = true;
			myDecimal = 1609.472m;
			myDoubleDecimal = 7.9;
			myCharacter = 'G';
			Console.WriteLine($"For our vacation, my wife and I wanted to venture to, {vacationDestination}, and we really wanted to enjoy what this country had to offer, and therefore had to stay for a period of {vacationDuration} weeks. Are we afraid of flying? {isAfraidOfFlight}: Terrified of it. We guessed the length of the trip to {vacationDestination} to be around {myDecimal} miles away, must be a long flight. When we finally got there, the customs area of the local airport was flooded with lines of people, it took us over {myDoubleDecimal} hours just to get through customs! Oh, and let me tell you, we had been recommended by the local concierge of the hotel we were staying at, and checked out this restaurant called, {myCharacter} -- what a great place! All you can eat buffet. I would definitely encourage other advanturers to consider visiting {vacationDestination} if they haven't already.");
		}
    }
}