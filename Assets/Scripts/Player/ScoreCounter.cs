using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : Score {
  [SerializeField] private TMP_Text scoreText;
  [SerializeField] private float scoreMultiplier;
  private bool shouldCount = true;
  private float score;

  private void Count()
  {
    score += Time.deltaTime * scoreMultiplier;
    scoreText.text = Mathf.FloorToInt(score).ToString();
  }

  private void Update()
  {
    if (!shouldCount) { return; }
    Count();
  }

  public void CantCount()
  {
    shouldCount = false;
    SetNewBestScore(Mathf.FloorToInt(score));
  }
}
