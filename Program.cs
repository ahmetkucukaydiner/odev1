using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Questions question = new Questions();
            // question.WriteEven();
            // question.EqualOrFDivisor();
            // question.SortWords();
            question.WriteCount(); 
        }
    }

    class Questions
    {
        //1) Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        public void WriteEven()
        {
            Console.WriteLine("Lütfen sayı dizisinin eleman sayısınızı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int[] numberArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Lütfen {i}. sayıyı giriniz: ",i+1);
                numberArray[i] = int.Parse(Console.ReadLine());       
            }

            Console.WriteLine("Dizideki çift Sayılar");
            
            foreach (var number in numberArray)
            {
                if(number%2==0)
                Console.WriteLine(Convert.ToString(number));
            }
        }

        //2) Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        public void EqualOrFDivisor()
        {
            Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayıyı giriniz: ");
            int m = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Lütfen " + (n) +" adet sayı giriniz");
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            Console.WriteLine($"{m}' ye eşit veya tam {m}'yi tam bölen sayılar ");

            foreach (var number in array)
            {
                if(number%m==0 || number==m)
                Console.WriteLine(number);
            }
        }

        //3) Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        public void SortWords()
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());

            string[] words = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Lütfen " + (n) + " adet kelime giriniz: ");
                words[i] = Console.ReadLine(); 
            } 

           Array.Reverse(words);

           foreach (var word in words)
           {
                Console.WriteLine(word);
           }
        }

        //4) Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

        public void WriteCount()
        {
            Console.WriteLine("Bir cümle yazınız: ");
            string sentence = Console.ReadLine();

            Console.WriteLine(sentence.Length);

            string[] wordsCount = sentence.Split(" ");
            Console.WriteLine("Toplam kelime sayısı: " + wordsCount.Length);

            string[] lettersCount = sentence.Split(" ");
            Console.WriteLine("Toplam harf sayısı: " + (sentence.Length - (wordsCount.Length-1)));

        }
    }
}
