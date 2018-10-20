using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSand : MonoBehaviour
{

    public GameObject item;
    public GameObject tempParent;
    public Transform guide;
    public Transform itemP;
    public Transform itempos;
    int time = (int)timer.timeLeft;
    public GameObject firep;
    public Transform fire;
    // Use this for initialization
    void Start()
    {
        item.GetComponent<Rigidbody>().useGravity = false;
    }



    void Update()
    {


        Vector3 directionToTarget = guide.position - itemP.position;
        float angle = Vector3.Angle(guide.forward, directionToTarget);
        float distance = directionToTarget.magnitude;

        if (distance < 1)
        {
           // Debug.Log("target is in front of me");
            if (Input.GetButtonDown("pickUp"))
            {
                item.GetComponent<Rigidbody>().useGravity = false;
                item.GetComponent<Rigidbody>().isKinematic = true;
                item.transform.position = guide.transform.position;
                item.transform.parent = tempParent.transform;

            }

           else if (Input.GetButtonDown("drop"))
            {
                item.GetComponent<Rigidbody>().useGravity = true;
                item.GetComponent<Rigidbody>().isKinematic = false;
                item.transform.position = itempos.position;
                 item.transform.parent = item.transform;
                

            }

        }


        Vector3 directionToTarget2 = itemP.position - fire.position;
        float angle2 = Vector3.Angle(guide.forward, directionToTarget2);
        float distance2 = directionToTarget2.magnitude;
        //Mathf.Abs(angle) < 90
        if (distance2 < 2)
        {
            Debug.Log("fireeeeeeeeeeeeeeeeeeeeeeee is in front of me");
            if (Input.GetButtonDown("drop"))
            {
                Debug.Log("boioooooooooooooooooooooooooom");
               

                item.GetComponent<Rigidbody>().useGravity = true;
                item.GetComponent<Rigidbody>().isKinematic = false;
                item.transform.position = itempos.position;
                item.transform.parent = item.transform;
               // Destroy(item);
                Destroy(firep, 0.6f);
                if (time > 0)
                {
                    timer.flag = true;
                }

                //  firep.SetActive(false);

            }
        }// fire interaction




    }





}