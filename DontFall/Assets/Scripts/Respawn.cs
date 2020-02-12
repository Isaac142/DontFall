using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //This was apart of the "die" and "respawn"

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.gameObject.CompareTag("Red_Wall"))
        {
            Debug.Log("hit");
            //player.GetComponent<Renderer>().material.color = Color.green;
            SceneManager.LoadScene("_Scene_01");
        }
    }
}
