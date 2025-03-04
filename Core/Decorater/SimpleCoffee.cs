namespace DevToolkit.Core.Decorater;

// Concrete component
public class SimpleCoffee : ICoffee
{
    public string GetDescription() => "Simple Coffee";
    public double GetCost() => 5.0; // Base price
}
