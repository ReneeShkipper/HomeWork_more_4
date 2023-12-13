namespace HW_2
{
    class Automobile
    {
        private string brand;
        private int maxSpeed;
        public void SetBrand(string brand) { this.brand = brand; }
        public void SetMaxSpeed(int maxSpeed) { this.maxSpeed = maxSpeed < 0 ? maxSpeed * (-1) : maxSpeed; }
        public string GetBrand() { return brand; }
        public int GetMaxSpeed() { return maxSpeed; }
        public virtual void PrintInfo() { Console.WriteLine($"brand = {brand}; maxSpeed = {maxSpeed}"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Automobile> automobiles = new List<Automobile>();

            Automobile car1 = new Automobile();
            car1.SetBrand("Chevrolet");
            car1.SetMaxSpeed(150);
            automobiles.Add(car1);

            Automobile car2 = new Automobile();
            car2.SetBrand("Mazda");
            car2.SetMaxSpeed(200);
            automobiles.Add(car2);

            Automobile car3 = new Automobile();
            car3.SetBrand("Mersedes");
            car3.SetMaxSpeed(120);
            automobiles.Add(car3);

            Automobile car4 = new Automobile();
            car4.SetBrand("Volvo");
            car4.SetMaxSpeed(100);
            automobiles.Add(car4);

            Automobile car5 = new Automobile();
            car5.SetBrand("Iaguar");
            car5.SetMaxSpeed(345);
            automobiles.Add(car5);

            Automobile car6 = new Automobile();
            car6.SetBrand("Honda");
            car6.SetMaxSpeed(512);
            automobiles.Add(car6);

            Automobile car7 = new Automobile();
            car7.SetBrand("Kia");
            car7.SetMaxSpeed(490);
            automobiles.Add(car7);

            Automobile superCar = new Automobile();

            foreach (var item in automobiles)
            {
                if (superCar.GetMaxSpeed() < item.GetMaxSpeed())
                {
                    superCar = item;
                }
            }
            superCar.PrintInfo();
        }
    }
}