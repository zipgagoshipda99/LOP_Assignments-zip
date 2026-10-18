using System.Xml;

namespace Level_Easy;

class AnalyzeArrayOfNumbers
{
    /*난이도 하 - 숫자 배열 분석하기
    정수 N개가 주어진다. 주어진 숫자 중에서 짝수의 개수, 홀수의 개수, 가장 큰 수를 구하는 프로그램을 작성하시오.
    숫자는 음수와 0을 포함할 수 있다.

    [조건]
    N은 1 이상 1,000 이하의 정수이다.
    각 정수의 범위는 -10,000 이상 10,000 이하이다.
    배열을 순회하며 짝수와 홀수를 구분한다.
    가장 큰 수를 정확하게 찾아야 한다.

    [입력]
    첫째 줄에 정수 N이 주어진다.
    둘째 줄에 N개의 정수가 공백으로 구분되어 주어진다.

    [출력]
    짝수의 개수, 홀수의 개수, 가장 큰 수를 순서대로 출력한다.
    */
    static void Main(string[] args)
    {
        int count = 0;
        bool isParsed = int.TryParse(Console.ReadLine(), out count);
        if (!isParsed) return;
        List<int> randomNumbers = new List<int>();
        List<int> evenNumbers = new List<int>();
        List<int> oddNumbers = new List<int>();

        int currentNumber = 0;
        RandomizeNumbers(count, currentNumber, randomNumbers);
        int highestNumber = randomNumbers[0];
        CheckThenCatogorizeNumbers(highestNumber, randomNumbers, evenNumbers, oddNumbers);
        Console.WriteLine($"짝수의 개수: {evenNumbers.Count} , 홀수의 개수: {oddNumbers.Count} , 가장 큰 수: {highestNumber} ");
    }
    static void CheckThenCatogorizeNumbers(int highestNumber, List<int> randomNumbers, List<int> evenNumbers, List<int> oddNumbers)
    {
        foreach (int number in randomNumbers)
        {
            if (number > highestNumber)
            {
                highestNumber = number;

            }
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
            // else if (num % 2 == 1 || num % 2 == -1)
            else
            {
                oddNumbers.Add(number);
            }
        }
    }
    static void RandomizeNumbers(int count, int currentNumber, List<int> randomNumbers)
    {
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            currentNumber = random.Next(-10000, 10001);
            Console.WriteLine($"{currentNumber}");
            randomNumbers.Add(currentNumber);
        }
    }
}
