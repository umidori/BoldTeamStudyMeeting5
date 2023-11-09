using System;
using System.IO;

class answer1 {
	static void Main() {
		using (var sr = new StreamReader("products.txt")) {
			var smallSum = 0;
			var sum = 0;
			var cols = sr.ReadLine()?.Split('\t'); 
			if (cols == null) {
				return;
			}
			var code = cols[0];
			while (cols != null) {
				if (cols[0] != code) {
					Console.WriteLine($"小計\t\t{smallSum}");
					sum += smallSum;
					smallSum = 0;
					code = cols[0];
				}
				var (name, price) = (cols[1], int.Parse(cols[2]));
				smallSum += price;
				Console.WriteLine($"{code}\t{name}\t{price}");

				cols = sr.ReadLine()?.Split('\t'); 
			}
			Console.WriteLine($"小計\t\t{smallSum}");
			sum += smallSum;
			Console.WriteLine($"合計\t\t{sum}");
		}
	}
}
