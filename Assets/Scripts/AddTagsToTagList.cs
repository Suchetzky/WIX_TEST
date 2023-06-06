using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;


public class AddTagsToTagList : MonoBehaviour
{
    public GameObject tag;
    // Start is called before the first frame update
    public Vector3 basicPos;
    private int counter = 0;
    public string tagTitle;
    
    public GameObject inputTitle;
    public GameObject tagMenu;
    private GameObject tmp;
    public void openMenuAddTag()
    {
        print(555);
        tagMenu.gameObject.SetActive(false);
        // if (GameObject.FindGameObjectsWithTag("tagMenu").Length == 0)
        // {
        //     tmp = GameObject.Instantiate(tagMenu, new Vector3(5.8f,2f,-1), quaternion.identity);
        // }
    }
    public void AddTag()
    {
        //tagTitle = inputTitle.GetComponent<TMP_Text>().text;
        GameObject.Instantiate(tag, new Vector3(basicPos.x,basicPos.y-0.7f*counter,-1), quaternion.identity);
        counter++;
    }

}
