using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager2 : MonoBehaviour
{

    public GameObject dick;
    public GameObject SpeechBubble;
    public GameObject FemaleDetective;
    public GameObject FemaleSpeechBubble;
    public GameObject ID;
    public bool finished;
    public int points;
    public GameObject nostar;
    public GameObject onestar;
    public GameObject twostar;
    public GameObject threestar;
    public GameObject fourstar;

    public int cluesnum;

    public Text cluesLeft;
    public Text Speech;
    public Text FemaleSpeech;

    public Button windowB, doorB, plateB, knifeB, nothingB, MoneyB, CupboardB, idkB, quitB;


    void Start()
    {
        cluesnum = 5;
        cluesLeft.text = cluesnum.ToString();
        points = 0;
        ID.GetComponent<SpriteRenderer>().enabled = false;

        nostar.gameObject.SetActive(false);
        onestar.gameObject.SetActive(false);
        twostar.gameObject.SetActive(false);
        threestar.gameObject.SetActive(false);
        fourstar.gameObject.SetActive(false);

        quitB.gameObject.SetActive(false);

        windowB.gameObject.SetActive(false);
        doorB.gameObject.SetActive(false);

        plateB.gameObject.SetActive(false);
        knifeB.gameObject.SetActive(false);

        nothingB.gameObject.SetActive(false);
        MoneyB.gameObject.SetActive(false);
        
        CupboardB.gameObject.SetActive(false);
        idkB.gameObject.SetActive(false);

        finished = false;
        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = false;

        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;

        Speech.text = "";
        FemaleSpeech.text = "";

        StartCoroutine("FirstDialogue");
    }

    
    void Update()
    {
        cluesLeft.text = cluesnum.ToString();
        if(cluesnum < 0)
        {
            cluesnum = 0;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void endingDialogue()
    {if (finished == false)
        {
            StartCoroutine("EndingDialogueCR");
        }
        else { }
    }
    public void BloodOnFloor()
    {
        if (finished == false)
        { StartCoroutine("BloodOnFloorCR"); }else { }
    }   
    public void knife()
    {
        if (finished == false)
        {
            StartCoroutine("knifeCR");
        }
        else { }
    }
    public void Glass()
    {
        if (finished == false)
        {
            StartCoroutine("GlassCR");
        }
        else { }
    } public void Purse()
    {
        if (finished == false)
        { StartCoroutine("PurseCR"); }
        else { }
    } public void Window()
    {
        if (finished == false)
        {
            StartCoroutine("WindowCR");
        }
        else { }
    } public void Cupboard1()
    {
        if (finished == false)
        {
            StartCoroutine("Cupboard1CR");
        }
        else { }
    }
    public void Cupboard2()
    {
        if (finished == false)
        { StartCoroutine("Cupboard2CR"); }
        else { }
    }
    public void ChairBlood()
    {
        if (finished == false)
        {
            StartCoroutine("ChairBloodCR");
        }
        else { }
    } public void Stove()
    {
        if (finished == false)
        {
            StartCoroutine("StoveCR");
        }
        else { }
    } public void Footprints()
    {
        if (finished == false)
        {
            StartCoroutine("FootprintsCR");
        }
        else { }
    } public void key1()
    {
        if (finished == false)
        {
            StartCoroutine("key1CR");
        }
        else { }
    }
    public void key2()
    {
        if (finished == false)
        { StartCoroutine("key2CR"); }
        else { }
    }
    public void Hair()
    {
        if (finished == false) { 
            StartCoroutine("HairCR");
        }
        else { }
    } public void Plate()
    {
        if (finished == false)
        {
            StartCoroutine("PlateCR");
        }
    }

    public void EndScore()
    {
        if(points == 0)
        {
            nostar.gameObject.SetActive(true);
        } else if(points == 1)
        {
            onestar.gameObject.SetActive(true);
        } else if(points == 2)
        {
            twostar.gameObject.SetActive(true);
        } else if (points == 3)
        {
            threestar.gameObject.SetActive(true);
        } else if(points == 4)
        {
            fourstar.gameObject.SetActive(true);
        }
        else { }
    }

    public void WindowB()
    {
        points++;
        StartCoroutine("EndWindowCR");
        windowB.gameObject.SetActive(false);
        doorB.gameObject.SetActive(false);
    } public void DoorB()
    {
        StartCoroutine("EndDoorCR");
        doorB.gameObject.SetActive(false);
        windowB.gameObject.SetActive(false);
    }
    public void knifeFunc()
    {
        points++;
        StartCoroutine("EndknifeCR");
        knifeB.gameObject.SetActive(false);
        plateB.gameObject.SetActive(false);
    }
    public void plateFunc()
    {
        StartCoroutine("EndPlateCR");
        knifeB.gameObject.SetActive(false);
        plateB.gameObject.SetActive(false);
    }
    public void NothingFunc()
    {
        points++;
        StartCoroutine("EndNothingCR");
        nothingB.gameObject.SetActive(false);
        MoneyB.gameObject.SetActive(false);
    }
    public void MoneyFunc()
    {
        StartCoroutine("EndMoneyCR");
        nothingB.gameObject.SetActive(false);
        MoneyB.gameObject.SetActive(false);
    }
    public void CupboardFunc()
    {
        points++;
        StartCoroutine("EndCupboardCR");
        idkB.gameObject.SetActive(false);
        CupboardB.gameObject.SetActive(false);
    }
    public void murderFunc()
    {
        StartCoroutine("EndMurderCR");
        idkB.gameObject.SetActive(false);
        CupboardB.gameObject.SetActive(false);
    }


    public IEnumerator knifeCR()
    {
        cluesnum--;
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "A bloodied knife... possibly the murder weapon. It doesnt match the cutlery set, the intruder must have brought it themselves... but why leave it?";
        yield return new WaitForSeconds(10);
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
    }
    public IEnumerator GlassCR()
    {
        cluesnum--;
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "Shattered glass on the floor, looks like it came from the window. " +
            "It's on the inside meaning that the intruder broke in from the outside. A forced entry...";
        yield return new WaitForSeconds(10);
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
    } public IEnumerator BloodOnFloorCR()
    {
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "Looks like the intruder stabbed the victim multiple times in this area. Large pool of blood on the floor and a trail. She tried to escape.";
        yield return new WaitForSeconds(10);
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
    }
    public IEnumerator PurseCR()
    {
        cluesnum--;
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "The victims purse is still here with cash in it. This wasn't a robbery gone bad, the intruder had one goal. To kill.";
        yield return new WaitForSeconds(10);
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
    }
    public IEnumerator WindowCR()
    {
        
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "Another day in Hell... Still blood on the glass, the intruder cut themselves coming in. They wanted to get in quickly.";
        yield return new WaitForSeconds(10);
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
    }
    public IEnumerator ChairBloodCR()
    {
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "A fallen chair with blood on it. The victim must have tried to grab onto it when after she fell onto the ground in an attempt to escape.";
        yield return new WaitForSeconds(10);
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
    }
    public IEnumerator StoveCR()
    {
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "The stove is still on, the victim was halfway through cooking dinner when the intruder broke in.";
        yield return new WaitForSeconds(10);
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
    }
    public IEnumerator FootprintsCR()
    {
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "Bloodied boot marks, these belong to the murderer. It look's like they left in a hurry. Did they hear us coming?";
        yield return new WaitForSeconds(10);
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
    }
    public IEnumerator HairCR()
    {
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "Hair... matching the description of the victims. The intruder must have ripped some out in an efort to keep her from escaping.";
        yield return new WaitForSeconds(10);
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
    }
    public IEnumerator key1CR()
    {
        cluesnum--;
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "A key! It looks like the victim was trying to hide it under the rug. Could this be used to open the locked cupboard?";
        yield return new WaitForSeconds(10);
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
    }
    public IEnumerator key2CR()
    {
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "A key! It looks like the victim was trying to hide it. But what was so important to hide that you sacrificed your life for?";
        yield return new WaitForSeconds(10);
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
    }
    public IEnumerator Cupboard1CR()
    {
        cluesnum--;
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "A locked cabinet, looks like the intruder tried breaking into it but had to run when we came. The key I found fits! Let's see whats inside.";
        yield return new WaitForSeconds(10);
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
    }
    public IEnumerator Cupboard2CR()
    {
        
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "A locked cabinet, looks like the intruder tried breaking into it but had to run when we came. Maybe theres a key somewhere that can open it.";
        yield return new WaitForSeconds(10);
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
    }
    public IEnumerator PlateCR()
    {
        cluesnum--;
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "A broken dinner plate. Perhaps the victim tried to use it as a weapon against the intruder, or is this evidence of a struggle?";
        yield return new WaitForSeconds(10);
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
    }

    public IEnumerator FirstDialogue()
    {
        yield return new WaitForSeconds(3);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
        FemaleSpeech.text = "Detective Angel, how kind of you to join us.";

        yield return new WaitForSeconds(5);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "Evening Detective Haliday, sorry I got held up.";
        FemaleSpeech.text = "";

        yield return new WaitForSeconds(5);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
        FemaleSpeech.text = "Drinking again I presume?";

        yield return new WaitForSeconds(5);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "It's not like that...";
        FemaleSpeech.text = "";

        yield return new WaitForSeconds(5);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
        FemaleSpeech.text = "We'll discuss that later, right now we have a murder to deal with.";

        yield return new WaitForSeconds(5);

        FemaleSpeech.text = "All we know so far is that the victim was murdered about 40 minutes ago by an unknown intruder.";

        yield return new WaitForSeconds(5);

        FemaleSpeech.text = "We are still trying to identify the body. See what you can do detective, make sure you look everywhere for any possible clues.";
        yield return new WaitForSeconds(8);
        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
        FemaleSpeech.text = "";


    }

    public IEnumerator EndingDialogueCR()
    {
        yield return new WaitForSeconds(12);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
        FemaleSpeech.text = "So Detective Angel, what can you tell me about the case? How did the intruder get in?";

        yield return new WaitForSeconds(5);

        windowB.gameObject.SetActive(true);
        doorB.gameObject.SetActive(true);



    }

    public IEnumerator EndWindowCR()
    {
        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "The intruder broke in through the window from the outside as evident from the glass fragments " +
            "found on the inside whilst the victim was cooking.";
        FemaleSpeech.text = "";

        yield return new WaitForSeconds(8);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
        FemaleSpeech.text = "I see, yes that makes sense. What was the victim attacked with?";

        plateB.gameObject.SetActive(true);
        knifeB.gameObject.SetActive(true);
    }
    public IEnumerator EndDoorCR()
    {
        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "The intruder broke in through the door as there are bloodied footprints coming from that direction.";
        FemaleSpeech.text = "";

        yield return new WaitForSeconds(8);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
        FemaleSpeech.text = "That doesnt make sense, the window was broken from the outside, additionally, " +
            "the foorprints are from the kitchen to the door, not the other way around.";

        yield return new WaitForSeconds(8);
        FemaleSpeech.text = "Anyways, what was the victim attacked with?";

        plateB.gameObject.SetActive(true);
        knifeB.gameObject.SetActive(true);
    }

    public IEnumerator EndknifeCR()
    {
        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "They were attacked with a knife, the intruder left it behind and it doesnt match any of the other pieces of cutlery belonging to the victim.";
        FemaleSpeech.text = "";

        yield return new WaitForSeconds(8);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
        FemaleSpeech.text = "I see, but why leave it behind... was the intruder in a rush?";

        yield return new WaitForSeconds(8);
        FemaleSpeech.text = "Nevermind that, what did the intruder take?";

        nothingB.gameObject.SetActive(true);
        MoneyB.gameObject.SetActive(true);
    }
    public IEnumerator EndPlateCR()
    {
        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "They were attacked with a plate, its still on the floor broken.";
        FemaleSpeech.text = "";

        yield return new WaitForSeconds(8);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
        FemaleSpeech.text = "I disagree, it looks like they were attacked with a knife, additionally, its still on the floor.";

        yield return new WaitForSeconds(8);
        FemaleSpeech.text = "Nevermind that, what did the intruder take?";

        nothingB.gameObject.SetActive(true);
        MoneyB.gameObject.SetActive(true);
    }
    public IEnumerator EndNothingCR()
    {
        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "They took nothing, the victims purse is still on the table, with cash in it.";
        FemaleSpeech.text = "";

        yield return new WaitForSeconds(8);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
        FemaleSpeech.text = "So robbery wasnt the motive... do you have any idea what they were after?";    

        idkB.gameObject.SetActive(true);
        CupboardB.gameObject.SetActive(true);
    }
    public IEnumerator EndMoneyCR()
    {
        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "They were after the victims money.";
        FemaleSpeech.text = "";

        yield return new WaitForSeconds(8);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
        FemaleSpeech.text = "That makes no sense, the vitims purse is still here with cash in it. What else could they be after?";

        idkB.gameObject.SetActive(true);
        CupboardB.gameObject.SetActive(true);
    }
    public IEnumerator EndCupboardCR()
    {
        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "The victim hid a key under the mat before they died, it opened a locked cabinet which the intruder also tried to enter. This was inside. ";
        FemaleSpeech.text = "";
        ID.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(8);

        ID.GetComponent<SpriteRenderer>().enabled = false;
       
        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
        FemaleSpeech.text = "What?! These are ID documents belonging to Gabriella Lucifer!";

        yield return new WaitForSeconds(8);

        FemaleSpeech.text = "This is a royal member of the Lucifer family! A powerful family in Hell.";

        yield return new WaitForSeconds(8);

        FemaleSpeech.text = "Strap in detective... We're in for something big.";

        yield return new WaitForSeconds(5);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
        FemaleSpeech.text = "";
        EndScore();
        quitB.gameObject.SetActive(true);

    }
    public IEnumerator EndMurderCR()
    {
        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        dick.GetComponent<SpriteRenderer>().enabled = true;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        Speech.text = "Im not sure... I dont know what they were after.";
        FemaleSpeech.text = "";     
        yield return new WaitForSeconds(8);

        ID.GetComponent<SpriteRenderer>().enabled = false;

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = true;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
        FemaleSpeech.text = "It looks like the intruder tried to force themselves into that cabinet, lets break it open and see whats inside.";

        yield return new WaitForSeconds(8);

        ID.GetComponent<SpriteRenderer>().enabled = true;

        FemaleSpeech.text = "What?! These are ID documents belonging to Gabriella Lucifer!";

        yield return new WaitForSeconds(8);

        FemaleSpeech.text = "This is a royal member of the Lucifer family! A powerful family in Hell.";

        yield return new WaitForSeconds(8);

        FemaleSpeech.text = "Strap in detective... We're in for something big.";

        yield return new WaitForSeconds(5);

        FemaleDetective.GetComponent<SpriteRenderer>().enabled = false;
        FemaleSpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        dick.GetComponent<SpriteRenderer>().enabled = false;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
        Speech.text = "";
        FemaleSpeech.text = "";
        EndScore();
        quitB.gameObject.SetActive(true);
    }
}
