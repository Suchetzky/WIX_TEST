using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GPT : MonoBehaviour
{
    public GameObject textObject;
    public void sorry()
    {
        textObject.GetComponent<TMP_Text>().text = "Sorry didn't succeed to integrate it in time /=";
    }
}
