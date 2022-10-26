using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleManControl : MonoBehaviour
{
    public Transform a;
    public Transform b;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (a.transform.position + b.transform.position) / 2;
    }
}
