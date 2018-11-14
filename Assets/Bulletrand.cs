using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletrand : MonoBehaviour
{
    public GameObject BulletPrefabs;
    float span = 1.0f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject item = Instantiate(BulletPrefabs) as GameObject;
            float x = Random.Range(-1, 1);
            float y = Random.Range(-1, 1);
            item.transform.position = new Vector3(x, y, 20);
        }
    }
}
