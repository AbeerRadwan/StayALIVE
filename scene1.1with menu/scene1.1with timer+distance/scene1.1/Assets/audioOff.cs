using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioOff : MonoBehaviour {
    AudioSource[] m_MyAudioSource;
  
    public GameObject fire; 
    // Use this for initialization
    void Start () {
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
      
    }
	
	// Update is called once per frame
	void Update () {
        if (fire == null)
        {
            foreach (AudioSource audioS in m_MyAudioSource)
            {
                audioS.Stop();
            }
            //   m_MyAudioSource.Stop();
        }
	}
}
