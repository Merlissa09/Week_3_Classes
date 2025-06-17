class Car
{
    const string definition = "A car is an object that allows people and other objects to get from one point to another";
    // class based properties
    private static int totalCarCount = 0; // field
    

    public static int TotalCarCount // property
    {
        get { return totalCarCount; }
    }

    // instance based properties
    private CarMake make;

    private int speed = 0;

    private double odometer;

    public double Odometer
    {
        get { return odometer; }
    }

    private double milesToE = 200;

    private string model = "Mustang";

    public readonly int VIN;

    // example of a default constructor
    // public Car()
    // {

    // }

    /// <summary>
    /// Constructor that allows us to specify the make and model at instantiation
    /// </summary>
    /// <param name="make"></param>
    /// <param name="model"></param>
    public Car(CarMake make, string model)
    {
        this.make = make;
        this.model = model;
        VIN = totalCarCount;
        ++totalCarCount;
    }



    // this is an example of a public getter for the model field/property
    public string getModel()
    {
        return make + model;
    }

    public void setModel(string model)
    {
        if (model == "Soul") return;

        this.model = "Custom " + model;
    }

    // our drive method should take in the current speed and the miles driven
    // it should return the updated odometer value based on what it previously contained and the miles driven together
    public void Drive(int speed, double milesDriven)
    {
        this.speed = speed;
        odometer += milesDriven;
        milesToE = milesToE - milesDriven;
    }

    public void Drive(double milesDriven)
    {
        odometer += milesDriven;
        milesToE = milesToE - milesDriven;
        throw new Exception("Your car broken down!");
    }
}

public enum CarMake {AUDI, NISSAN, VOLVO, FORD, CHEVY}

