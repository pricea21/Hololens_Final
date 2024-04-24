using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderCheck : MonoBehaviour
{
    public AudioSource source;
    public GameObject Confetti;
    public Orders orders;
    private int soundNum = 0;
    public int randNum;

    public GameObject menu1;
    public GameObject menu2;
    public GameObject menu3;
    public GameObject menu4;

    void Start()
    {
        randNum = Random.Range(1, 5);
        Debug.Log(randNum);
    }

    // Update is called once per frame
    void Update()
    {
        if (randNum == 1)
        {
            menu1.SetActive(true);

            if (orders.Oreocupcake == true && orders.lemonade == true && orders.macarons == true && orders.Eggtoast == true)
            {
                Confetti.SetActive(true);

                if (source.isPlaying == false && soundNum == 0)
                {
                    soundNum++;
                    source.Play();
                }
            }
        }

        if (randNum == 2)
        {
            menu2.SetActive(true);

            if (orders.Raspcupcake == true && orders.OrangeJuice == true && orders.BlueBerryCheesecake == true && orders.Marmaladetoast == true)
            {
                Confetti.SetActive(true);

                if (source.isPlaying == false && soundNum == 0)
                {
                    soundNum++;
                    source.Play();
                }
            }
        }

        if (randNum == 3)
        {
            menu3.SetActive(true);

            if (orders.ChocolateMuffin == true && orders.Coffee == true && orders.Croissant == true && orders.ChocolateCheesecake == true)
            {
                Confetti.SetActive(true);

                if (source.isPlaying == false && soundNum == 0)
                {
                    soundNum++;
                    source.Play();
                }
            }
        }

        if (randNum == 4)
        {
            menu4.SetActive(true);

            if (orders.HeartCupcake == true && orders.Donut == true && orders.Cookie == true && orders.Sandwich == true)
            {
                Confetti.SetActive(true);

                if (source.isPlaying == false && soundNum == 0)
                {
                    soundNum++;
                    source.Play();
                }
            }
        }

    }
}
