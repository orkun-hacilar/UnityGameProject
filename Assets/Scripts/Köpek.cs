using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Köpek : MonoBehaviour
{
    private NavMeshAgent köpek;

    public Transform Target;
    // Start is called before the first frame update
    void Start()
    {
        köpek = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        köpek.destination = Target.position;
    }
}
