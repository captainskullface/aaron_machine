using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideScript : MonoBehaviour
{
    public cameraMove camReference;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Camera")
        {
            camReference.MoveCam();
        }
    }
}
