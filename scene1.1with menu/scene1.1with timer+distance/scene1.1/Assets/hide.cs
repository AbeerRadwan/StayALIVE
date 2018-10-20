using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class hide : MonoBehaviour {

    public Image image;

	// Use this for initialization
	void Start () {
        image.SetEnabled(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
