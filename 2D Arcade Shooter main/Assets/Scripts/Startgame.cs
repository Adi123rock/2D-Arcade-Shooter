using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour
{
    public GameObject lvlselect;
    string Lvlno;
    //public GameObject lvl;
    public GameMAnager gamec;
    public void Lvlslct(string name)
    {
        lvlselect.SetActive(true);
        Lvlno=name;
        Debug.Log(Lvlno);
        //gamec.GetComponent<GameMAnager>().Lvlselction(Lvlno);
    } 
    public void startgm()
    {
        gamec.GetComponent<GameMAnager>().Lvlselction(Lvlno);
    }
    public void Gamestart()
    {
        Debug.Log(Lvlno);
        //gamec.GetComponent<GameMAnager>().Lvlselction(Lvlno);
    }
    public void lvlsltclose()
    {
        lvlselect.SetActive(false);
    }

    public void Gotolvl()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        gamec.GetComponent<GameMAnager>().Tolvls();
    }
    public void Nextlvl()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    
}
