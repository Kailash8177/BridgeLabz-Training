class DiscountSecond{
	public static void Main(){
		int fee = int.Parse(Console.ReadLine());
		int discountPercent = int.Parse(Console.ReadLine());
		double discount = (fee * discountPercent) / 100.0;
		double finalFee = fee - discount;
		Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + finalFee);
	}
}
