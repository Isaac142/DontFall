using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public GameObject player;

    public GameManager GM;

    public PlayerCameraMovement PCMX, PCMY;

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
            GM.youLost.SetActive(true);
            Time.timeScale = 0f;
            GM.inGameHUD.SetActive(false);
            PCMX.canMove = false;
            PCMY.canMove = false;
            GM.lostGame = true;
            //player.GetComponent<Renderer>().material.color = Color.green;
            //SceneManager.LoadScene("_Scene_01");
        }

        if (other.gameObject.CompareTag("Win_Wall"))
        {
            Debug.Log("hit");
            GM.youWin.SetActive(true);
            Time.timeScale = 0f;
            GM.inGameHUD.SetActive(false);
            PCMX.canMove = false;
            PCMY.canMove = false;
            GM.wonGame = true;
            //player.GetComponent<Renderer>().material.color = Color.green;
            //SceneManager.LoadScene("_Scene_01");
        }
    }
}