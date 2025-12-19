class Purchase{
	public static void Main(){
		double unitPrice = double.Parse(Console.ReadLine());
		int quantity = int.Parse(Console.ReadLine());
		double total = unitPrice * quantity;
		Console.WriteLine("The total purchase price is INR " + total + " if the quantity " + quantity + " and unit price is INR " + unitPrice);
	}
}
