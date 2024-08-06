namespace _240806_1
{
    // 문제 설명
    // 정수 num1과 num2가 매개변수로 주어집니다.
    // 두 수가 같으면 1 다르면 -1을 retrun하도록 solution 함수를 완성해주세요.

    // 입출력 예
    // num1  num2  result
    //   2	   3	-1
    //  11	  11	 1
    //   7	  99	-1


    public class Solution
    {
        public int solution(int num1, int num2)
        {
            int answer = 0;

            if (num1 != num2)              // num1과 num2가 다르면 -1을 출력
            {
                answer = -1;
                Console.WriteLine(answer);
            }
            else if (num1 == num2)         // num1과 num2가 같으면 1을 출력
            {
                answer = 1;
                Console.WriteLine(answer);
            }

            return answer;                 // answer에 대한 출력을 해준다.
        }
    }
}
