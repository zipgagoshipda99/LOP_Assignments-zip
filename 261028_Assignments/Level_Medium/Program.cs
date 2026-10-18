namespace Level_Medium;

class Program
{
/*  난이도 중 - 연속된 구간의 최대 합
    정수 N개로 이루어진 배열이 주어진다. 배열에서 연속된 하나 이상의 원소를 선택했을 때 얻을 수 있는 합의 최댓값을 구하는 프로그램을 작성하시오.
    선택한 원소들은 배열에서 서로 붙어 있어야 한다.

    [조건]
    N은 1 이상 100,000 이하의 정수이다.
    각 정수의 범위는 -1,000 이상 1,000 이하이다.
    반드시 하나 이상의 원소를 선택해야 한다.
    모든 숫자가 음수인 경우에도 올바르게 처리해야 한다.
    입력 크기가 커도 효율적으로 동작하도록 구현한다.

    [입력]
    첫째 줄에 정수 N이 주어진다.
    둘째 줄에 N개의 정수가 공백으로 구분되어 주어진다.

    [출력]
    연속된 구간의 합 중 최댓값을 출력한다.

    [예시]
    입력:
    8
    -2 3 -1 5 -6 4 2 -1

    출력:
    7

    [추가 예시]
    입력:
    5
    -8 -3 -6 -2 -5

    출력:
    -2
    */
    static void Main(string[] args)
    {
        nCount count = new nCount();
        ArrayManager arrayManager = new ArrayManager();
        count.SetCount();
        arrayManager.AddRandomizedNumbers2List(count);
        arrayManager.checkConsecutiveElements();
        arrayManager.GetHighestTotal();
    }
}
