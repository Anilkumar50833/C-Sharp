using System;
using System.Collections;
					
public class Hashtable
{
	public static void Main()
	{
		var cities = new Hashtable()
        {
			{"UK", "London, Manchester, Birmingham"},
			{"USA", "Chicago, New York, Washington"},
			{"India", "Mumbai, New Delhi, Pune"}
		};

		string citiesOfUK = (string) cities["UK"]; 
		string citiesOfUSA = (string) cities["USA"]; 

		Console.WriteLine("............."+citiesOfUK);
		Console.WriteLine("............."+citiesOfUSA);

		cities["UK"] = "Liverpool, Bristol,Leicusture";
		cities["USA"] = "Los Angeles, Boston,Texas";//new keys to update.
	
		
		Console.WriteLine("---After updating values---");
		
		foreach(DictionaryEntry de in cities)
        {
			Console.WriteLine("key: {0}, Value: {1}", de.Key, de.Value);
        }

	}
}