﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string type;
    public int ID;
    public string description;
    public Texture2D icon;
    public bool equipped;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
	{
        if (other.tag == "Item") {

        }

	}

    void AddItem(int itemId , string itemType , string itemDescription , Texture2D itemIcon)
	{

	}

}
