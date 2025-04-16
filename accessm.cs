using System;

public class Example
{
    // Public: Accessible from anywhere
    public string PublicProperty = "I am Public";

    // Private: Accessible only within the same class
    private string PrivateProperty = "I am Private";

    // Protected: Accessible within the same class and derived classes
    protected string ProtectedProperty = "I am Protected";

    // Internal: Accessible within the same assembly
    internal string InternalProperty = "I am Internal";

    // Protected Internal: Accessible within the same assembly or derived classes
    protected internal string ProtectedInternalProperty = "I am Protected Internal";

    // Private Protected: Accessible within the same class or derived classes in the same assembly
    private protected string PrivateProtectedProperty = "I am Private Protected";

    public void ShowAccessModifiers()
    {
        Console.WriteLine(PublicProperty);
        Console.WriteLine(PrivateProperty);
        Console.WriteLine(ProtectedProperty);
        Console.WriteLine(InternalProperty);
        Console.WriteLine(ProtectedInternalProperty);
        Console.WriteLine(PrivateProtectedProperty);
    }
}

public class DerivedExample : Example
{
    public void ShowInheritedProperties()
    {
        Console.WriteLine(PublicProperty); // Accessible
        // Console.WriteLine(PrivateProperty); // Not accessible
        Console.WriteLine(ProtectedProperty); // Accessible
        Console.WriteLine(InternalProperty); // Accessible
        Console.WriteLine(ProtectedInternalProperty); // Accessible
        // Console.WriteLine(PrivateProtectedProperty); // Not accessible
    }
}

class Program
{
    static void Main()
    {
        Example example = new Example();
        example.ShowAccessModifiers();

        DerivedExample derived = new DerivedExample();
        derived.ShowInheritedProperties();
    }
}