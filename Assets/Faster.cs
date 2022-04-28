using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faster : MonoBehaviour
{
    AudioSource audioSource;
    int pitch = 1;
    float time = 0f, val = 2f / 60f;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        float pitchVal = pitch + (val * time);
        audioSource.pitch = pitchVal;
    }
}
