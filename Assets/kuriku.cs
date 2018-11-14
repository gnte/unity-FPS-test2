using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kuriku : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        //カーソル表示
        Cursor.visible = true;
        //カーソル非表示
        Cursor.visible = false;

        //自由に動かせる
        Cursor.lockState = CursorLockMode.None;
        //ウィンドウ内のみ
        Cursor.lockState = CursorLockMode.Confined;
        //中央にロック
        Cursor.lockState = CursorLockMode.Locked;
    }
}
