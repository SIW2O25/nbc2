using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class Menu
    {
        public Player? Player = null;
        public Inventory? inventory = null;
        public Shop? shop = null;

        public void SetPlayer(Player player)
        {
            this.Player = player;
        }
       
        public void SetInventory(Inventory inventory)
        {
            this.inventory = inventory;
        }
        public void SetShop(Shop shop)
        {
            this.shop = shop;
        }
        public void DisplayMenu()
        {
            bool isRunning = true;
            do
            {
                Console.Clear(); // 화면 리셋
                Console.WriteLine("이세계 코딩 라이프!\n스파르타 마을에 오신 것을 환영합니다!");
                Console.WriteLine();
                Console.WriteLine("원하시는 정보를 입력 해주세요.");

                Console.WriteLine();
                Console.WriteLine("p: 캐릭터 정보");
                Console.WriteLine("i: 인벤토리");
                Console.WriteLine("s: 상점");
                Console.WriteLine("9: 던전");

                Console.WriteLine();
                Console.Write("Exit 'e'>>> ");


                string Input = Console.ReadLine();

                switch (Input)
                {
                    case "p":
                        if (Player != null)
                            Player.showPlayerInfo();
                        break;
                    case "i":
                        if (inventory != null)
                            inventory.showInventoryInfo();
                        break;
                    case "s":
                        if (shop != null)
                            shop.showShopInfo();
                        break;
                    case "9":
                        Console.WriteLine("던전");
                        break;
                    case "e":
                        isRunning = false;
                        break;
                    default:
                        GameManager.ErrorMessage("잘못된 접근입니다. 이전으로 가러면 '0' 키를 눌러주세요.");
                        break;
                }
            }
            while (isRunning);


        }
    }
}