using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour
{
    public int eventnumber;
    public Text eventtext;
    MoneyTExt moneyText;
    Moralitychange moralitychange;
    List<Events> events;

    void Start()
    {
        GameObject Money = GameObject.Find("Money");
        moneyText = Money.GetComponent<MoneyTExt>();
        GameObject Morality = GameObject.Find("Morality");
        moralitychange = Morality.GetComponent<Moralitychange>();
        events = new List<Events>();
        events.Add(new Moneyevent());
        events.Add(new Moralityevent());

    }



    public class Moneyevent : Events
    {
        public void Update(int number)
        {
            eventtext.text = "Money";
            if (number == 0)
            {
                moneyText.Moneys -= 1;
            }
            else
            {
                moneyText.Moneys += 1;
            }
        }
    }

    public class Moralityevent : Events
    {
        public void Update(int number)
        {
            eventtext.text = "Morality";
            if (number == 0)
            {
                moralitychange.Morality -= 0.1f;
            }
            else
            {
                moralitychange.Morality += 0.1f;
            }
        }
    }
}
