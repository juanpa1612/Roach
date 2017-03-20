using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    public int distanceToItem;
    public GameObject carta;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Collect();
	}

    void Collect ()
    {
        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit hit;
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(rayo,out hit,distanceToItem))
            {
                if (hit.collider.gameObject == carta)
                {
                    Debug.Log("PickUp");
                    carta.SetActive(false);
                    
                }
            }
        }
    }
}
