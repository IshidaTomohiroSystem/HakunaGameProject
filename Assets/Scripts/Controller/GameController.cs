using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] CharListData charListData;
    [SerializeField] SelectPlayerData SelectPlayerData;
    [SerializeField] Image UserImage;
    [SerializeField] GameObject playerShip;
    [SerializeField] GameObject ribbonEffect;
    [SerializeField] ScoreData scoreData;
    [SerializeField] CharaData charaData;
    Player player;
    [SerializeField] SetHP setHP;
    [SerializeField] TextMeshProUGUI charaName;

    float oldHP;

    private void Awake()
    {
        CharaObjectData charatData = charListData.CharList[SelectPlayerData.charNumber];
        UserImage.sprite = charatData.CharaSprite;

        GameObject gameobject = Instantiate(playerShip);
        gameobject.transform.position = new Vector3(-0.2f, -0.3f, 0);
        scoreData.score = 0;
        ribbonEffect.SetActive(true);

        player = gameobject.GetComponent<Player>();
        player.hp = charaData.CharaHP;
        oldHP = player.hp;

        charaName.text = charatData.CharaName;
    }

    private void Update()
    {
        if(oldHP != player.hp)
        {
            setHP.SetHPBar(player.hp);
            oldHP = player.hp;
        }
    }
}
