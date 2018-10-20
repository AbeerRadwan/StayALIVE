using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class moveObject : MonoBehaviour // required interface when using the OnPointerDown method.
 {


    public GameObject item;
    int time = (int)timer.timeLeft;
    public Transform itempos;
    public GameObject firep;
    public Transform fire;
    public Transform fireSparks;
    public Transform fireGlow;
    public Transform fireAlpha;
    public Transform itemP;
    public GameObject tempParent;
    public Transform guide;
    public AudioClip sound;
    AudioSource exp;
    float growthInterval; // seconds
    float growthRate;     // meters/second
 int particleDensity;   // # particles/meter

    // Use this for initialization

   
    void Update()
    {
       

        Vector3 directionToTarget = guide.position - itemP.position;
        float angle = Vector3.Angle(guide.forward, directionToTarget);
        float distance = directionToTarget.magnitude;
        //Mathf.Abs(angle) < 90
        if (  distance < 1)
        {
           // Debug.Log("target is in front of me");
            if (Input.GetKeyDown(KeyCode.A) || Input.GetButtonDown("pickUp"))
            {
                item.GetComponent<Rigidbody>().useGravity = false;
                item.GetComponent<Rigidbody>().isKinematic = true;
                item.transform.localScale = new Vector3(0.02f, 0.02f, 0.02f);
                item.transform.position = guide.transform.position;
                item.transform.parent = tempParent.transform;

            }


            else if (Input.GetKeyDown(KeyCode.D) || Input.GetButtonDown("drop"))
            {
                item.GetComponent<Rigidbody>().useGravity = true;
                item.GetComponent<Rigidbody>().isKinematic = false;
                  item.transform.position = itempos.position;
               // item.transform.position = item.transform.position;
                item.transform.parent = item.transform;

            }

        }// pick up


        Vector3 directionToTarget2 = itemP.position - fire.position;
        float angle2 = Vector3.Angle(guide.forward, directionToTarget2);
        float distance2 = directionToTarget2.magnitude;
        //Mathf.Abs(angle) < 90
        if (distance2 < 3)
        {
           // Debug.Log("fireeeeeeeeeeeeeeeeeeeeeeee is in front of me");
            if (Input.GetKeyDown(KeyCode.D) || Input.GetButtonDown("drop"))
            {
                Debug.Log("boioooooooooooooooooooooooooom");
                item.transform.position = new Vector3(0.94133f, 0.018655f, 0.005189f);
                exp = GetComponent<AudioSource>();
                exp.Play();
                //AudioSource.PlayClipAtPoint(sound, fire.transform.position);
                fire.localScale += new Vector3(0.5f, 0.5f, 0.5f);
                fireAlpha.localScale += new Vector3(0.5f, 0.5f, 0.5f);
                fireSparks.localScale += new Vector3(0.5f, 0.5f, 0.5f);
                fireGlow.localScale += new Vector3(0.5f, 0.5f, 0.5f);








            }
        }// fire interaction


        }

    RaycastHit hit;

 
     public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(this.gameObject.name + " Was Clicked.");
    }




   
}
