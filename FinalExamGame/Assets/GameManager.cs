using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int ClicksLeft;
    public Image LampIMG;
    public Button quit;

    public clickManager cm;
    public TextScript TextScript;

    public bool CanClick;

    public bool TableNote;
    public bool BookNote;
    public bool CoatNote;
    public bool BoardNote;
    public bool BookshelfNote;

    public Button quitB;


    public void Start()
    {
        quitB.gameObject.SetActive(false);
        TableNote = false;
        BookNote = false;
        CoatNote = false;
        BoardNote = false;
        BookshelfNote = false;

        CanClick = false;
        ClicksLeft = 20;
        LampIMG.enabled = false;
    }

    public void Update()
    {
        quitB.gameObject.SetActive(false);
        if (ClicksLeft < 0)
        {
            Time.timeScale = 0;
        }
    }

    public void quitButton()
    {
        Application.Quit();
    }

    public void OnMouseDown()
    {
        
        //if (CanClick == true)
        //{
            cm.clickNum--;

            if (Input.GetMouseButtonDown(0) && gameObject.name == "BookNote")
            {
            if (cm.TableNote == true)
            {
                Debug.Log("Book Note");
                TextScript.BookNote();
                cm.BookNote = true;
            }
            }
            else if (Input.GetMouseButtonDown(0) && gameObject.name == "Coat")
            {
            if (cm.BookNote == true)
            {
                Debug.Log("Coat");
                TextScript.CoatNote();
                cm.CoatNote = true;
            }
            else { }
            }
            else if (Input.GetMouseButtonDown(0) && gameObject.name == "Book")
            {
                Debug.Log("Book");
            TextScript.FinalNote();
            }
            else if (Input.GetMouseButtonDown(0) && gameObject.name == "BoardNote")
            {
            if (cm.CoatNote == true)
            {
                Debug.Log("Board Note");
                TextScript.BoardNote();
                cm.BoardNote = true;
            } else { }
            }
            else if (Input.GetMouseButtonDown(0) && gameObject.name == "TableNote")
            {
                Debug.Log("Table Note");
                TextScript.tableNote();
                cm.TableNote = true;
            }
            else if (Input.GetMouseButtonDown(0) && gameObject.name == "Lamp")
            {
                StartCoroutine("Lamp");
            }
            else if(Input.GetMouseButtonDown(0) && gameObject.name == "BeerBottle")
            {
                TextScript.BeerBottle();
           // }
        } else { }
        }

            public IEnumerator Lamp()
            {
                LampIMG.enabled = true;
                yield return new WaitForSeconds(0.5f);
                LampIMG.enabled = false;
            }


        }


