using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Handler : MonoBehaviour
{
    public FollowCamera followCamera;
    public Transform Follow;
    void Start()
    {
        followCamera.setup(()=>Follow.position);
        followCamera.setGetCameraFollowPostionFunc(() => Follow.position);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
