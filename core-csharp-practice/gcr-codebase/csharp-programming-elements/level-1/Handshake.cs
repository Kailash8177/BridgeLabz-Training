class Handshake{
	public static void Main(){
		int numberOfStudents = int.Parse(Console.ReadLine());
		int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
		Console.WriteLine("Maximum number of handshakes is " + handshakes);
	}
}
