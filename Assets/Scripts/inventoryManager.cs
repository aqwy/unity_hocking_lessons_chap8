﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryManager : MonoBehaviour, IGameManager
{
    /*private List<string> theItems;*/
    private Dictionary<string, int> theItems;
    public managerStatus status { get; private set; }
    public string equippedItem { get; private set; }
    private void displayItems()
    {
        string itemDisplay = "Items: ";
        /*foreach (string item in theItems)
        {
            itemDisplay += item + " ";
        }*/
        foreach (KeyValuePair<string, int> item in theItems)
        {
            itemDisplay += item.Key + "(" + item.Value + ")";
        }
        Debug.Log(itemDisplay);
    }
    public bool ConsumeItem(string name)
    {
        if (theItems.ContainsKey(name))
        {
            theItems[name]--;
            if (theItems[name] == 0)
            {
                theItems.Remove(name);
            }
        }
        else
        {
            Debug.Log("cannot consume " + name);
            return false;
        }
        displayItems();
        return true;
    }
    public bool EquipItem(string name)
    {
        if (theItems.ContainsKey(name) && equippedItem != name)
        {
            equippedItem = name;
            Debug.Log("Equipped " + name);
            return true;
        }
        equippedItem = null;
        Debug.Log("Unequipped");
        return false;
    }
    public List<string> getItemList()
    {
        List<string> itemList = new List<string>(theItems.Keys);
        return itemList;
    }
    public int getItemCount(string name)
    {
        if (theItems.ContainsKey(name))
            return theItems[name];
        return 0;
    }
    public void addItem(string name)
    {
        /*theItems.Add(name);*/
        if (theItems.ContainsKey(name))
        {
            theItems[name] += 1;
        }
        else
        {
            theItems[name] = 1;
        }
        displayItems();
    }
    public void Startup()
    {
        Debug.Log("Inventory manager started...");
        /*theItems = new List<string>()*/
        ;
        theItems = new Dictionary<string, int>();
        status = managerStatus.Started;
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
