using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour {

    public Pesawat pesawat;
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pesawat.MoveUp();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pesawat.MoveDown();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pesawat.MoveLeft();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pesawat.MoveRight();
        }
        if (Input.GetKey(KeyCode.Z))
        {
            pesawat.Attack();
        }
    }
}
