namespace Singletone_DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GCard gCard01 = GCard.GetCard();
            //Console.WriteLine(gCard01.GetHashCode());

            //GCard gCard02 = GCard.GetCard();
            //Console.WriteLine(gCard02.GetHashCode());

            //GCard gCard01 = GCard.SingletoneObj;
            //Console.WriteLine(gCard01.GetHashCode());

            //GCard gCard02 = GCard.SingletoneObj;
            //Console.WriteLine(gCard02.GetHashCode());
            ConcreatePrototype orignalPrototype = new ConcreatePrototype
            {
                Id =1,
                Name="Orignal Object"
            };
            ConcreatePrototype CopiedPrototype = (ConcreatePrototype)orignalPrototype.Clone();

            Console.WriteLine("Orignal "+orignalPrototype);
            Console.WriteLine("Copied Protype"+CopiedPrototype);
            Console.WriteLine();

        }
    }
}