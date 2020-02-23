using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moralitychange : MonoBehaviour
{
    public float Morality;
    public Slider moralityslider;

    // Update is called once per frame
    void Update()
    {
        moralityslider.value = Morality;
    }

    public void Addmorality()
    {
        Morality += 0.1f;
    }

    public void Removemorality()
    {
        Morality -= 0.1f;
    }
}
