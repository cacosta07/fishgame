using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectSpear : MonoBehaviour
{
    public attackingScrimpt attackingScrimpt;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        GameObject.Destroy(gameObject);
        attackingScrimpt.fish += 1;
    }
}
