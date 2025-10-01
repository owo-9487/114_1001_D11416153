using System;
using System.Collections.Generic;
using System.Linq;

// Sample enum and struct used in examples
[Flags]
enum FilePermissions { None = 0, Read = 1, Write = 2, Execute = 4 }

enum SampleColor { Red, Green, Blue }

struct Point { public int X; public int Y; public override string ToString() => $"({X}, {Y})"; }

class Program
{
    static void Main()
    {
        Console.WriteLine("C# 變數與資料類型：50 個範例\n");

        // 1. int
        int ex1 = 42; Console.WriteLine($"1. int ex1 = {ex1} (Type: {ex1.GetType()})");

        // 2. long
        long ex2 = 1234567890123L; Console.WriteLine($"2. long ex2 = {ex2} (Type: {ex2.GetType()})");

        // 3. short
        short ex3 = 32000; Console.WriteLine($"3. short ex3 = {ex3} (Type: {ex3.GetType()})");

        // 4. byte
        byte ex4 = 255; Console.WriteLine($"4. byte ex4 = {ex4} (Type: {ex4.GetType()})");

        // 5. sbyte
        sbyte ex5 = -100; Console.WriteLine($"5. sbyte ex5 = {ex5} (Type: {ex5.GetType()})");

        // 6. uint
        uint ex6 = 4000000000U; Console.WriteLine($"6. uint ex6 = {ex6} (Type: {ex6.GetType()})");

        // 7. ulong
        ulong ex7 = 12345678901234567890UL; Console.WriteLine($"7. ulong ex7 = {ex7} (Type: {ex7.GetType()})");

        // 8. float
        float ex8 = 3.14f; Console.WriteLine($"8. float ex8 = {ex8} (Type: {ex8.GetType()})");

        // 9. double
        double ex9 = 2.718281828459; Console.WriteLine($"9. double ex9 = {ex9} (Type: {ex9.GetType()})");

        // 10. decimal
        decimal ex10 = 1.234567890123456789m; Console.WriteLine($"10. decimal ex10 = {ex10} (Type: {ex10.GetType()})");

        // 11. char
        char ex11 = '中'; Console.WriteLine($"11. char ex11 = {ex11} (Type: {ex11.GetType()})");

        // 12. string
        string ex12 = "Hello, 世界"; Console.WriteLine($"12. string ex12 = {ex12} (Type: {ex12.GetType()})");

        // 13. bool
        bool ex13 = true; Console.WriteLine($"13. bool ex13 = {ex13} (Type: {ex13.GetType()})");

        // 14. object (boxing)
        object ex14 = "I am an object"; Console.WriteLine($"14. object ex14 = {ex14} (Type: {ex14.GetType()})");

        // 15. dynamic
        dynamic ex15 = 123; Console.WriteLine($"15. dynamic ex15 = {ex15} (Type at runtime: {ex15.GetType()})"); ex15 = "now a string"; Console.WriteLine($"   dynamic now = {ex15} (Type at runtime: {ex15.GetType()})");

        // 16. var (type inference)
        var ex16 = 99; Console.WriteLine($"16. var ex16 = {ex16} (Inferred Type: {ex16.GetType()})");

        // 17. nullable types
        int? ex17 = null; Console.WriteLine($"17. int? ex17 has value: {ex17.HasValue}"); ex17 = 5; Console.WriteLine($"   after assign: {ex17} (HasValue: {ex17.HasValue})");

        // 18. DateTime
        DateTime ex18 = DateTime.Now; Console.WriteLine($"18. DateTime ex18 = {ex18}");

        // 19. TimeSpan
        TimeSpan ex19 = TimeSpan.FromMinutes(90); Console.WriteLine($"19. TimeSpan ex19 = {ex19}");

        // 20. Guid
        Guid ex20 = Guid.NewGuid(); Console.WriteLine($"20. Guid ex20 = {ex20}");

        // 21. enum
        SampleColor ex21 = SampleColor.Green; Console.WriteLine($"21. enum SampleColor ex21 = {ex21}");

        // 22. struct
        Point ex22 = new Point { X = 3, Y = 4 }; Console.WriteLine($"22. struct Point ex22 = {ex22}");

        // 23. tuple (ValueTuple)
        var ex23 = (Name: "Alice", Age: 30); Console.WriteLine($"23. tuple ex23 = {ex23.Name}, {ex23.Age}");

        // 24. array
        int[] ex24 = { 1, 2, 3 }; Console.WriteLine($"24. array ex24 = [{string.Join(',', ex24)}]");

        // 25. multi-dimensional array
        int[,] ex25 = { { 1, 2 }, { 3, 4 } }; Console.WriteLine($"25. 2D array ex25[1,1] = {ex25[1, 1]}");

        // 26. jagged array
        int[][] ex26 = new int[][] { new[] { 1, 2 }, new[] { 3 } }; Console.WriteLine($"26. jagged ex26[0][1] = {ex26[0][1]}");

        // 27. List<T>
        List<string> ex27 = new List<string> { "A", "B" }; Console.WriteLine($"27. List ex27 = [{string.Join(',', ex27)}] (Count: {ex27.Count})");

        // 28. Dictionary<K,V>
        Dictionary<string, int> ex28 = new Dictionary<string, int> { ["one"] = 1, ["two"] = 2 }; Console.WriteLine($"28. Dictionary ex28['two'] = {ex28["two"]}");

        // 29. HashSet<T>
        HashSet<int> ex29 = new HashSet<int> { 1, 2, 2 }; Console.WriteLine($"29. HashSet ex29 contains 2? {ex29.Contains(2)} (Count: {ex29.Count})");

        // 30. Queue<T>
        Queue<double> ex30 = new Queue<double>(new[] { 1.1, 2.2 }); ex30.Enqueue(3.3); Console.WriteLine($"30. Queue peek = {ex30.Peek()} (Count: {ex30.Count})");

        // 31. Stack<T>
        Stack<char> ex31 = new Stack<char>(new[] { 'x', 'y' }); ex31.Push('z'); Console.WriteLine($"31. Stack pop = {ex31.Pop()} (Now top = {ex31.Peek()})");

        // 32. const
        const double ex32 = 3.141592653589793; Console.WriteLine($"32. const double ex32 = {ex32}");

        // 33. string interpolation
        string ex33 = $"Pi approx {ex32:F3}"; Console.WriteLine($"33. interpolation ex33 = {ex33}");

        // 34. binary literal
        int ex34 = 0b1010; Console.WriteLine($"34. binary literal ex34 = {ex34}");

        // 35. hex literal
        int ex35 = 0xFF; Console.WriteLine($"35. hex literal ex35 = {ex35}");

        // 36. using statement with disposable
        using var ex36Reader = new System.IO.StringReader("sample"); string ex36 = ex36Reader.ReadToEnd(); Console.WriteLine($"36. using var read = {ex36}");

        // 37. Func<T,R> delegate and lambda
        Func<int, int> ex37 = x => x * x; Console.WriteLine($"37. Func lambda ex37(5) = {ex37(5)}");

        // 38. Action delegate
        Action ex38 = () => Console.WriteLine("38. Action lambda says hello"); ex38();

        // 39. FilePermissions [Flags] enum
        FilePermissions ex39 = FilePermissions.Read | FilePermissions.Write; Console.WriteLine($"39. Flags enum ex39 = {ex39}");

        // 40. boxing and unboxing
        int ex40a = 123; object ex40b = ex40a; int ex40c = (int)ex40b; Console.WriteLine($"40. boxed {ex40b} unboxed {ex40c}");

        // 41. pattern matching
        object ex41 = 3.14; if (ex41 is double ex41d) Console.WriteLine($"41. pattern matched double = {ex41d}");

        // 42. nameof operator
        var ex42 = nameof(ex24); Console.WriteLine($"42. nameof ex24 = {ex42}");

        // 43. default
        int ex43 = default; Console.WriteLine($"43. default int ex43 = {ex43}");

        // 44. sizeof for built-in types
        int ex44 = sizeof(int); Console.WriteLine($"44. sizeof(int) = {ex44} bytes");

        // 45. parse string to int
        string ex45Str = "123"; int ex45 = int.Parse(ex45Str); Console.WriteLine($"45. parsed ex45 = {ex45}");

        // 46. ToString formatting
        double ex46 = 3.14159; string ex46s = ex46.ToString("F2"); Console.WriteLine($"46. formatted ex46 = {ex46s}");

        // 47. LINQ example (needs System.Linq)
        var ex47 = ex24.Where(x => x % 2 == 0).ToArray(); Console.WriteLine($"47. LINQ evens from ex24 = [{string.Join(',', ex47)}]");

        // 48. reflection (Type)
        Type ex48 = typeof(List<int>); Console.WriteLine($"48. typeof(List<int>) full name = {ex48.FullName}");

        // 49. Convert.ChangeType
        object ex49Obj = "456"; int ex49 = (int)Convert.ChangeType(ex49Obj, typeof(int)); Console.WriteLine($"49. Convert.ChangeType result = {ex49}");

        // 50. anonymous object
        var ex50 = new { Name = "Bob", Score = 99 }; Console.WriteLine($"50. anonymous ex50 = {ex50.Name}, {ex50.Score}");

        Console.WriteLine("\n範例結束。請依序閱讀每個範例並嘗試修改值以練習不同的資料類型。");
    }
}
