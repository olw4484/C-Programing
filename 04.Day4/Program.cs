﻿class Progarm
{
    private static int _repeatCount = 0;

    static void Main(string[] args)
    {
        // Main 함수의 내용은 변경하지 않습니다.
        // Main 이외의 함수(IsZero, InputPlayerHealth, PrintPlayerHealth)를 완성하시면 됩니다.
        int playerHealth;

        while (true)
        {
            _repeatCount++;

            playerHealth = InputPlayerHealth();

            PrintRepeatCount();

            if (IsZero(playerHealth))
            {
                Console.WriteLine("Game Over - 게임 종료");
                break;
            }
        }
    }

    static bool IsZero(int value) // bool 타입의 데이터를 반환
    {
        if (value <= 0)
        {
            return true; // 매개변수로 입력받은 데이터가 0 이하라면 true 반환
        }
        else
        {
            return false; // 매개변수로 입력받은 데이터가 0 초과라면 false 반환
        }
    }

    static int InputPlayerHealth()
    {
        do
        {
            Console.WriteLine("숫자를 입력해주세요.");
            string? input = Console.ReadLine(); // Console.ReadLine()을 사용해 사용자 입력 받기
            int health;
            bool right = int.TryParse(input, out health); // 숫자가 정상적으로 입력된 경우 int 타입으로 변환해 반환


            if (right && health >= 0 && health <= 100) // 0이상 100 이하의 숫자 외의 데이터가 입력된 경우 숫자를 입력받을 때 까지 반복해서 입력 받기
            {
                Console.WriteLine("입력하신 숫자는 {0}입니다.", health);
                return health;
            }
            else
            {
                Console.WriteLine("유효하지 않은 입력입니다. 다시 입력해주세요.");
            }
        }
        while (true);




    }

    static void PrintRepeatCount()
    {
        Console.WriteLine($"반복문이 출력된 횟수는 {_repeatCount} 입니다."); // 반복문이 몇 번 출력되었는지 출력한다
        // 출력 양식 : "반복문이 출력된 횟수는 {_repeatCount} 입니다."
    }
}