using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectController : MonoBehaviour
{
    [SerializeField] List<TextMeshPro> stageTexts = new List<TextMeshPro>();
    int stageNum;
    [SerializeField] SelectPlayerData selectPlayerData;

    // Start is called before the first frame update
    void Awake()
    {
        InitializeText();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            stageNum++;
            stageNum = stageNum > stageTexts.Count ? stageNum - stageTexts.Count : stageNum;
            SelectStage(stageNum);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            stageNum--;
            stageNum = stageNum < 0 ? stageNum + stageTexts.Count : stageNum;

            SelectStage(stageNum);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            selectPlayerData.charNumber = selectPlayerData.charNumber;
            SceneManager.LoadScene("Game");
        }
    }

    void InitializeText()
    {
        stageNum = 0;
        SelectStage(stageNum);
    }

    void SelectStage(int newStageNum)
    {
        Vector3 stageTextPos = Vector3.back * 3;
        for (int i = 0; i < stageTexts.Count; i++)
        {
            float angle = 0.0f;
            angle = 360 / stageTexts.Count * (i + newStageNum);
            angle = angle > 360 ? angle - 360 : angle;
            angle = angle < 0 ? angle + 360 : angle;
            Vector3 newPos = RotatePos(stageTextPos, angle);
            stageTexts[i].transform.position = newPos;
            Color color = ChangeColorForRotate(angle);
            stageTexts[i].color = color;
        }
    }

    Vector3 RotatePos(Vector3 pos, float angle)
    {
        Vector3 newPos = Quaternion.Euler(-angle, 0.0f, 0.0f) * pos;
        return newPos;
    }

    Color ChangeColorForRotate(float angle)
    {
        float colorCoefficient = math.abs(180.0f - angle);
        
        float alpha = colorCoefficient / 180.0f;
        Color color = Color.white;
        alpha = alpha == 0.0f ? 0.05f : alpha;
        color.a = alpha;

        return color;
    }
}
