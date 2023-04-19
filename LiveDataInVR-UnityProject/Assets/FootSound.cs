using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSound : MonoBehaviour
{
    public AudioSource parlante;
    public AudioClip[] arrayAudioClip;
    public float StartAtDistanceValue = 10;

    void Start()
    {
        previousPosition = this.transform.position;
    }

    private Vector3 previousPosition;
    private Vector3 newPosition;
    private float distance;
    private float timer = 0;
    private float waitTime = 3;
    private bool FirstActionDone = false;
    void Update()
    {
        newPosition = this.transform.position;
        distance = Vector3.Distance(previousPosition, newPosition);
        timer += Time.deltaTime;
        if (timer > waitTime && distance >= StartAtDistanceValue && !FirstActionDone)
        {
            parlante.clip = arrayAudioClip[Random.Range(0, arrayAudioClip.Length)];
            parlante.Play();
            timer = 0;
            FirstActionDone = true;
        }
    }
}
