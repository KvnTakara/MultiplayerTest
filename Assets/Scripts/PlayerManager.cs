using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Variables

    public int points = 0;

    [SerializeField] TextMeshProUGUI score;

    #endregion

    #region Instantiate

    void Update()
    {
        UpdateScoreUI();
    }

    #endregion

    #region Functions

    void UpdateScoreUI()
    {
        score.text = points.ToString();
    }

    #endregion
}
