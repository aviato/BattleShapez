using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    public bool touching = false;
    public int damage = 10;
    public Transform shooter;

    void Hit()
    {
        Debug.Log("LOL");
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("My name is: " + col.gameObject.name);

        if (touching == false && col.gameObject.tag != shooter.tag)
        {
            col.gameObject.SendMessage("takeDamage", damage);
            touching = true;
        }

    }

    void OnTriggerExit()
    {
        if (touching == true)
        {
            touching = false;
        }

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
