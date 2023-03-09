using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    [SerializeField] GameObject explosion;
    bool exp = false;

    [SerializeField] ScoreData scoreData;

    private void Update()
    {
        if(exp)
        {
            this.gameObject.SetActive(false);
        }
    }
    private void OnParticleCollision(GameObject other)
    {
        GameObject expGameobject = Instantiate(explosion);
        expGameobject.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        expGameobject.transform.localScale = new Vector3(0.04f, 0.04f, 0.04f);
        scoreData.score += 10;
        exp = true;
    }
}
