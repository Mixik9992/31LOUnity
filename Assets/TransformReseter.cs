using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformReseter : MonoBehaviour
{
    public Transform transformToReset;
    public Vector3 startingPositon;
    public Vector3 startingRotation;
    // Start is called before the first frame update
    void Start()
    {
        startingPositon = transformToReset.position;
        // startingRotation = transformToReset.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
