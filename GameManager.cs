namespace Player
{
    public class GameManager
    {
        public static void ErrorMessage(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Player player = new Player();
            player.SetPlayerInfo(15, "보리스", "검사", 35, 26, 450, 50000);

            Inventory inventory = new Inventory();
            inventory.SetInventoryInfo("[Sell]등급(노멀) | 내구도 30/100 | 공격력 +5 | 데미지 8~16", "[Sell]등급(노멀) | 내구도 80/100 | 방어력 +15", "[Sell]등급(레어) | 내구도 100/100 | 방어력 + 35", "100 | 회복력", "40 | 회복력");

            Shop shop = new Shop();
            shop.SetShopInfo("(소) | 1000 G", "(소) | 1200G ", "방어력 +5 | 500G", "공격력 +3 | 데미지 1~6 | 800G");

            Menu menu = new Menu();
            menu.SetPlayer(player);
            menu.SetInventory(inventory);
            menu.SetShop(shop);
            menu.DisplayMenu();

        }
    }
   
}
