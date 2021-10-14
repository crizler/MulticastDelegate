using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class AudioSystem
    {

        public AudioSystem()
        {
            // the + operator needs to exist because we want OnGameStart and OnGameOver  
            // to keep their subscribed methods and add one more method
            // if we skip the + then the only subscribed method will be the StartGame in the AudioSystem class
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;

        }

        private void StartGame()
        {
            Console.WriteLine("Audio System started");
        }

        private void GameOver()
        {
            Console.WriteLine("Audio System stopped");
        }
    }
}
