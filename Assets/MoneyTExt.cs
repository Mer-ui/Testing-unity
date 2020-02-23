using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyTExt : MonoBehaviour
{
    public int Moneys;
    public Text moneytext;

    // Update is called once per frame
    void Update()
    {
        moneytext.text = "Money : " + Moneys;
    }
}
