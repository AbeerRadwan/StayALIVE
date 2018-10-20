using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
    public static bool flag = false;
    public static int timeLeft = 30;
    public Text countdownText;
    public Transform fire;
    public Image image;
    GameObject kitchen;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
        image.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("Time Left = " + timeLeft);

        if (timeLeft <= 0 && flag==false )
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Times Up You Lost!";
            image.enabled = true;
            


            //fire.localScale += new Vector3(0.9f, 0.9f, 0.9f);
        }
        if (timeLeft >= 0 && flag == true)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "You won!";
            image.enabled = true;

        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}

