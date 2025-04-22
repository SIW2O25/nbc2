namespace Player
{
    public class Inventory
    {
        public string halberd;
        public string breastplate;
        public string helmet;
        public string healthPotion;
        public string manaPotion;
       
        public void SetInventoryInfo(string halberd, string breastplate, string helmet, string healthPotion, string manaPotion)
        {
            this.halberd = halberd;
            this.breastplate = breastplate;
            this.helmet = helmet;
            this.healthPotion = healthPotion;
            this.manaPotion = manaPotion;
        }

        public void showInventoryInfo()
        {
            bool isRunning = true;

            do
            {
                Console.Clear();
                Console.WriteLine("가지고 있는 물건");
                Console.WriteLine($"미늘창: {halberd}");
                Console.WriteLine($"미늘흉갑: {breastplate}");
                Console.WriteLine($"마석투구: {helmet}");
                Console.WriteLine($"힐링포션: {healthPotion}");
                Console.WriteLine($"마력포션: {manaPotion}");

                Console.WriteLine();
                Console.WriteLine("i: 나가기(방향키 또는 단축키 입력)");
                Console.Write(">>> ");

                string Input = Console.ReadLine();
                {
                    switch (Input)
                    {
                        case "i":
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
