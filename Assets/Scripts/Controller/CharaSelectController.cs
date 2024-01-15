using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class CharaSelectController : MonoBehaviour
{
    [SerializeField] CharListData charListData;
    [SerializeField] SelectPlayerData selectPlayerData;
    [SerializeField] GameObject Center;
    readonly float maxAngle = 360.0f;
    readonly float radius = 15.0f;

    List<GameObject> characters = new List<GameObject>();
    int selectCount = 0;

    private void Awake()
    {
        float spawnAngle = 0.0f;
        int charaMaxCount = charListData.CharList.Count;
        int charaCount = 0;

        foreach(CharaObjectData charaData in charListData.CharList)
        {
            GameObject gameObject= Instantiate(charaData.chara, Center.transform);
            spawnAngle = (maxAngle / (float)charaMaxCount) * charaCount;
            Debug.Log(spawnAngle);
            gameObject.transform.localPosition = new Vector3(math.cos(spawnAngle * math.PI * 2 / maxAngle) * radius, 0, math.sin(spawnAngle * 2 * math.PI / maxAngle) * radius);
            characters.Add(gameObject);
            charaCount++;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            int charaMaxCount = charListData.CharList.Count;
            float spawnAngle = 0.0f;
            int index = -1;
            selectCount--;
            foreach (GameObject chara in characters)
            {
                index++;
                spawnAngle = (maxAngle / (float)charaMaxCount) * (index + selectCount);
                chara.transform.localPosition = new Vector3(math.cos(spawnAngle * math.PI * 2 / maxAngle) * radius, 0, math.sin(spawnAngle * 2 * math.PI / maxAngle) * radius);
            }

            if (selectCount <= -charaMaxCount)
            {
                selectCount = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            int charaMaxCount = charListData.CharList.Count;
            float spawnAngle = 0.0f;
            int index = -1;
            selectCount++;
            foreach (GameObject chara in characters)
            {
                index++;
                spawnAngle = (maxAngle / (float)charaMaxCount) * (index + selectCount);
                chara.transform.localPosition = new Vector3(math.cos(spawnAngle * math.PI * 2 / maxAngle) * radius, 0, math.sin(spawnAngle * 2 * math.PI / maxAngle) * radius);
            }

            if (charaMaxCount <= selectCount)
            {
                selectCount = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (selectCount > 0)
            {
                selectPlayerData.charNumber = charListData.CharList.Count - selectCount;
            }
            else
            {
                selectPlayerData.charNumber = -selectCount;
            }
            SceneManager.LoadScene("StageSelect");
        }
    }
}
