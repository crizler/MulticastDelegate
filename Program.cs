using System;

namespace MulticastDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine = new RenderingEngine();
            Player player1 = new Player("Chris");
            Player player2 = new Player("Nick");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game has started ... Press any key to end the game.");


            Console.Read();

            GameEventManager.TriggerGameOver();

        }

    }
}
