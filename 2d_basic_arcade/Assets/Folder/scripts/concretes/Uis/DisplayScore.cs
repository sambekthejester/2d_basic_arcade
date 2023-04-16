using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace UdemyDeneme01.Uis
{
    public class DisplayScore : MonoBehaviour
    {
        TextMeshProUGUI _scoreText;

        private void Awake()
        {
            _scoreText = GetComponent<TextMeshProUGUI>();
        }

        private void Start()
        {
            GameManager.Instance.OnScoreChange += HandleOnScoreChange;
            HandleOnScoreChange();
        }
        private void OnDisable()
        {
            GameManager.Instance.OnScoreChange -= HandleOnScoreChange;
        }

        public void HandleOnScoreChange(int score = 0)
        {
            _scoreText.text = $"Score : {score}";

        }

    }


}
