using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddNewPostScript : MonoBehaviour
{
    public string postTitle;
    public string postText;

    public GameObject inputTitle;
    public GameObject inputText;
    public GameObject post;
    private bool enterFlag = false;
    private Vector3 [] positions;
    private Vector3 nextPostPos = new Vector3(0, 0, 0);

    private void Start()
    {
        positions[0] = new Vector3(-6, 2, -0.5f);
    }

    public void StoreTexts()
    {
        postTitle = inputTitle.GetComponent<TMP_Text>().text;
        postText = inputText.GetComponent<TMP_Text>().text;
        enterFlag = true;
    }

    private void Update()
    {
        if (enterFlag)
        {
            enterFlag = false;
            putNextPos();
            GameObject.Instantiate(post, nextPostPos, Quaternion.identity);
        }
    }

    private void putNextPos()
    {
    }
}