using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject mainCameraPrefab;
    [SerializeField] GameObject playerPrefab;

    GameObject player;
    GameObject mainCamera;

    [SerializeField] Vector3 startPosition;
    [SerializeField] Vector3 cameraPosition;

    // Start is called before the first frame update
    void Awake()
    {
        mainCamera = Instantiate(mainCameraPrefab);
        mainCamera.transform.position = cameraPosition;

        player = Instantiate(playerPrefab);
        player.transform.position = startPosition;
        player.transform.localEulerAngles = new Vector3(90.0f, 180.0f, 0.0f);
        player.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = player.transform.position - startPosition;
        mainCamera.transform.position = cameraPosition + difference;
    }
}
