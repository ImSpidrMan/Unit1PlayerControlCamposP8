using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    private float propeller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        propeller = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.forward * propeller * 40);
    }
}
