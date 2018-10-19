using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peluru : MonoBehaviour {

    public GameObject explosion; // drag your explosion prefab here
    void Update()
    {
        this.transform.Translate(new Vector2(0, 10) * Time.deltaTime);
        if (this.transform.position.y > 20)
        {
            Destroy(this.gameObject);
        }
    }
}
