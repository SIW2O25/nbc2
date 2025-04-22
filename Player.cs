
namespace Player
{
    public class Player
    {
        public int level;
        public string name;
        public string job;
        public int strength;
        public int defensive;
        public int Hp;
        public int money;

        public void SetPlayerInfo(int level, string name, string job, int strength, int defensive, int Hp, int money)
        {
            this.level = level;
            this.name = name;
            this.job = job;
            this.strength = strength;
            this.defensive = defensive;
            this.Hp = Hp;
            this.money = money;
        }

        public void showPlayerInfo()
        {
            bool isRunning = true;

            do
            {
                Console.Clear();
                Console.WriteLine("캐릭터 정보");
                Console.WriteLine($"레벨: {level}");
                Console.WriteLine($"이름: {name}");
                Console.WriteLine($"직업: {job}");
                Console.WriteLine($"공격력: {strength}");
                Console.WriteLine($"방어력: {defensive}");
                Console.WriteLine($"체력: {Hp}");
                Console.WriteLine($"골드: {money}");

                Console.WriteLine();
                Console.WriteLine("p: 나가기(방향키 또는 단축키 입력)");
                Console.Write(">>> ");

                string Input = Console.ReadLine();
                {
                    switch (Input)
                    {
                        case "p":
                            isRunning = false;
                            break;
                        default:
                            GameManager.ErrorMessage("잘못된 접근입니다. 이전으로 가러면 '0' 키를 눌러주세요.");
                            break;
                    }
                }

            } while (isRunning);

        }
    }
}