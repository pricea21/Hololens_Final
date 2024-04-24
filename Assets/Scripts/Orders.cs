using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Orders : MonoBehaviour
{
    // Start is called before the first frame update

    public bool Oreocupcake = false;
    public bool lemonade = false;
    public bool macarons = false;
    public bool Eggtoast = false;

    public bool Raspcupcake = false;
    public bool OrangeJuice = false;
    public bool BlueBerryCheesecake = false;
    public bool Marmaladetoast = false;

    public bool ChocolateMuffin = false;
    public bool Coffee = false;
    public bool Croissant = false;
    public bool ChocolateCheesecake = false;

    public bool HeartCupcake = false;
    public bool Donut = false;
    public bool Cookie = false;
    public bool Sandwich = false;
    void Start()
    {
        //i love you
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "OreoCupcake")
        {
            Debug.Log("OreoCupcake found");
            Oreocupcake = true;
        }

        if (collision.gameObject.tag == "Lemonade")
        {
            Debug.Log("Lemonade found");
            lemonade = true;
        }

        if (collision.gameObject.tag == "Macarons")
        {
            Debug.Log("Macaron found");
            macarons = true;
        }

        if (collision.gameObject.tag == "EggOnToast")
        {
            Debug.Log("Egg On Toast found");
            Eggtoast = true;
        }

        if (collision.gameObject.tag == "RaspCupcake")
        {
            Debug.Log("RaspberryCupcake found");
            Raspcupcake = true;
        }

        if (collision.gameObject.tag == "OrangeJuice")
        {
            Debug.Log("Orange Juice found");
            OrangeJuice = true;
        }

        if (collision.gameObject.tag == "BlueCheesecake")
        {
            Debug.Log("Blueberry Cheesecake found");
            BlueBerryCheesecake = true;
        }

        if (collision.gameObject.tag == "MarmaladeToast")
        {
            Debug.Log("Marmalade Toast found");
            Marmaladetoast = true;
        }

        if (collision.gameObject.tag == "ChocoMuffin")
        {
            Debug.Log("Chocolate Muffin found");
            ChocolateMuffin = true;
        }

        if (collision.gameObject.tag == "Coffee")
        {
            Debug.Log("Coffee found");
            Coffee = true;
        }

        if (collision.gameObject.tag == "Croissant")
        {
            Debug.Log("Croissant found");
            Croissant = true;
        }

        if (collision.gameObject.tag == "ChocoCheesecake")
        {
            Debug.Log("Chocolate Cheesecake found");
            ChocolateCheesecake = true;
        }

        if (collision.gameObject.tag == "HeartCupcake")
        {
            Debug.Log("Heart Cupcake found");
            HeartCupcake = true;
        }

        if (collision.gameObject.tag == "Donut")
        {
            Debug.Log("Donut found");
            Donut = true;
        }

        if (collision.gameObject.tag == "Cookie")
        {
            Debug.Log("Cookie found");
            Cookie = true;
        }

        if (collision.gameObject.tag == "Sandwich")
        {
            Debug.Log("Sandwich found");
            Sandwich = true;
        }
    }
}
