using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AttackEffectDirection : MonoBehaviour
{
    [SerializeField] private GameObject attackEffect;
    Vector3 position = Vector3.zero;
    float angle = 0.0f;

    private void Awake()
    {
        position = attackEffect.transform.localPosition;
        angle = attackEffect.transform.eulerAngles.z;
    }

    void Update()
    {

        Vector3 atPos = new Vector3();
        float dirAngle = 0.0f;
        if (Input.GetKey(KeyCode.A))
        {
            atPos = new Vector3(position.x, position.y, position.z);
            dirAngle = angle;
            SetDirection(atPos, dirAngle);
        }

        if (Input.GetKey(KeyCode.D))
        {
            atPos = new Vector3(-position.x, position.y, position.z);
            dirAngle = -angle;
            SetDirection(atPos, dirAngle);
        }
    }
    // Start is called before the first frame update
    void SetDirection(Vector3 pos, float dir)
    {
        attackEffect.transform.localPosition = 
            new Vector3(pos.x, pos.y, pos.z);

        attackEffect.transform.eulerAngles =
            new Vector3(attackEffect.transform.eulerAngles.x, attackEffect.transform.eulerAngles.y, dir);
    }
}
