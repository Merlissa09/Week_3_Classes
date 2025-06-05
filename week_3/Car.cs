public class Car
{
    public CarMake make;

    private string model = "Mustang";


    // this is an example of a public getter for the model field/property
    public string getModel()
    {
        return make + model;
    }

    public void setModel(string model)
    {
        this.model = "Custom" + model;
    }

    private int speed = 0;

    double odometer;

    // our drive method should take in the current speed and the miles driven
    // it should return the updated odometer value based on what it previously contained and the miles driven together
    public void Drive(int speed, double milesDriven)
    {
        this.speed = speed;
        this.odometer += milesDriven;
    }
}

public enum CarMake {AUDI, NISSAN, VOLVO, FORD, CHEVY}

