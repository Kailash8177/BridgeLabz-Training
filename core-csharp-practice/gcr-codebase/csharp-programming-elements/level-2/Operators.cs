using System;

class Operators{
	public static void Main(string [] args){
		
		int a = 10;
		int b = 5;
		int c = 0;
		
		// ArithmeticOperators
		
		Console.WriteLine("Addition" + (a+b));
		Console.WriteLine("Subtraction: " + (a - b)); // 5
        Console.WriteLine("Multiplication: " + (a * b)); // 50
        Console.WriteLine("Division: " + (a / b)); // 2
        Console.WriteLine("Modulus: " + (a % b)); // 0
		
		
		// Relation Operators
		
		Console.WriteLine("a==b "+(a==b));
		Console.WriteLine("a>b " +(a>b));
		Console.WriteLine("a!=b "+(a!=b));
		Console.WriteLine("a<b "+(a<b));
		Console.WriteLine("a>=b "+(a>=b));
		Console.WriteLine("a<=b "+(a<=b));

        // Logical Operators
		//Console.WriteLine("a&&c"+(a&&c));
        //Console.WriteLine("a&&b"+(a&&b));		
		//Console.WriteLine("a||b"+(a||b));
		//Console.WriteLine("a||c"+(a||c));

        // Assignment Operators
        //Console.WriteLine("a += b: " +a);
        Console.WriteLine("a+=b: "+(a+=b));
        Console.WriteLine("a -= b: " +(a-=b));
        Console.WriteLine("a *= b: " +(a*=b));
        Console.WriteLine("a %= b: " +(a%=b));
        Console.WriteLine("a /= b: " +(a/=b));
		
		a=5;
		
		// Unaray Operators
		
		Console.WriteLine("a: " + a); // 5 indicates the postive number
        Console.WriteLine("++a: " + ++a); // 6 (pre-increment)
        Console.WriteLine("a++: " + a++); // 6 (post-increment)
		Console.WriteLine("a: " + a); // 7
		Console.WriteLine("--a: " + --a); // 6 (pre-decrement)
		Console.WriteLine("a--: " + a--); // 6 (post-decrement)
		Console.WriteLine("a: " + a); // 5
		
		
		// Ternary Operators
		a = 10;
		b = 20;
		int max = (a > b) ? a : b;
		Console.WriteLine("Max: " + max);
		
		// is Operators
		
		Operators op = new Operators();
		Console.WriteLine(op is object);
		Console.WriteLine(op is bool);
		
		Object o = 12;
		Console.WriteLine(o is int);
		
		
	}
		
}
