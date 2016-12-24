using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour {

    public SteamVR_TrackedObject TrackedObject;

    private SteamVR_Controller.Device _controller { get { return SteamVR_Controller.Input((int)TrackedObject.index); } }
 
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = _controller.transform.pos;
        gameObject.transform.localRotation = _controller.transform.rot;
    }
}
