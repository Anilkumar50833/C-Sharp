using System;
class compare
{
   
    static public void Main()
    {
	
	    // Initialize a string

	    string s1 = "ANIL";
	
	    string s2 = "anil";

	    string s3 = "kuntrapakam";

        Console.WriteLine(String.Compare(s1,s2));
        Console.WriteLine(String.Compare(s2,s3));
        Console.WriteLine(String.Compare(s3,s1));
    }
    
      /*  static public void Main()
    {
	
    string myString1 = "ANIL";
	
	string myString2 = "anil";
	
	string myString3 = "kuntrapakam";
	
	if (String.Compare(myString1, myString2))
		Console.WriteLine($"{myString1} and {myString2} are same.");
	
	else
		Console.WriteLine($"{myString1} and {myString2} are different.");
	
	if (String.Compare(myString1, myString3))
		Console.WriteLine($"{myString1} and {myString3} are same.");

	else
		Console.WriteLine($"{myString1} and {myString3} are different.");
	
	if (String.Compare(myString2, myString3))
		Console.WriteLine($"{myString2} and {myString3} are same.");

	else
		Console.WriteLine($"{myString2} and {myString3} are different.");		
    }
    */

}
