using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitsManager : MonoBehaviour
{

    public GameObject levelFinish;
    public GameObject cobre;


    void Start()
    {
        cobre.SetActive(false);
    }

    public void AllFruitsCollected()
    {
        if (transform.childCount == 3)
        {
            cobre.SetActive(true);

        }
    }
}
