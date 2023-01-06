// Interface: IEnumerable<T>
using System.Diagnostics;

var _1 = new List<int>();
var _2 = new Dictionary<int, int>();
var _3 = new HashSet<int>();
var _4 = new Queue<int>();
var _5 = new Stack<int>();
var _6 = new SortedSet<int>();
var _7 = new SortedList<int, int>();

int[] numbers = new int[] { 1, 5, 4, 2, 3 };
foreach(int number in numbers)
    Debug.WriteLine(number);

// Class: Enumerable
IEnumerable<int> enumerable1 = numbers;
IEnumerable<int> enumerable2 = enumerable1.Where(v => v > 2);
IEnumerable<int> enumerable3 = enumerable2.OrderBy(v => v);
int result1 = enumerable3.Count();
int result2 =numbers.Where(v => v > 2).OrderBy(v => v).Count();

// Interface: IQueryable<T>
IQueryable<int> queryable1 = numbers.AsQueryable();
IQueryable<int> queryable2 = queryable1.Where(v => v > 2);
IQueryable<int> queryable3 = queryable2.OrderBy(v => v);
int result3 = queryable3.Count();

Debug.WriteLine($"""

    queryable1
        ElementType: {queryable1.ElementType}
        Expression: {queryable1.Expression}
    """);

Debug.WriteLine($"""

    queryable2
        ElementType: {queryable2.ElementType}
        Expression: {queryable2.Expression}
    """);

Debug.WriteLine($"""

    queryable3
        ElementType: {queryable3.ElementType}
        Expression: {queryable3.Expression}

    """);    
