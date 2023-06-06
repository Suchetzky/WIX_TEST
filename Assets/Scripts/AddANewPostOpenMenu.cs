using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class AddANewPostOpenMenu : MonoBehaviour
{
    public GameObject postMenu;
    
    public void openMenuAddPost()
    {
        if (GameObject.FindGameObjectsWithTag("postMenu").Length == 0)
        {
                    GameObject tmp = GameObject.Instantiate(postMenu, new Vector3(-4.8f,3.5f,-1), quaternion.identity);
        }
    }
}
