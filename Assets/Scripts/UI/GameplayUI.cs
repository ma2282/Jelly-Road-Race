using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay
{
    public class GameplayUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreText;
        [SerializeField] private TextMeshProUGUI coinsText;
        
        private int _score;
        private int _coins;

        private void Start()
        {
            LayoutRebuilder.ForceRebuildLayoutImmediate(scoreText.rectTransform);
            LayoutRebuilder.ForceRebuildLayoutImmediate(coinsText.rectTransform);
        }

        public void Initialize()
        {}

        public void ChangeCoins(int coins)
        {
            _coins = coins;
            coinsText.text = _coins.ToString();
        }

        public void ChangeScore(int score)
        {
            _score = score;
            scoreText.text = _score.ToString();
        }
    }
}