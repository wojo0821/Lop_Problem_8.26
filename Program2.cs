using System;

class Program2
{
    static void Main2()
    {
        Random random = new Random();

        int[] answer = new int[3];

        for (int i = 0; i < 3; i++)
        {
            if (i == 0)
            {
                answer[i] = random.Next(1, 10);
            }
            else
            {
                answer[i] = random.Next(0, 10);
            }

            // 이전에 뽑은 숫자들과 중복되는지 확인
            for (int j = 0; j < i; j++)
            {
                if (answer[i] == answer[j])
                {
                    i--;
                    break;
                }
            }
        }

        int tryCount = 0;
        while (true)
        {
            Console.Write("사용자 입력: ");
            string? input = Console.ReadLine();

            // 유효성 검사 (3자리 숫자인지 확인)
            if (string.IsNullOrEmpty(input) || input.Length != 3 || !int.TryParse(input, out _))
            {
                Console.WriteLine("3자리 숫자를 올바르게 입력해주세요.\n");
                continue;
            }

            tryCount++;

            int[] guess = new int[3];
            for (int i = 0; i < 3; i++)
            {
                guess[i] = input[i] - '0';
            }

            // 3. Strike와 Ball 판정
            int strikes = 0;
            int balls = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (guess[i] == answer[j])
                    {
                        if (i == j)
                        {
                            strikes++; // 숫자와 자릿수가 모두 같음
                        }
                        else
                        {
                            balls++;   // 숫자는 같지만 자릿수가 다름
                        }
                    }
                }
            }

            // 4. 결과 출력
            if (strikes == 3)
            {
                Console.WriteLine($"결과: 정답입니다 (총 시도 횟수: {tryCount}회)");
                break;
            }
            else
            {
                Console.WriteLine($"결과: {strikes} Strike, {balls} Ball\n");
            }
        }
    }
}