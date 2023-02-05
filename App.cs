public class Phone
{   
    public double time;
    public double price;
    public int dayofweek;
    public double Summ()
    {
        double result = time * price;
        if (dayofweek == 6 || dayofweek == 7)
        {
            result *= 0.9;
            return result;
        }
            
        else return result;
    }
}
public class Square
{
    public void Repeat()
    {
        int Pow;
        for (int i = 0; i <= 10; i++)
        {
            Pow = Convert.ToInt32(Math.Pow(i, 2));
            Console.WriteLine($"{i}({Pow})  ");
            StopSquare stop1 = new StopSquare();
            stop1.Stop(Pow);
        }
    }
}

public class StopSquare
{
    public void Stop(int number)
    {
 
        
            if (number > 25)
            {
                Console.WriteLine("Квадрат числа больше 25!");

            }
        
    }
}

public class App
{
    static void Main()
    {
        static void Zadanie1()
        {
            while (true)
            {


                try
                {
                    Phone phone = new Phone();
                    while (phone.dayofweek < 1 || phone.dayofweek > 7)
                    {
                        Console.WriteLine("Введите день недели разговора: ");
                        phone.dayofweek = Convert.ToInt32(Console.ReadLine());
                        if (phone.dayofweek < 1 || phone.dayofweek > 7) Console.WriteLine("день не может быть меньше 1 или больше 7");

                    }
                    Console.WriteLine("Введите время разговора: ");
                    phone.time = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите стоимость минуты:");
                    phone.price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Стоимость разговора: {phone.Summ()} руб");
                    break;
                }
                catch
                {
                    Console.WriteLine("Вы ввели не число");
                }
            }
        }
        Zadanie1();

        static void Zadanie2()
        {
            try
            {
                Square cycle = new Square();
                cycle.Repeat();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка!");
            }
        }
        Zadanie2();

    }

}