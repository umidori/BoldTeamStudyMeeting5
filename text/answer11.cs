using System;
using System.IO;

class answer1 {
	static void Main() {
		using (var sr = new StreamReader("products_services.txt")) {
			var middleSum = 0;
			var smallSum = 0;
			var sum = 0;
			var cols = sr.ReadLine()?.Split('\t'); 
			if (cols == null) {
				return;
			}
			var category = cols[0];
			var code = cols[1];
			while (cols != null) {
				if (cols[0] != category) {
					Console.WriteLine($"小計\t\t\t{smallSum}");
					middleSum += smallSum;
					smallSum = 0;
					code = cols[1];
					Console.WriteLine($"中計\t\t\t{middleSum}");
					sum += middleSum;
					middleSum = 0;
					category = cols[0];
				} else if (cols[1] != code) {
					Console.WriteLine($"小計\t\t\t{smallSum}");
					middleSum += smallSum;
					smallSum = 0;
					code = cols[1];
				}
				var (name, price) = (cols[2], int.Parse(cols[3]));
				smallSum += price;
				Console.WriteLine($"{category}\t{code}\t{name}\t{price}");

				cols = sr.ReadLine()?.Split('\t'); 
			}
			Console.WriteLine($"小計\t\t\t{smallSum}");
			middleSum += smallSum;
			Console.WriteLine($"中計\t\t\t{middleSum}");
			sum += middleSum;
			Console.WriteLine($"合計\t\t\t{sum}");
		}
	}
}
