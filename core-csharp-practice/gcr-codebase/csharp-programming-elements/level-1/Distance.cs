class Distance{
	public static void Main(){
		double feet = double.Parse(Console.ReadLine());
		double yards = feet / 3;
		double miles = yards / 1760;
		Console.WriteLine("Distance in yards is " + yards + " and distance in miles is " + miles);
	}
}
