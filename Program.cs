namespace ThirdPorject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Duration D3 = new Duration(3600);
            //Duration D4 = new Duration(7800);
            //Duration D5 = new Duration(666);
            //Console.WriteLine(D1);
            //Console.WriteLine(D3);
            //Console.WriteLine(D4);
            //Console.WriteLine(D5

            //we have to check the proprites 
            Duration D1 = new Duration()
            {
               Hours = 2,
               Minutes = 100,
               Seconds = 12

            };

            Duration D2 = new Duration(2, 44, 20);
            Duration D6 = D1 + D2;
            Console.WriteLine(D1);
            Console.WriteLine(D2);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(D6);


            //D1 = D2+7800

            Console.WriteLine("-------------------------------------");
            //Duration D7 = new Duration(1, 10, 15);
            //Console.WriteLine(D7);
            //int x = 7800;
            Duration D8 = new Duration(3, 1, 2);
            Duration D9 = new Duration(3, 0, 2);
            //Console.WriteLine(D9>D8);
            //Console.WriteLine(D9++);
            //Console.WriteLine(D8--);

            //D9 = D9 - D8;
            //Console.WriteLine(D9);
            Console.WriteLine(D8 <= D9);
            Duration D10 = new Duration(0, 0, 1);

            string str = D10 ? "True" : "False";
            Console.WriteLine(str);


            DateTime dateTime = (DateTime)D8;
            Console.WriteLine(dateTime);



            //الحمد لله الذي هدانا لهذا وما كنا لنهتدي لولا أن هدانا الله
        }
    }
}
