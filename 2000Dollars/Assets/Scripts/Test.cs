﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

 

    void OnTriggerEnter(Collider collider)
    {
        print("test");
        if (collider.gameObject.tag == "zonePointAveugle")
        {
            

        }

    }
}
