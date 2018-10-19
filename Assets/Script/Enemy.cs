using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private Pesawat pesawat;
    void Start()
    {
        pesawat = this.GetComponent<Pesawat>();
        pesawat.limitMove = false;
    }
    void Update()
    {
        pesawat.MoveUp();
        if (this.transform.position.y < -20)
        {
            Destroy(this.gameObject);
        }
    }
}
