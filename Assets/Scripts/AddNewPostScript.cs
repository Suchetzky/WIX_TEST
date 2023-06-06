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

    private GameObject tmpPost;
    
    private bool enterFlag = false;
    static private int counter = 0;
    private Vector3 [] positions = new []{Vector3.zero,Vector3.zero,Vector3.zero,Vector3.zero,Vector3.zero};
    private Vector3 nextPostPos = new Vector3(0, 0, 0);

    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            positions[i] = new Vector3(-6, 1.9f-2*i, -0.5f);
        }
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
            tmpPost = GameObject.Instantiate(post, nextPostPos, Quaternion.identity);
            tmpPost.transform.Find("Canvas").gameObject.gameObject.transform.Find("PostTitle").gameObject
                .GetComponent<TMP_Text>().text = postTitle;
            tmpPost.transform.Find("Canvas").gameObject.gameObject.transform.Find("PostText").gameObject
                .GetComponent<TMP_Text>().text = postText;
            Destroy(gameObject);
        }
    }

    private void putNextPos()
    {
        nextPostPos = positions[counter];
        if (counter < 4)
        {
            counter++;
        }
        
    }
}