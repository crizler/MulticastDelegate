using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class GameEventManager
    {

        public delegate void GameEvent();

        public static event GameEvent OnGameStart, OnGameOver;

        // now we need to know what will happen if any event is triggered

        public static void TriggerGameStart()
        {
            if(OnGameStart != null)
            {
                Console.WriteLine("The game has started");
                //call the OnGameStart that will trigger all the methods subscribed to this event.
                OnGameStart();
            }
        }

        public static void TriggerGameOver()
        {
            if (OnGameOver != null)
            {
                Console.WriteLine("The game has stopped");
                //call the OnGameOver that will trigger all the methods subscribed to this event.
                OnGameOver();
            }
        }
    }
}
