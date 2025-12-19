class Triangle{
	public static void Main(){
		double baseVal = double.Parse(Console.ReadLine());
		double height = double.Parse(Console.ReadLine());
		double areaInches = 0.5 * baseVal * height;
		double areaCm = areaInches * 6.4516;
		Console.WriteLine("Area in square inches is " + areaInches + " and square centimeters is " + areaCm);
	}
}
