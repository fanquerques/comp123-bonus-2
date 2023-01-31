namespace comp123_bonus2_fan_yang
{
    internal class Program
    {
        // Fan Yang (301295721)
        static void Main(string[] args)
        {
            List<Plane> listOfPlane = new List<Plane>();
            Plane plane1 = new Plane();
            Plane plane2 = new Plane("Tesla", "T", 4, "passenger", "12345");
            Plane plane3 = new Plane();
            Plane plane4 = new Plane("Tesla", "X", 6, "military", "52521");
            Plane plane5 = new Plane("Kia", "L", 2, "passenger", "00010");

            listOfPlane.Add(plane1);
            listOfPlane.Add(plane2);
            listOfPlane.Add(plane3);
            listOfPlane.Add(plane4);
            listOfPlane.Add(plane5);

            foreach (Plane plane in listOfPlane)
            {
                Console.WriteLine(plane.ToString());
            }

            Console.WriteLine("\n" + "Plane 1 has capacity of 0: " + plane1.HasCapacity(0));
            Console.WriteLine("Plane 1 has capacity of 1: " + plane1.HasCapacity(1));
            Console.WriteLine("Plane 2 has capacity of 4: " + plane2.HasCapacity(4));
            Console.WriteLine("Plane 2 has capacity of 5: " + plane2.HasCapacity(5));
            Console.WriteLine("Plane 4 has capacity of 0: " + plane4.HasCapacity(0));
            Console.WriteLine("Plane 4 has capacity of 6: " + plane4.HasCapacity(6));
            Console.WriteLine("Plane 4 has capacity of 7: " + plane4.HasCapacity(7));

        }
    }
}