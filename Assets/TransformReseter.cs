using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformReseter : MonoBehaviour
{
    public Transform transformToReset;
    public Vector3 startingPositon;
    public Vector3 startingRotationAngles;
    public Quaternion startingRotation;
    // Start is called before the first frame update
    void Start()
    {
        if (transformToReset == null)
        {
            transformToReset = transform;
        }

        startingPositon = transformToReset.position;
        startingRotation = transformToReset.rotation;
        startingRotationAngles = startingRotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Debug.Log("jestok");
            transformToReset.position = startingPositon;
            startingRotation.eulerAngles = startingRotationAngles;
            transformToReset.rotation = startingRotation;
        }
    }
}
