class Volume{
	public static void Main(){
		int r =  6378 ;
		double pi = 3.14;
        double v = (4.0 / 3.0) * pi * r * r * r;
        double rMiles = r / 1.6;
        double vMiles = (4.0 / 3.0) * pi * rMiles * rMiles * rMiles;
		Console.WriteLine("The volume of earth in cubic kilometers is " + v +" and cubic miles is " + vMiles);
	}
}