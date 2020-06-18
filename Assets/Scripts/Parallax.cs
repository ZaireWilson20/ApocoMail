using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Vector3 startPos;
    public GameObject mainCamera;
    public float intensity;
    public float slowingDistance;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(mainCamera.transform.position.x < slowingDistance)
        {
             transform.position = new Vector3(transform.position.x, startPos.y + mainCamera.transform.position.y / intensity,transform.position.z);
        }
        else
        {
            transform.position =  new Vector3(startPos.x + mainCamera.transform.position.x/intensity, startPos.y + mainCamera.transform.position.y / intensity, transform.position.z);
        }

    }
}
