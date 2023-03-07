using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.VFX;

public class EffectPlay : MonoBehaviour
{
    [SerializeField] VisualEffect effect;

    private void Awake()
    {
        effect.SendEvent("StopPlay");
        effect.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            effect.SendEvent("OnPlay");
            //OnPlayはEvent Nameで指定した任意の名称
        }

        //if (Input.GetKey(KeyCode.A))
        //{
        //    effect.SetFloat("Direction", -1);
        //    effect.gameObject.transform.localPosition = new Vector3(
        //        effect.gameObject.transform.localPosition.x,
        //        effect.gameObject.transform.localPosition.y,
        //        effect.gameObject.transform.localPosition.z);
        //}
        //
        //if (Input.GetKey(KeyCode.D))
        //{
        //    effect.SetFloat("Direction", 1);
        //    effect.gameObject.transform.localPosition = new Vector3(
        //       -effect.gameObject.transform.localPosition.x,
        //       effect.gameObject.transform.localPosition.y,
        //       effect.gameObject.transform.localPosition.z);
        //}
    }
}
