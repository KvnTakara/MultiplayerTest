using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    #region Variables

    public static LevelManager instance;

    public string[] playersID;

    #endregion

    #region Initialization

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(this);
    }

    void Start()
    {
        CreatePlayers();
    }

    #endregion

    #region Functions

    void CreatePlayers()
    {
        PlayerSO newPlayer = ScriptableObject.CreateInstance<PlayerSO>();

        newPlayer.playerName = "Player1";
        newPlayer.points = 0;

        // Salve o ScriptableObject como um asset
        string path = $"Assets/Resources/PlayerSO/{newPlayer.playerName}.asset";
        UnityEditor.AssetDatabase.CreateAsset(newPlayer, path);
        UnityEditor.AssetDatabase.SaveAssets();
        UnityEditor.AssetDatabase.Refresh();
    }

    #endregion
}
