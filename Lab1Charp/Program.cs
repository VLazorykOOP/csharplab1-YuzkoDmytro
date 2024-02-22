static void task1()
{
Console.WriteLine("Task 1");
Console.Write("Введіть довжину сторони трикутника: ");
        if (!double.TryParse(Console.ReadLine(), out double sideLength) || sideLength <= 0)
        {
            Console.WriteLine("Довжина сторони повинна бути додатнім числом.");
            return;
        }

        double radius = sideLength / (2 * Math.Sin(Math.PI / 3));
        Console.WriteLine($"Радіус кола, описаного навколо трикутника зі стороною {sideLength}, дорівнює: {radius}");
}

static void task2()
{
        Console.WriteLine("Task 2");
        Console.Write("Введіть довжину сторони a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введіть довжину сторони b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введіть довжину сторони c: ");
        double c = double.Parse(Console.ReadLine());

        bool isRightTriangle = a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a;

        if (isRightTriangle)
            Console.WriteLine("Трикутник є прямокутним.");
        else
            Console.WriteLine("Трикутник не є прямокутним.");
}

static void task3()
{
        Console.WriteLine("Task 4");
        double x = 11;
        double y = 5;
        double centerX = 5;
        double centerY = 5;
        double radius = 5;
        double distance = Math.Sqrt(Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2));
        
        if (distance < radius)
        {
            Console.WriteLine("Так, точка лежить всередині заштрихованої області.");
        }
        else if (distance > radius)
        {
            Console.WriteLine("Ні, точка лежить поза заштрихованою областю.");
        }
        else
        {
            Console.WriteLine("На межі, точка лежить на межі заштрихованої області.");
        }
}

static void task4()
{
    Console.WriteLine("Task 4");
        var tvChannels = new Dictionary<int, List<string>>
        {
            {1, new List<string>{"Новини", "Спорт", "Фільми"} },
            {2, new List<string>{"Дитячі мультфільми", "Розважальні шоу", "Серіали"} },
        };

        Console.Write("Введіть номер телевізійного каналу: ");
        int channelNumber = int.Parse(Console.ReadLine());
        
        if (tvChannels.ContainsKey(channelNumber))
        {
            Console.WriteLine($"Найпопулярніші програми для каналу {channelNumber}:");
            foreach (var program in tvChannels[channelNumber])
            {
                Console.WriteLine(program);
            }
        }
        else
        {
            Console.WriteLine("Канал з таким номером не знайдено.");
        }
}

static int sub(int a, int b) {
    return a - b;
}

static void task5() {
    Console.WriteLine("Task5");
    static int CubeSum(int a, int b)
    {
        int sum = a + b;
        return sum * sum * sum;
    }
        Console.Write("Введіть перше ціле число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Введіть друге ціле число: ");
        int num2 = int.Parse(Console.ReadLine());

        int result = CubeSum(num1, num2);
        Console.WriteLine($"Куб суми чисел {num1} і {num2} дорівнює: {result}");
}

static void task6() {
    Console.WriteLine("Task 6");
    Console.Write("Enter x=");
    string? str = Console.ReadLine();
    float x = 0;
    float y = 0;
    if (str != null) x = float.Parse(str);
    Console.Write("Enter y=");
    str = Console.ReadLine();
    if (str != null) y = float.Parse(str);
    double result = (1/(x*y) + 1/(Math.Pow(x, 2) + 1))*(x+y);
    Console.WriteLine("The result is " + result);

}

Console.WriteLine("Lab 1 !");
//task1();
//task2();
//task3();
//task4();
//task5();
task6();
