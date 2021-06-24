using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickManager : MonoBehaviour
{
    public int clickNum;
    public Text clickNumber;
    public Text clickTXT;

    public GameManager gm;

    public bool TableNote;
    public bool CoatNote;
    public bool BookNote;
    public bool BoardNote;

    void Start()
    {
        clickTXT.GetComponent<Text>().enabled = false;
        clickNumber.GetComponent<Text>().enabled = false;

        CoatNote = false;
        BookNote = false;
        TableNote = false;
        BoardNote = false;
        clickNum = 20;
    }

    void Update()
    {
        clickNumber.text = clickNum.ToString();
        if (gm.CanClick == true)
        {
            clickTXT.GetComponent<Text>().enabled = true;
            clickNumber.GetComponent<Text>().enabled = true;
        } else if (gm.CanClick == false)
        {
            clickTXT.GetComponent<Text>().enabled = false;
            clickNumber.GetComponent<Text>().enabled = false;
        }
    }

    
}
