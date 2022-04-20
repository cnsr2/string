// See https://aka.ms/new-console-template for more information
string sent = "Dersimiz CSharp, Hoşgeldiniz!";
            string sent3 = "dersimiz cSharp, hoşgeldiniz!";
            string sent2 = "Dersimiz";
            //Length; // dizi içerisindeki karakteri belirtir
            Console.WriteLine(sent.Length);
            //ToUpper ToLower   // hepsini büyük yada hepsini küçük harf yapar
            Console.WriteLine(sent.ToLower());
            Console.WriteLine(sent.ToUpper());
            //Concat 
            Console.WriteLine(String.Concat(sent2, " Merhaba!"));
            //Compare, CompareTo
            Console.WriteLine(sent.CompareTo(sent2));
            Console.WriteLine(String.Compare(sent, sent3, true));
            Console.WriteLine(String.Compare(sent, sent3, false));
            //Contains
            Console.WriteLine(sent.Contains(sent2));
            Console.WriteLine(sent.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(sent.StartsWith("Dersimiz"));
            //IndexOf
            Console.WriteLine(sent.IndexOf("CS"));
            Console.WriteLine(sent.IndexOf("Saat"));
            Console.WriteLine(sent.LastIndexOf("i"));
            //Insert
            Console.WriteLine(sent.Insert(0,"Merhaba! "));
            //Padding
            Console.WriteLine(sent + sent3.PadLeft(30));
            Console.WriteLine(sent + sent3.PadLeft(40, '*'));
            Console.WriteLine(sent.PadRight(50) + sent3);
            //Remove
            Console.WriteLine(sent.Remove(10));
            Console.WriteLine(sent.Remove(5,3));
            //Replace
            Console.WriteLine(sent.Replace("CSharp", "C#"));
            Console.WriteLine(sent.Replace(" ", "**"));
            //Split
            Console.WriteLine(sent.Split(' ')[1]);
            //Substring
            Console.WriteLine(sent.Substring(4));
            Console.WriteLine(sent.Substring(3,5));
