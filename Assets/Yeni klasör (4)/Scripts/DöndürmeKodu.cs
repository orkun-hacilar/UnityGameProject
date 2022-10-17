using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DöndürmeKodu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle:0,yAngle:10*Time.deltaTime, zAngle: 0);
    }
}
