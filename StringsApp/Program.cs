namespace StringsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1;
            string? s2;                                         //nullable
            string s3 = "AUEB";
            string s4 = "AUEB";                                 // intern deixnei sthn idia thesi me thn s3.
            string s5 = new string(" AUEB");                    // den kanei interning
            string s6 = new("AUEB");                           // omoia me parapanw
            string s7 = string.Intern("AUEB");
            string s8 = "UoA";

            bool areEqual = s3 == s5;                           // overloaded operatiors of Equals
            bool areNotEqual2 = s3.Equals(s5);

            bool areReferencesEqual = ReferenceEquals(s3, s5);  // tsekareis gia an deixnoun stin idia thesi


            Console.WriteLine($"{string.Compare(s3, s8)}");
            Console.WriteLine($"{s3.CompareTo(s8)}");

            string s9 = s3 + " " + s8;

            string pass1 = "# myPass !$#";
            string pass2 = "MyPASS";

            if (pass1.ToUpper() == pass2.ToUpper())
            {
                Console.WriteLine("String are case-insensitive equal");
            }

            string str = " Coding Factory";
            int index = str.IndexOf("Coding");
            index = str.IndexOf("o");                           //
            index = str.IndexOf("o", 2);                         //11

            string path = "C:\\tmp\\myphoto.png";                  // omoio  @"C:\tmp\myphoto.png"
            string filename = path.Substring(7, 7);                 // start index & length


            char[] trimChars = { '*', '!', '$', '#', ' ' };
            //string trimmedPass1 = pass1.Trim(); 
            string trimmedPass1 = pass1.Trim(trimChars);

            char ch = pass1[0}];


        }
    }
}