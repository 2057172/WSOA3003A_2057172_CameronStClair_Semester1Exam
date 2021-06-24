using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public GameObject FemaleDetective;
    public GameObject MaleDetective;

    public GameObject CaseFiles;

    public GameObject FemaleTXTBubble;
    public GameObject MaleTXTBubble;

    public GameObject NoteIMG;

    public Button NextScene;

    public Text FemaleTXT;
    public Text MaleTXT;
    public Text noteTXT;

    public GameManager gm;

    void Start()
    {
        NextScene.gameObject.SetActive(false);
        StartCoroutine ("FirstDialogue");

        FemaleTXTBubble.GetComponent <SpriteRenderer>().enabled = false;
        MaleTXTBubble.GetComponent<SpriteRenderer>().enabled = false;
        CaseFiles.GetComponent<SpriteRenderer>().enabled = false;

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        MaleDetective.GetComponent<SpriteRenderer>().enabled = false;

        NoteIMG.GetComponent<SpriteRenderer>().enabled = false;
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("MainCrimeScene");
    }
    public void BeerBottle()
    {
        StartCoroutine("BeerText");
    }
    void Update()
    {
        
    }

    public void tableNote()
    {
        StartCoroutine("TblNote");
    }

    public void BookNote()
    {
        StartCoroutine("BookNoteCR");
    }

    public void CoatNote()
    {
        StartCoroutine("CoatCR");
    }

    public void BoardNote()
    {
        StartCoroutine("BoardNoteCR");
    }
    public void FinalNote()
    {
        StartCoroutine("FinalNoteCR");
    }

    public IEnumerator FirstDialogue()
    {
       // gm.CanClick = false;
        yield return new WaitForSeconds(4);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleTXTBubble.GetComponent<SpriteRenderer>().enabled = true;
        FemaleTXT.text = "Hi Detective Angel, I am detective Haliday, welcome to Hell.";

        yield return new WaitForSeconds(8);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleTXTBubble.GetComponent<SpriteRenderer>().enabled = false;
        FemaleTXT.text = "";

        MaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        MaleTXTBubble.GetComponent<SpriteRenderer>().enabled = true;
        MaleTXT.text = "Detective Haliday huh? Thanks, can't say it's a privilege to be here...";

        yield return new WaitForSeconds(8);

        MaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        MaleTXTBubble.GetComponent<SpriteRenderer>().enabled = false;
        MaleTXT.text = "";

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleTXTBubble.GetComponent<SpriteRenderer>().enabled = true;
        FemaleTXT.text = "You've been here ,what... 4 months?";

        yield return new WaitForSeconds(6);

        FemaleTXT.text = "Sorry we havent met yet, it's my fault, i've been super busy, being head detective is tiring stuff.";

        yield return new WaitForSeconds(9);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleTXTBubble.GetComponent<SpriteRenderer>().enabled = false;
        FemaleTXT.text = "";

        MaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        MaleTXTBubble.GetComponent<SpriteRenderer>().enabled = true;
        MaleTXT.text = "it's ok, please excuse the office, sitting around solving minor cases is getting boring.";

        yield return new WaitForSeconds(8);

        MaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        MaleTXTBubble.GetComponent<SpriteRenderer>().enabled = false;
        MaleTXT.text = "";

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleTXTBubble.GetComponent<SpriteRenderer>().enabled = true;
        FemaleTXT.text = "Well we all need to learn to crawl before we can run.";

        yield return new WaitForSeconds(6);

        FemaleTXT.text = "A major case just came up, it's too much for me to handle alone, you think you're ready to help?";

        yield return new WaitForSeconds(9);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleTXTBubble.GetComponent<SpriteRenderer>().enabled = false;
        FemaleTXT.text = "";

        MaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        MaleTXTBubble.GetComponent<SpriteRenderer>().enabled = true;
        MaleTXT.text = "I believe so yes, I was one of Heavens lead detectives before I was transferred here.";

        yield return new WaitForSeconds(6);

        MaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        MaleTXTBubble.GetComponent<SpriteRenderer>().enabled = false;
        MaleTXT.text = "";

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleTXTBubble.GetComponent<SpriteRenderer>().enabled = true;
        FemaleTXT.text = "Yes well you'll find that Hell has much darker crimes compared to Heavens petty squabbles.";

        yield return new WaitForSeconds(8);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleTXTBubble.GetComponent<SpriteRenderer>().enabled = false;
        FemaleTXT.text = "";

        MaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        MaleTXTBubble.GetComponent<SpriteRenderer>().enabled = true;
        MaleTXT.text = "You seem to forget Detective Haliday... ";

        yield return new WaitForSeconds(5);

        MaleTXT.text = "Before the afterlife, I was New Yorks best detective, theres a reason they call it Hell's kitchen.";

        yield return new WaitForSeconds(8);

        MaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        MaleTXTBubble.GetComponent<SpriteRenderer>().enabled = false;
        MaleTXT.text = "";

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleTXTBubble.GetComponent<SpriteRenderer>().enabled = true;
        FemaleTXT.text = "Then how about a little test to challenge your skills?";

        yield return new WaitForSeconds(7);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleTXTBubble.GetComponent<SpriteRenderer>().enabled = false;
        FemaleTXT.text = "";

        MaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        MaleTXTBubble.GetComponent<SpriteRenderer>().enabled = true;
        MaleTXT.text = "Bring it on.";

        yield return new WaitForSeconds(5);

        MaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        MaleTXTBubble.GetComponent<SpriteRenderer>().enabled = false;
        MaleTXT.text = "";

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleTXTBubble.GetComponent<SpriteRenderer>().enabled = true;
        FemaleTXT.text = "I've hidden the case details somewhere in your office, try find them.";

        yield return new WaitForSeconds(8);

        FemaleTXT.text = "I've left clues around your office, start with the note on your coffee table.";

        yield return new WaitForSeconds(8);

        FemaleTXT.text = "After that it's up to you to find the rest.";

        yield return new WaitForSeconds(5);

        FemaleTXT.text = "Oh and by the way, i'm only giving you 20 attempts to solve the test, goodluck detective. I'll be in my office if you need me.";

        yield return new WaitForSeconds(8);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleTXTBubble.GetComponent<SpriteRenderer>().enabled = false;
        FemaleTXT.text = "";
        gm.CanClick = true;
    }

    public IEnumerator BeerText()
    {
        //gm.CanClick = false;

        MaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        MaleTXTBubble.GetComponent<SpriteRenderer>().enabled = true;
        MaleTXT.text = "Man I should really stop drinking...";

        yield return new WaitForSeconds(4);

        MaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        MaleTXTBubble.GetComponent<SpriteRenderer>().enabled = false;
        MaleTXT.text = "";

        //gm.CanClick = false;
    }

    public IEnumerator TblNote()
    {
        noteTXT.text = "Congratulations, you have found one of 4 clues, you have a lot of books in here, maybe try looking in one thats on its own.";
        NoteIMG.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(8);

        noteTXT.text = "";
        NoteIMG.GetComponent<SpriteRenderer>().enabled = false;
    }

    public IEnumerator BookNoteCR()
    {
        noteTXT.text = "The next clue is hidden in an object you use, and is ironic when wearing since it is never cold in Hell.";
        NoteIMG.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(8);

        noteTXT.text = "";
        NoteIMG.GetComponent<SpriteRenderer>().enabled = false;
    }

    public IEnumerator CoatCR()
    {
        noteTXT.text = "Take NOTE of your surroundings, the table, books, and the corners of the board.";
        NoteIMG.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(8);
        noteTXT.text = "";
        NoteIMG.GetComponent<SpriteRenderer>().enabled = false;
    }
    public IEnumerator BoardNoteCR()
    {
        noteTXT.text = "Finally, it's time to hit the books, I would recommend starting with the second red one from the left on the top shelf.";
        NoteIMG.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(8);
        noteTXT.text = "";
        NoteIMG.GetComponent<SpriteRenderer>().enabled = false;
    }
    public IEnumerator FinalNoteCR()
    {       
        CaseFiles.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(6);        
        CaseFiles.GetComponent<SpriteRenderer>().enabled = false;

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleTXTBubble.GetComponent<SpriteRenderer>().enabled = true;
        FemaleTXT.text = "Congratulations Detective, and welcome to Hell.  Shall we get started?";
        NextScene.gameObject.SetActive(true);

    }
}
