﻿using UnityEngine;
using System.Collections;

public class DisableMe : MonoBehaviour {

    public void DisableObjects()
    {
        transform.gameObject.SetActive(false);
    }

    public void DisableShowCardPage()
    {
        transform.gameObject.SetActive(false);
        Modules.ShowScratchCardPage();
    }
}
