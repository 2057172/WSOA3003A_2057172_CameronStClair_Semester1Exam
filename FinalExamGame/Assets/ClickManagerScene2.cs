using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManagerScene2 : MonoBehaviour
{
    public bool FloorBlood;
    public bool ChairBlood;
    public bool Hair;
    public bool FootPrints;
    public bool key;
    public bool Purse;
    public bool Glass;
    public bool Window;
    public bool Plate;
    public bool Stove;
    public bool Cupboard1;
    public bool Cupboard2;
    public bool knife;

    public TextManager2 TM;

    void Start()
    {
        FloorBlood = false;
        ChairBlood = false;
        Hair = false;
        FootPrints = false;
        key = false;
        Purse = false;
        Glass = false;
        Window = false;
        Plate = false;
        Stove = false;
        Cupboard1 = false;
        Cupboard2 = false;
        knife = false;
    }

    void Update()
    {
        if(Cupboard2 == true && 
            Glass == true &&
            knife == true &&
            Purse == true &&
            Plate == true)
        {
            TM.endingDialogue();
            TM.finished = true;
        }
    }
}
