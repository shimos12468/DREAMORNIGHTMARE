using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    public Transform mainCamera;
    public Vector3 lastCameraPos;
    public Vector2 prallaxEffectMultiplier;
    private float textureunitysize;
    void Start()
    {
        lastCameraPos = mainCamera.position;
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = sprite.texture;
        textureunitysize = texture.width / sprite.pixelsPerUnit;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 deltaMovment = mainCamera.position - lastCameraPos;
       

      
            transform.position +=new Vector3(deltaMovment.x * prallaxEffectMultiplier.x , deltaMovment.y * prallaxEffectMultiplier.y,0) ;
            lastCameraPos = mainCamera.position;
        if(Mathf.Abs(mainCamera.position.x - transform.position.x) >= textureunitysize && gameObject.tag!="Moon")
        {
            Debug.Log("here");
            float offset = (mainCamera.position.x - transform.position.x) % textureunitysize;
            transform.position = new Vector3(mainCamera.position.x + offset, transform.position.y);
        }
        
    }
}
