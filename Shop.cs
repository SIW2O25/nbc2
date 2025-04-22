namespace Player
{
    public class Shop
    {
        public string healthpotion;
        public string manapotion;
        public string beginnerShield;
        public string beginnerSword;
    
    
        public void SetShopInfo(string healthpotion, string manapotion, string beginnerShield, string beginnerSword)
        {
            this.healthpotion = healthpotion;
            this.manapotion = manapotion;
            this.beginnerShield = beginnerShield;
            this.beginnerSword = beginnerSword;
        }

        public void showShopInfo()
        {
            bool isRunning = true;

            do
            {
                Console.Clear();
                Console.WriteLine("판매상품");

                Console.WriteLine();
                Console.WriteLine($"힐링포션: {healthpotion}");
                Console.WriteLine($"마나포션: {manapotion}");
                Console.WriteLine($"초심자 방패: {beginnerShield}");
                Console.WriteLine($"초심자 검: {beginnerSword}");

                Console.WriteLine();
                Console.WriteLine("s: 나가기(방향키 또는 단축키 입력)");
                Console.Write(">>> ");

                string Input = Console.ReadLine();
                {
                    switch (Input)
                    {
                        case "s":
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
