using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSpawner : MonoBehaviour
{
    public GameObject[] panels;
    public float beat;
    private float timer;

    private void Update()
    {
        if(timer > beat)
        {
            Instantiate(panels[Random.Range(0, 5)], transform.position, transform.rotation);
            timer -= beat;
        }
        timer += Time.deltaTime;
    }
}
