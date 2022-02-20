/**
*** игра Угадай число, при запруске игры загадывается число
*** участник угадывает, если не совпадений то у него есть еще попытка,
*** выход когда выигрывает, небходмо подсчитать количество ходов
**/



System.Console.WriteLine("Добро пожаловать в игру \"Угадай число\".");
System.Console.WriteLine("Правила: \n \t\t 1. При запуске генерируется рандомное число от 0 до 100.\n" +
                                    " \t\t 2. Участник должен угодать это число.\n" +
                                    " \t\t Удачи");
var isStartGame = true;
var isBeginUser = true;
var outDefault = 0;
do
{
    var randomNumber = new Random()
                            .Next(0, 100);
    System.Console.WriteLine($"Число успешно загадан {randomNumber.ToString()}");
    while (isBeginUser)
    {
        string? inputValue = System.Console.ReadLine();
        if (!String.IsNullOrEmpty(inputValue))
        {
            int userNumber = int.TryParse(inputValue, out outDefault);
            if (userNumber != outDefault)
            {
                
            }
        }
    }
} while (isStartGame);