namespace Test_4
{
    internal class Program
    {
        // 문제 설명
        // 정수 배열 array가 매개변수로 주어질 때,
        // 가장 큰 수와 그 수의 인덱스를 담은 배열을 return 하도록 solution 함수를 완성해보세요.

        // 입출력 예
        // array             result
        // [1, 8, 3]         [8, 1]
        // [9, 10, 11, 8]    [11, 2]

        public class Solution
        {
            public int[] solution(int[] array)
            {
                int[] answer = new int[2];

                int maxValue = -1;
                int maxIndex = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (maxValue < array[i])
                    {
                        maxValue = array[i];
                        maxIndex = i;
                    }
                }

                answer[0] = maxValue;
                answer[1] = maxIndex;

                return answer;
            }
        }
    }
}
