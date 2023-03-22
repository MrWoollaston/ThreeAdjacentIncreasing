using System;

class Program {
  	public static void Main (string[] args) {
	    Console.WriteLine ("Hello World");

		// test one
		int[] numbers = {4, 50, 65, 7}; // true
		bool tryOne = ThreeAdjacentIncreasing(numbers);
		Console.WriteLine(tryOne);

		// test two
		int[] numbers2 = {4, 50, 6, 7}; // false
		bool tryTwo = ThreeAdjacentIncreasing(numbers2);
		Console.WriteLine(tryTwo);

		// test random list
		int[] randomNumbers = new int[20];
		Random randomNumberGenerator = new Random();
		for(int i = 0; i < randomNumbers.Length; i++){
			randomNumbers[i] = randomNumberGenerator.Next(100); // between 0 and 100
			//Console.Write(randomNumbers[i] + " ");
		}
		bool tryThree = ThreeAdjacentIncreasing(randomNumbers);
		Console.WriteLine(tryThree);
		

		
		
  	}

	public static bool ThreeAdjacentIncreasing(int[] input){

		bool result = false;

		if(input.Length < 3){ // list not long enough
			return false;
		}

		for(int i = 0; i < input.Length-2; i++){

			// check elements are increasing
			if(input[i] < input[i+1] && input[i+1] < input[i+2]){
				Console.WriteLine(input[i] + " " + input[i+1] + " " + input[i+2] + " are adjacent.");
				result = true;
				break;
			}
		}
		return result; // comment
	}
}