using UnityEngine;
using System.Collections;

public class Hold : MonoBehaviour {
    SphereCollider trig;
   // public Transform hold;
	// Use this for initialization
	void Start () {
        trig = GetComponentInChildren<SphereCollider>();
	}
	
	// Update is called once per frame
	void Update () {
	
	
        
    /*
            RaycastHit pick;
            Vector3 direction = new Vector3(0f,-1f,0f);
            Ray go = new Ray(trig.center, direction);
        Physics.SphereCast(go, trig.radius,out pick);
            if (pick.distance < trig.radius)
            {
                if (pick.rigidbody.CompareTag("PickUp"))
                {
                    Debug.Log("Pick");
                }
            }
            */

        }
    void OnTriggerEnter(Collision other)
    {
        RaycastHit pick;
        Vector3 direction = (other.contacts[1].point - trig.center);
        Ray go = new Ray(trig.center, direction);
        Physics.Raycast(go, out pick);
        if (pick.distance < trig.radius)
        {
            if (pick.rigidbody.CompareTag("PickUp"))
            {
                Debug.Log("Pick");
            }
        }


    }

}
