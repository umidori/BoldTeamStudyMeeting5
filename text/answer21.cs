using System;
using System.IO;

class answer2 {
	static void Main() {
		using (var sr = new StreamReader("products_services.txt")) {
			var cols = sr.ReadLine()?.Split('\t'); 
			if (cols == null) {
				return;
			}
			var sum = 0;
			while (cols != null) {
				var middleSum = 0;
				var category = cols[0];
				while (cols != null && category == cols[0]) {
					var smallSum = 0;
					var code = cols[1];
					while (cols != null && category == cols[0] && code == cols[1]) {
						var (name, price) = (cols[2], int.Parse(cols[3]));
						smallSum += price;
						Console.WriteLine($"{category}\t{code}\t{name}\t{price}");

						cols = sr.ReadLine()?.Split('\t'); 
					}
					middleSum += smallSum;
					Console.WriteLine($"小計\t\t\t{smallSum}");
				}
				sum += middleSum;
				Console.WriteLine($"中計\t\t\t{middleSum}");
			}
			Console.WriteLine($"合計\t\t\t{sum}");
		}
	}
}
