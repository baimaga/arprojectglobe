using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject vbButtonObject;
    private GameObject zombie;
	// Use this for initialization
	void Start () {
        vbButtonObject = GameObject.Find("actionButton");
        zombie = GameObject.Find("zombie");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
        Debug.Log("Button down!!!");
        zombie.GetComponent<Animation>().Play();
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Button released!!!");
        zombie.GetComponent<Animation>().Stop();
    }

}
