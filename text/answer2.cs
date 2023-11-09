using System;
using System.IO;

class answer2 {
	static void Main() {
		using (var sr = new StreamReader("products.txt")) {
			var cols = sr.ReadLine()?.Split('\t'); 
			if (cols == null) {
				return;
			}
			var sum = 0;
			while (cols != null) {
				var smallSum = 0;
				var code = cols[0];
				while (cols != null && code == cols[0]) {
					var (name, price) = (cols[1], int.Parse(cols[2]));
					smallSum += price;
					Console.WriteLine($"{code}\t{name}\t{price}");

					cols = sr.ReadLine()?.Split('\t'); 
				}
				sum += smallSum;
				Console.WriteLine($"小計\t\t{smallSum}");
			}
			Console.WriteLine($"合計\t\t{sum}");
		}
	}
}
