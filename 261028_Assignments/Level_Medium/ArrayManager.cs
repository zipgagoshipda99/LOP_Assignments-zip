namespace Level_Medium
{
    public class ArrayManager
    {
        List<int> intList = new List<int>();
        Random random = new Random();
        List<int> randomNumberList = new List<int>();
        List<int> allTotals = new List<int>();
        int highestTotal = 0;
        public void AddRandomizedNumbers2List(nCount n)
        {
            for (int i = 0; i < n.GetCount(); i++)
            {
                int randNum = random.Next(-1000, 1001);
                randomNumberList.Add(randNum);
                if (i == n.GetCount() - 1)
                    Console.Write($"{randNum}");
                else
                Console.Write($"{randNum}, ");
            }
            Console.WriteLine("\n");
        }

        public void checkConsecutiveElements()
        {

            // 연속된 하나 이상의 원소를 선택했할 수 있는 경우의 수 (배열 크기가 5일때)
            //1개짜리 구간  = 5가지 , 2개짜리 구간 = 4가지, 3개짜리 구간  = 3가지, 4개짜리 구간 = 2가지, 5개짜리 구간 = 1가지
            // 연속 구간을 고르는 경우의 수를 구하는 수학 공식 N * (N + 1) / 2
            // for (int i = 0; (i < randomNumberList.Count * (randomNumberList.Count + 1) / 2); i++)
            // 위에 공식 성공 못함

            //컬렉션 슬라이싱 arr[start..end-1]
            for (int i = 0; i <= randomNumberList.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int total = 0;
                //1이상 연속되며 서로 붙어있는 배열의 요소들을 원래 배열에서 슬라이싱하고 새로운 배열로 초기화 하기
                    List<int> firsthalf = randomNumberList[j..i];
                // 슬라이싱 한 배열을 foreach문으로 각 요소를 합계에 더함.
                    foreach (int element in firsthalf)
                    {
                        total += element;
                    }
                    allTotals.Add(total); //현재 이 슬라이싱 배열에 요소 합계를 합계만 모으는 리스트에 추가
                }
            }
        }

         //슬라이싱 리스트 요소 합계 모음 리스트에서 가장 큰 수 찾는 메소드.
        public int GetHighestTotal()
        {
            //int.Minvalue == 32비트 정수가  가질 수 있는 최소값.
            // allTotals 리스트 요소들이 음수도 있을수도 있으니 최소값으로 설정. 
            int currentTotal = int.MinValue;  
            
            foreach (int total in allTotals)
            {
                if (total > currentTotal) // foreach 문으로 AllTotals 리스트의 요소들 total을 최소값으로 설정한 변수와 비교.
                //total 이 currentTotal 보다 크면
                {
                    currentTotal = total; //currentTotal 이 total이도록 지정
                }
                highestTotal = currentTotal;
                //조건 다 검사했으면 가장큰 합계를 현재 합계로 지정.
            }
            Console.WriteLine(highestTotal);
            return highestTotal;
        }
    }
}