using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CharaBase
{
    [SerializeField] GameObject explosion;
    [SerializeField] ParticleSystem noramlAttack;
    [SerializeField] ParticleSystem spark;
    [SerializeField] ParticleSystem flashOne;
    [SerializeField] ParticleSystem flashTwo;
    GameObject attackObject;

    private void OnCollisionEnter(Collision collision)
    {
        hp -= 10;
        GameObject explosionObj = Instantiate(explosion);
        Vector3 point = collision.contacts[0].point;
        explosionObj.transform.position = new Vector3(point.x, point.y, point.z);
        explosionObj.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
    }

    private void Awake()
    {
        noramlAttack.Stop();
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //var mainModule = noramlAttack.main;
            //var _minMaxCurve = noramlAttack.main.startLifetime;
            //_minMaxCurve = 2;
            //mainModule.startLifetime = _minMaxCurve;
            //mainModule.loop = true;
            noramlAttack.Play();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            //var mainModule = noramlAttack.main;
            //var _minMaxCurve = noramlAttack.main.startLifetime;
            //_minMaxCurve = 0;
            //mainModule.startLifetime = _minMaxCurve;
            //mainModule.loop = false;
            noramlAttack.Stop();
        }

    }

    void SetAttack()
    {

    }

    void EndAttack()
    {

    }
}
