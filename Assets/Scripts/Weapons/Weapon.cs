﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.TryGetComponent<SamplePlayer>(out SamplePlayer p)){
            p.Hit();
        }
    }
}
