using NTC.Global.System;
using UnityEngine;

namespace Game.Gameplay
{
    public class GameManager : Singleton<GameManager>
    {
        [SerializeField] private Player player;

        public Player Player => player;
    }
}