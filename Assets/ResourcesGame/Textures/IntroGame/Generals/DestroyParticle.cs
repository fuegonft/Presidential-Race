﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DestroyParticle : MonoBehaviour {

	public AudioClip sound;
    public List<AudioClip> listSound = new List<AudioClip>();
    public float timeMore = 0f;
    public GameObject hideObjects;

    void Start()
    {
        if (listSound.Count > 0) sound = listSound[Random.Range(0, listSound.Count)];
        bool isCoin = false;
        if (sound != null) if (sound.name == "EatCoin") isCoin = true;
        Modules.PlayAudioClipFree(sound, isCoin);
        if (timeMore < 0) return;
        float time = timeMore;
        ParticleSystem ps = GetComponent<ParticleSystem>();
        if (ps != null)
            time += ps.main.duration;
        if (hideObjects != null)
        {
            hideObjects.GetComponent<Animator>().SetTrigger("TriHide");
            Invoke("ShowPanelHide", time);
        }
        else Destroy(gameObject, time);
    }

    void ShowPanelHide()
    {
        Destroy(gameObject);
    }

    void OnDestroy()
    {
        if (hideObjects != null)
            hideObjects.GetComponent<Animator>().SetTrigger("TriShow");
    }
}