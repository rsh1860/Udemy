﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winUI;

    public Itembox[] itemBoxes;

    public bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //SceneManager.LoadScene("Main");
            SceneManager.LoadScene(0); //build setting number
        }

        if(isGameOver==true)
        {
            return;
        }

        int count = 0;
        for(int i=0; i<3; i++)
        {
            if(itemBoxes[i].isOveraped==true)
            {
                count++;
            }
        }
        
        if(count>=3)
        {
            isGameOver = true;
            Debug.Log("GAME WIN");
            winUI.SetActive(true);
        }
    }
}
