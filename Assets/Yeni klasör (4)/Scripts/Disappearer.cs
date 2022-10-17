using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappearer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SandıkYoketme;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnTriggerEnter(Collider other)
    {
        
        
        SandıkYoketme.GetComponent<Renderer>().enabled = false;
        
    }
    
    
}
