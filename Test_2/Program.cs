using System;

namespace Test_2
{
    // 문제 설명
    // 문자열 str과 정수 n이 주어집니다.
    // str이 n번 반복된 문자열을 만들어 출력하는 코드를 작성해 보세요.

    // 입출력 예
    // 입력 #1        string 5

    //출력 #1         stringstringstringstringstring

    public class Example
    {
        public static void Main()
        {
            String[] input;

            Console.Clear();
            input = Console.ReadLine().Split(' ');  // 문자를 입력해 준다

            String s1 = input[0];                   // s1 에 string 입력

            int a = Int32.Parse(input[1]);          // a 에 5 입력

            for (int i = 0; i < a; i++)             // 반복
            {
                Console.Write(s1);                  // 출력
            }

        }
    }
}
