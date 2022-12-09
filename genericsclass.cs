using System;
class GenericsClass{
public class ABC <T> {
	private T data;
	public T value
	{
		get
		{
			return this.data;
		}
		set
		{
			this.data = value;
		}
	}
}
class Test {
	static void Main(string[] args)
	{
		ABC <string> name = new ABC <string>();
		name.value = "Anil kumar";
		
		ABC <float> version = new ABC <float>();
		version.value = 5.0F;

		Console.WriteLine(name.value);
		
		Console.WriteLine(version.value);
	}
}

}