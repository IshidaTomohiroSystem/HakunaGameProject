using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] CharListData dharListData;
    [SerializeField] SelectPlayerData SelectPlayerData;
    [SerializeField] Image UserImage;
    [SerializeField] GameObject playerShip;
    [SerializeField] GameObject ribbonEffect;
    [SerializeField] ScoreData scoreData;

    private void Awake()
    {
        CharaData charatData = dharListData.CharList[SelectPlayerData.charNumber];
        UserImage.sprite = charatData.CharaSprite;

        GameObject gameobject = Instantiate(playerShip);
        gameobject.transform.position = new Vector3(-0.2f, -0.3f, 0);
        scoreData.score = 0;
        ribbonEffect.SetActive(true);
    }
}
