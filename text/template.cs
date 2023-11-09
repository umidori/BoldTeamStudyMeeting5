using System;
using System.IO;

class template {
	static void Main() {
		using (var sr = new StreamReader("products.txt")) {
			var cols = sr.ReadLine()?.Split('\t'); 
			if (cols == null) {
				return;
			}
			while (cols != null) {
				var (code, name, price) = (cols[0], cols[1], int.Parse(cols[2]));
				Console.WriteLine($"{code}\t{name}\t{price}");

				cols = sr.ReadLine()?.Split('\t'); 
			}
		}
	}
}
