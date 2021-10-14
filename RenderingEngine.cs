using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class RenderingEngine
    {

        public RenderingEngine()
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        private void StartGame()
        {
            Console.WriteLine("Rendering Engine started");
        }

        private void GameOver()
        {
            Console.WriteLine("Rendering Engine stopped");
        }
    }
}
