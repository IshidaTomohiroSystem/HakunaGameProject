﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AsteroidController : MonoBehaviour
{
    [SerializeField] List<GameObject> asteroidList;
    int count = 0;
    readonly int time = 60;
    // Update is called once per frame
    void Update()
    {
        count++;
        if(count == asteroidList.Count)
        {
            System.Random r1 = new System.Random();
            int randomNumber = r1.Next(0, 3);
            GameObject gameObject = Instantiate(asteroidList[randomNumber]);

            float randomFloatX = UnityEngine.Random.Range(-0.6f, 0.3f); ;

            gameObject.transform.position = new Vector3(randomFloatX, 1, 0);
            gameObject.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
            BoxCollider boxCollider = gameObject.GetComponentInChildren<BoxCollider>();
            boxCollider.enabled = true;
            count = 0;
        }
    }
}