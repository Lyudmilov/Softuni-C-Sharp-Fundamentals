namespace _1.Problem1_GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               /Every day Puppy eats 300 gr of food. 
               /Every second day Merry first feeds the pet, then gives it a certain amount 
            of hay equal to 5% of the rest of the food. 
               On every third day, Merry puts Puppy cover with a quantity of 1/3 of its weight.

               Calculate whether the quantity of food, hay and cover will be enough for a month.
               If Merry runs out of food, hay, or cover, stop the program!
               */

            /*   PRINTS
             •	If the food, the hay and the cover are enough, print:
                o	"Everything is fine! Puppy is happy! Food: {excessFood}, Hay: {excessHay}, Cover: {excessCover}."
             •	If one of the things is not enough, print:
                o	"Merry must go to the pet store!"
               The output values must be formatted to the second decimal place!
             */
            /*
              10
              5
              5.2
              1

               1
               1.5
               3
               1.5

               9
               5
               5.2
               1
               
            */
            double food = double.Parse(Console.ReadLine()) * 1000;
            double hay = double.Parse(Console.ReadLine()) * 1000;
            double cover = double.Parse(Console.ReadLine()) * 1000;
            double pigWeight = double.Parse(Console.ReadLine()) * 1000;

            for (int i = 1; i <= 30; i++)
            {
                food -= 300;
                if (i % 2 == 0)
                {
                    hay -= (food * 0.05);
                }
                //else
                if (i % 3 == 0)
                {
                    cover -= (pigWeight / 3);
                }
            }

            if (food > 0 && hay > 0 && cover > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food / 1000:f2}, Hay: {hay / 1000:F2}, Cover: {cover / 1000:f2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
        }
    }
}