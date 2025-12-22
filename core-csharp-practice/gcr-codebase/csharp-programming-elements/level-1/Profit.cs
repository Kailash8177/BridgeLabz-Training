class Profit{
	public static void Main(){
		int selling_Price = 191;
		int cost_price = 129;
		int profit = selling_Price - cost_price;
        double profit_Percentage = ( profit *100.0)/ cost_price; //) * 100;	
		Console.WriteLine("The Cost Price is INR "+cost_price + " and Selling Price is INR "+ selling_Price);
		Console.WriteLine("The Profit is INR "+ profit+" and the Profit Percentage is "+ profit_Percentage);
	}
}