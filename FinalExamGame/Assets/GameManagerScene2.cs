using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScene2 : MonoBehaviour
{
   

    public ClickManagerScene2 CM;
    public TextManager2 TM;

    void Start()
    {
      
    }

    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButton(0) && gameObject.name == "Glass")
        {
            Debug.Log("Glass");
            CM.Glass = true;
            TM.Glass();
        }

        else if (gameObject.name == "Stove")
        {
            Debug.Log("Stove");
            CM.Stove = true;
            TM.Stove();
        }
        else if (gameObject.name == "BloodOnFloor")
        {
            Debug.Log("BloodOnFloor");
            CM.FloorBlood = true;
            TM.BloodOnFloor();
        }
        else if (gameObject.name == "Footprints")
        {
            Debug.Log("Footprints");
            CM.FootPrints = true;
            TM.Footprints();
        } else if (gameObject.name == "Hair")
        {
            Debug.Log("Hair");
            CM.Hair = true;
            TM.Hair();
        }
        else if (gameObject.name == "key")
        {
            Debug.Log("key");
            CM.key = true;
            if(CM.Cupboard1 == true)
            {
                TM.key1();
            } else if (CM.Cupboard1 == false)
            {
                TM.key2();
            }
        } else if (gameObject.name == "Plate")
        {
            Debug.Log("Plate");
            CM.Plate = true;
            TM.Plate();
        } else if (gameObject.name == "ChairBlood")
        {
            Debug.Log("ChairBlood");
            CM.ChairBlood = true;
            TM.ChairBlood();
        } else if (gameObject.name == "Cupboard")
        {
            Debug.Log("Cupboard");
            CM.Cupboard1 = true;
            if(CM.key == true)
            {
                TM.Cupboard1();
                CM.Cupboard2 = true;
            } else if (CM.key == false)
            {
                TM.Cupboard2();
            }
        } else if (gameObject.name == "Purse")
        {
            Debug.Log("Purse");
            CM.Purse = true;
            TM.Purse();
        } else if (gameObject.name == "Window")
        {
            Debug.Log("Window");
            CM.Window = true;
            TM.Window();
        } else if (gameObject.name == "knife")
        {
            Debug.Log("knife");
            CM.knife = true;
            TM.knife();
        } else { }
        }
    }

