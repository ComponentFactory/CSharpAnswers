using System.Linq.Expressions;

namespace _0026_lambda_expression_property;

internal class Program
{
    private static void Main()
    {
        var x = new Example();
        x.Age = 42;
    }
}

public class Example
{
    private int? _age;
    public int? Age
    {
        get { return _age; }
        set
        {
            _age = value;
            OnPropertyChanged("Age");
            OnPropertyChanged(nameof(Age));
            OnPropertyChanged(x => x.Age);
        }
    }

    private static void OnPropertyChanged(string propertyName)
    {
        Console.WriteLine($"'{propertyName}' changed");
    }

    private static void OnPropertyChanged<T>(Expression<Func<Example, T>> action)
    {
        var expression = (MemberExpression)action.Body;
        string propertyName = expression.Member.Name;
        OnPropertyChanged(propertyName);
    }
}