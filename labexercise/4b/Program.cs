using System;

class MyClass
{
    public int Value { get; set; }

    public MyClass(int value)
    {
        Value = value;
    }

    // Overloading the == operator
    public static bool operator ==(MyClass obj1, MyClass obj2)
    {
        // If both objects are null, or both are the same instance, return true
        if (ReferenceEquals(obj1, obj2))
            return true;

        // If one is null, but not both, return false
        if (obj1 is null || obj2 is null)
            return false;

        // Return true if the values are equal
        return obj1.Value == obj2.Value;
    }

    // Overloading the != operator (recommended to override != whenever overriding ==)
    public static bool operator !=(MyClass obj1, MyClass obj2)
    {
        return !(obj1 == obj2);
    }

    // Override Equals method for consistency
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        MyClass other = (MyClass)obj;
        return Value == other.Value;
    }

    // Override GetHashCode method for consistency
    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(5);
        MyClass obj2 = new MyClass(5);
        MyClass obj3 = new MyClass(10);

        // Using overloaded comparison operator ==
        Console.WriteLine("obj1 == obj2: " + (obj1 == obj2)); // true
        Console.WriteLine("obj1 == obj3: " + (obj1 == obj3));
        Console.WriteLine("obj1 != obj2: " + (obj1 != obj2));
        Console.WriteLine("obj1 != obj3: " + (obj1 != obj3));
    }
}