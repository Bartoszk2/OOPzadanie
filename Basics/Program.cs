
Desk d1 = new Desk("green", "Auchan");

d1.colour = "green";
d1.brand = "Auchan";

while(true)
{
    d1.Lift();
    Thread.Sleep(500);
}


class Desk(int height, string colour, string brand)
{
    public const decimal MAX_HEIGHT = 2.0m;
    private decimal height = height;
    public string colour = colour;
    public string brand = brand;

    public decimal GetHeight() {  return height; }

    public void Lift()
    {
        if (height < MAX_HEIGHT)
        {
            height += 0.1m;
        } else
        {
            Console.WriteLine($"Hey, it's too high. Max {MAX_HEIGHT}");
        }
        Console.WriteLine($"Desk is on {height} height");
    }
}


// public, private, protected

