namespace GameConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   //var player = new PlayerCharacter();
            //   //player.DaysSinceLastLogin = 44;
            //   //int days = player?.DaysSinceLastLogin ?? -1;
            //   //Console.WriteLine($"{days} day(s) since last login");

            //   //PlayerDisplayer.Write(player);

            //   //Console.ReadLine();

            //   PlayerCharacter[] players = new PlayerCharacter[3]
            //   {
            //       new PlayerCharacter {Name = "Sarah"},
            //       new PlayerCharacter(), //Name = null
            //null //PlayerCharacter = null
            //   };

            //   //PlayerCharacter[] players = null;

            //   string p1 = players?[0]?.Name;
            //   string p2 = players?[1]?.Name;
            //   string p3 = players?[2]?.Name;

            

            PlayerCharacter sarah = new PlayerCharacter(new DiamondSkinDefense())
            {
                Name = "Sarah"
            };
            
            PlayerCharacter amrit = new PlayerCharacter(new IronBonesDefense())
            {
                Name = "Amrit"
            };
            
            PlayerCharacter gentry = new PlayerCharacter(new IronBonesDefense())
            {
                Name = "Gentry"
            };


            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);

           Console.ReadLine();
        }
    }
}