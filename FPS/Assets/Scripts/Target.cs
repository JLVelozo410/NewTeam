using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public float drop = 2f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Commence (float amount)
    {
        drop -= amount;
        if (drop <= 0)
        {
            Go();
        }
    }

    void Go ()
    {
        Destroy(gameObject);
    }
}
