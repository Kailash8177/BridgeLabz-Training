using System;

class  BMICalculator{
	public static void Main(){
		
		double weight = double.Parse(Console.ReadLine());
		double height = double.Parse(Console.ReadLine());
		
		if(weight > 0 && height > 0){
			
			height = height / 100;
			double bmi = weight / (height * height);
			
			Console.WriteLine(bmi);
			
			if(bmi <= 18.4){
				Console.WriteLine("Underweight");
			}
			else if(bmi >= 18.5 && bmi <= 24.9){
				Console.WriteLine("Normal");
			}
			else if(bmi >= 25.0 && bmi <= 39.9){
				Console.WriteLine("Overweight");
			}
			else{
				Console.WriteLine("Obese");
			}
		}
		else{
			Console.WriteLine("Enter valid weight and height");
		}
	}
}
