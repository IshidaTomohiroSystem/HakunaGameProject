using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaMove : MonoBehaviour
{
    [SerializeField]
    Renderer charaRenderer;

    Material charaMat;
    // Start is called before the first frame update
    void Awake()
    {
        if(charaRenderer == null)
        {
            return;
        }
        charaMat = charaRenderer?.material;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            var pos = this.transform.position;
            var posx = pos.x - 0.05f;
            if(posx < -0.7f)
            {
                posx = pos.x;
            }
            this.transform.position = new Vector3(posx, pos.y, pos.z);
            Vector2 offset = new Vector2(-1.0f, 1.0f);
            if (charaRenderer != null)
                charaMat?.SetTextureScale("_MainTex", offset);
        }

        if (Input.GetKey(KeyCode.D))
        {
            var pos = this.transform.position;
            var posx = pos.x + 0.05f;
            if (posx > 0.3f)
            {
                posx = pos.x;
            }
            this.transform.position = new Vector3(posx, pos.y, pos.z);
            Vector2 offset = new Vector2(1.0f, 1.0f);
            if (charaRenderer != null)
                charaMat?.SetTextureScale("_MainTex", offset);
        }
    }

    private void OnDestroy()
    {
        if (charaMat != null)
        {
            Destroy(charaMat);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("position: " + collision.gameObject.transform.position.ToString());
    }
}
