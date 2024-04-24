using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player", menuName = "Player")]
public class PlayerSO : ScriptableObject
{
    public GameObject player;
    public string playerName;
    public int points;
}
