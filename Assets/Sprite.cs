using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
        float changeRed = 0.001f;
        float changeGreen =0.001f;
        float cahngeBlue = 0.001f;
        float cahngeAlpha = 0.001f;
        this.GetComponent<SpriteRenderer>().color = new Color(changeRed, changeGreen, cahngeBlue, cahngeAlpha);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static implicit operator UnityEngine.Sprite(Sprite v)
    {
        throw new NotImplementedException();
    }
}
