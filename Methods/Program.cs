Main();

void Main()
{
    try
    {
        Console.WriteLine("PLease enter rectangle length");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter rectangle width");
        double width = Convert.ToDouble(Console.ReadLine());

       
        double area = CalculateArea(length, width);

        
        Console.WriteLine($"The area of the rectangle is: {area}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}


static double CalculateArea(double length, double width)
{
   
    double area = length * width;
    return area; 
}