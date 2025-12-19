class Height{
	public static void Main(){
		double cm = double.Parse(Console.ReadLine());
		double inches = cm / 2.54;
		int feet = (int)(inches / 12);
		double remainingInches = inches % 12;
		Console.WriteLine("Your Height in cm is " + cm + " while in feet is " + feet + " and inches is " + remainingInches);
	}
}
