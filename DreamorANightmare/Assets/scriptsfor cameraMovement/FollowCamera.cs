using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FollowCamera : MonoBehaviour
{
    Func<Vector3> GetCameraFollowPostionFunc;
    
    public void setup(Func<Vector3> GetCameraFollowPostionFunc)
    {
        this.GetCameraFollowPostionFunc = GetCameraFollowPostionFunc;
    }
    public void setGetCameraFollowPostionFunc(Func<Vector3> GetCameraFollowPostionFunc)
    {
        this.GetCameraFollowPostionFunc = GetCameraFollowPostionFunc;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 CameraFollowPostion = GetCameraFollowPostionFunc();
        CameraFollowPostion.z = transform.position.z;
        CameraFollowPostion.y = transform.position.y;

        Vector3 cameradir = (CameraFollowPostion - transform.position).normalized;
        float distance2 =Vector3.Distance(CameraFollowPostion ,transform.position);
        float speed = 1f;
        if (distance2 > 0)
        {
            Vector3 NewCameraPos = transform.position + cameradir * speed * distance2 * Time.deltaTime;
            float distanceafterMoving = Vector3.Distance(NewCameraPos, CameraFollowPostion);
            if (distanceafterMoving > distance2)
            {
                NewCameraPos = CameraFollowPostion;
            }
            transform.position = NewCameraPos;
        }
       
        
    }
}
