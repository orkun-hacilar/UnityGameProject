using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirişİpiKodu : MonoBehaviour
{
    public GameObject GirişAlevleri;
    public GameObject GirişAlevleri2;
    public GameObject GirişAlevleri3;
    private void OnTriggerEnter(Collider other)
    {
        GirişAlevleri.SetActive(true);
        GirişAlevleri2.SetActive(true);
        GirişAlevleri3.SetActive(true);
    }
    
}
