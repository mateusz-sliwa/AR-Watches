using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WatchSelect : MonoBehaviour
{
    // inicjacja obiektow zegarka
    public GameObject watchModel1;
    public GameObject watchModel2;
    public GameObject watchModel3;

    //inicjacja obiektow okna zegarka
    public GameObject w1Window;
    public GameObject w2Window;
    public GameObject w3Window;

    //inicjacja obiektów okna zegarka
    public GameObject watchWindow1;
    public GameObject watchWindow2;
    public GameObject watchWindow3;

    Animation w1WindowAnimation;
    Animation w2WindowAnimation;
    Animation w3WindowAnimation;

    // Start is called before the first frame update
    void Start()
    {
        w1WindowAnimation = w1Window.GetComponent<Animation>();
        w2WindowAnimation = w2Window.GetComponent<Animation>();
        w3WindowAnimation = w3Window.GetComponent<Animation>();
    }

    //event listenery dla przyciskow
    public void Watch1ButtonClicked()
    {
        watchWindow1.SetActive(true);
        watchWindow2.SetActive(false);
        watchWindow3.SetActive(false);
        watchModel1.SetActive(true);
        watchModel2.SetActive(false);
        watchModel3.SetActive(false);
        w1WindowAnimation["w1animation"].speed = 1;
        w1WindowAnimation.Play();
    }

    public void Watch2ButtonClicked()
    {
        watchWindow1.SetActive(false);
        watchWindow2.SetActive(true);
        watchWindow3.SetActive(false);
        watchModel1.SetActive(false);
        watchModel2.SetActive(true);
        watchModel3.SetActive(false);
        w2WindowAnimation["w2animation"].speed = 1;
        w2WindowAnimation.Play();
    }

    public void Watch3ButtonClicked()
    {
        watchWindow3.SetActive(false);
        watchWindow3.SetActive(false);
        watchWindow3.SetActive(true);
        watchModel1.SetActive(false);
        watchModel2.SetActive(false);
        watchModel3.SetActive(true);
        w3WindowAnimation["w3animation"].speed = 1;
        w3WindowAnimation.Play();
    }

    public void CloseButtonClicked()
    {
        //string przechowuje nazwe przycisku ktory zostal nacisniety
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "w1close")
        {
            //odwrócenie animacji ktora robi 'slide in' okna zegarka przy zamknieciu tego okna
            w1WindowAnimation["w1animation"].speed = -1;
            w1WindowAnimation["w1animation"].time = w1WindowAnimation["w1animation"].length;
            w1WindowAnimation.Play();
        }
        else if (buttonName == "w2close")
        {
            w2WindowAnimation["w2animation"].speed = -1;
            w2WindowAnimation["w2animation"].time = w1WindowAnimation["w1animation"].length;
            w2WindowAnimation.Play();
        }
        else if (buttonName == "w3close")
        {
            w3WindowAnimation["w3animation"].speed = -1;
            w3WindowAnimation["w3animation"].time = w1WindowAnimation["w1animation"].length;
            w3WindowAnimation.Play();
        }
    }
}
