using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetHP : MonoBehaviour
{
    [SerializeField] Slider hpSlider;
    [SerializeField] CharaData charaData;
    // Start is called before the first frame update
    void Awake()
    {
        hpSlider.value = charaData.CharaHP;
    }


    public void SetHPBar(float hp)
    {
        hpSlider.value = hp;
    }
}
