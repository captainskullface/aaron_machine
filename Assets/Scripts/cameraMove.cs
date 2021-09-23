using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public int cameraNum;
    public Transform camPos01;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveCam()
    {
        cameraNum++;
        //update cameraNum
        if (cameraNum == 1)
        {
            transform.position = new Vector3(-20.90632f, -20.8449f, -24.3389f);
        } else if (cameraNum == 2)
        {
            transform.position = new Vector3(-41.9000015f, -47.5999985f, -24.3389015f);
        } else if (cameraNum == 3)
        {
            transform.position = new Vector3(-62.2000008f, -65.5f, -24.3389015f);
        } else if (cameraNum == 4)
        {
            transform.position = new Vector3(-96.5f, -79.3000031f, -24.3389015f);
        } else if (cameraNum == 5)
        {
            transform.position = new Vector3(-126.699997f, -85.0999985f, -24.3389015f);
        } else if (cameraNum == 6)
        {
            transform.position = new Vector3(-131.199997f, -93.6999969f, -24.3389015f);
        } else if (cameraNum == 7)
        {
            transform.position = new Vector3(-116.290001f, -93.4400024f, -24.3389015f);
        } else if (cameraNum == 8)
        {
            transform.position = new Vector3(-94.1900024f, -93.4400024f, -24.3389015f);
        } else if (cameraNum == 9)
        {
            transform.position = new Vector3(-90.0699997f, -101.860001f, -24.3389015f);
        } else if (cameraNum == 10)
        {
            transform.position = new Vector3(-75.7699966f, -118.43f, -24.3389015f);
        } else if (cameraNum == 11)
        {
            transform.position = new Vector3(-57.2000008f, -139.800003f, -24.3389015f);
        } else if (cameraNum == 12)
        {
            transform.position = new Vector3(-42.5f, -159.5f, -24.3389015f);
        } else if (cameraNum == 13)
        {
            transform.position = new Vector3(-29.2999992f, -171.699997f, -24.3389015f);
        } else if (cameraNum == 14)
        {
            transform.position = new Vector3(-16.2999992f, -185.100006f, -24.3389015f);
        } else if (cameraNum == 15)
        {
            transform.position = new Vector3(-3f, -202f, -24.3389015f);
        }

        //move camera to pos equal to cameraNum

    }
}