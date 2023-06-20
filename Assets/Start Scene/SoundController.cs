using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private AudioSource[] sesKaynaklari;
    float sesSeviyesi = 1;

    private void Update()
    {
        sesKaynaklari = FindObjectsOfType<AudioSource>();

        // Ses seviyesini güncelle
        if (SoundOptions.instance != null)
        {
            sesSeviyesi = SoundOptions.instance._Value;

        }
        foreach (AudioSource kaynak in sesKaynaklari)
        {
            kaynak.volume = sesSeviyesi;
        }
    }
}
