class Cars
{
    private double power {get;set;}

    public Cars(double power)
    {
        this.power = power;
    }

    public void Actions() 
    {
        Console.WriteLine(power);
    }
}