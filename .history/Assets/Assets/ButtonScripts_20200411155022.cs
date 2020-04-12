using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScripts : MonoBehaviour
{
    public GameObject btn;

    void Start()
    {
        btn.SetActive(True);
    }

    public void Play()
    {
        btn.SetActive(false);
    }



}
