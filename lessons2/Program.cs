System.Console.WriteLine("С играем в угодай число?");
System.Console.WriteLine("Введите (yes/no или y/n) : ");
string? resultUser = System.Console.ReadLine();
if (!String.IsNullOrEmpty(resultUser))
{
    if (resultUser.ToLower() == "yes" || resultUser.ToLower() == "y")
    {
        var beginOfTheGame = true;

        var random = new Random();
        var hiddenNumber = random.Next(0, 100);
        System.Console.WriteLine(hiddenNumber + "\n");

        System.Console.WriteLine("Введите Ваше число : ");
        string? varUser = System.Console.ReadLine();

        if (!String.IsNullOrEmpty(varUser))
        {
            var numberUser = Int32.Parse(varUser);
            while (beginOfTheGame)
            {
                if (numberUser == hiddenNumber)
                {
                    System.Console.WriteLine("Вы выйграли, хотите продолжить еше?");
                    System.Console.Write("Введите (yes/no или y/n) : ");
                    string? str = System.Console.ReadLine();
                    beginOfTheGame = false;
                    if (!String.IsNullOrEmpty(str))
                    {
                        if (str.ToLower() == "yes" || str.ToLower() == "y")
                        {
                            System.Console.WriteLine(hiddenNumber + "\n");
                            hiddenNumber = random.Next(0, 100);
                            System.Console.Write("Введите число : ");
                            string? str1 = System.Console.ReadLine();
                            if (!String.IsNullOrEmpty(str1))
                            {
                                numberUser = Int32.Parse(str1);
                            }else{
                                System.Console.WriteLine("Вы ввели не корректные данные. в ведите чисоло: ");
                                str1 = System.Console.ReadLine();
                            }
                            
                        }
                        else
                        {
                            System.Console.WriteLine("Спасибо за игру!!!, игра закроется через 3 сек.");
                            Thread.Sleep(3000);
                            System.Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    System.Console.Write("Введите число : ");
                    string? str = System.Console.ReadLine();
                    if (!String.IsNullOrEmpty(str))
                    {
                        numberUser = int.Parse(str);
                    }else{
                        System.Console.WriteLine("Вы ввели не корректные данные. в ведите чисоло: ");
                        str = System.Console.ReadLine();
                    }
                }
            }
        }
        else
        {
            System.Console.Write("Введите число : ");
            varUser = System.Console.ReadLine();
        }
    }
    else if (resultUser.ToLower() == "no" || resultUser.ToLower() == "n")
    {
        System.Console.WriteLine("Вы не захотели играть. Игра закроется через 3 сек.");
        Thread.Sleep(3000);
        System.Environment.Exit(0);
    }
    else
    {
        System.Console.WriteLine("Не корректные данные, введите ответ корректный ответ.");
        System.Console.WriteLine("Введите (yes/no или y/n) : ");
        resultUser = System.Console.ReadLine();
    }
}
