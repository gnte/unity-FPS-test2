using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetText : MonoBehaviour {

    public Image image;
    private Sprite sprite;
   
    // Update is called once per frame
    void Update ()
    {
		
        if(Input.GetKeyDown(KeyCode.A))
        {
            sprite = Resources.Load<Sprite>("zintei");
            image = this.GetComponent<Image>();
            image.sprite = sprite;
        }
	}
}
