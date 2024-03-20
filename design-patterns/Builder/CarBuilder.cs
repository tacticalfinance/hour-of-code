using design_patterns.Builder.contracts;

namespace design_patterns.Builder;

public class CarBuilder : ICarBuilder
{
    public ICar BuildCar(string carType)
    {
        ICar car = new Car();

        if (carType == "Jeep")
        {
            IBody body = new Body("Jeep");
            IEngine engine = new Engine(400);
            int wheelSize = 22;

            car.SetBody(body);
            car.SetEngine(engine);
            for (int i = 0; i < 4; i++)
            {
                car.AttachWheel(new Wheel(wheelSize));
            }
        }
        else if (carType == "Hatchback")
        {
            IBody body = new Body("Hatchback");
            IEngine engine = new Engine(85);
            int wheelSize = 16;

            car.SetBody(body);
            car.SetEngine(engine);
            for (int i = 0; i < 4; i++)
            {
                car.AttachWheel(new Wheel(wheelSize));
            }
        }
        else
        {
            throw new ArgumentException("Unknown car type");
        }

        return car;
    }
}