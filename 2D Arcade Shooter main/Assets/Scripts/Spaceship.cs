using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spaceship : MonoBehaviour
{
    public GameObject next_button, prev_button, S_1, S_2, S_3, S_4, S_5, S_6;
    int i = 0;
    public void SelectSpaceship()
    {
        //SceneManager.LoadScene("UI");
        if (S_1.activeInHierarchy)
        {
            Debug.Log("S_1");
            UIvarables.namespaceship = "S_1";
            SceneManager.LoadScene("UI");
        }
        else if (S_2.activeInHierarchy)
        {
            if (Spship_details.S2)
            {
                Debug.Log("S_2");
                UIvarables.namespaceship = "S_2";
                SceneManager.LoadScene("UI");
            }
            else
            {
                Debug.LogError("PLEASE UNLOCK");
            }

        }
        else if (S_3.activeInHierarchy)
        {
            if (Spship_details.S3)
            {
                Debug.Log("S_3");
                UIvarables.namespaceship = "S_3";
                SceneManager.LoadScene("UI");
            }
            else
            {
                Debug.LogError("PLEASE UNLOCK");
            }
        }
        else if (S_4.activeInHierarchy)
        {
            if (Spship_details.S4)
            {
                Debug.Log("S_4");
                UIvarables.namespaceship = "S_4";
                SceneManager.LoadScene("UI");
            }
            else
            {
                Debug.LogError("PLEASE UNLOCK");
            }
        }
        else if (S_5.activeInHierarchy)
        {
            if (Spship_details.S5)
            {
                Debug.Log("S_5");
                UIvarables.namespaceship = "S_5";
                SceneManager.LoadScene("UI");
            }
            else
            {
                Debug.LogError("PLEASE UNLOCK");
            }
        }
        else if (S_6.activeInHierarchy)
        {
            if (Spship_details.S6)
            {
                Debug.Log("S_6");
                UIvarables.namespaceship ="S_6";
                SceneManager.LoadScene("UI");
            }
            else
            {
                Debug.LogError("PLEASE UNLOCK");
            }
        }
        /*
        if(S_1C.activeInHierarchy)
        {
            Debug.Log("S_1C");
            UIvarables.namespaceship="S_1C";
            SceneManager.LoadScene("UI");
        }
        if(S_2C.activeInHierarchy)
        {
            Debug.Log("S_2C");
            UIvarables.namespaceship="S_2C";
            SceneManager.LoadScene("UI");
        }
        if(S_1D.activeInHierarchy)
        {
            Debug.Log("S_1D");
            UIvarables.namespaceship="S_1D";
            SceneManager.LoadScene("UI");
        }
        if(S_2D.activeInHierarchy)
        {
            Debug.Log("S_2D");
            UIvarables.namespaceship="S_2D";
            SceneManager.LoadScene("UI");
        }
        */
    }
    /*
    public void Down()
    {
        prev_button.SetActive(false);
        next_button.SetActive(false);
        j++;
        Upgraded();
    }
    public void Up()
    {
        next_button.SetActive(true);
        if(i>0)
        {
            prev_button.SetActive(true);
        }
        
        j--;
        Upgraded();
    }
    */
    public void Previous()
    {
        i--;
        nextspaceship();
    }
    public void Next()
    {
        i++;
        nextspaceship();
    }
    void nextspaceship()
    {
        Debug.Log(i);
        if (i == 0)
        {
            prev_button.SetActive(false);
            S_1.SetActive(true);
            S_2.SetActive(false);
        }
        else if (i == 1)
        {
            prev_button.SetActive(true);
            S_1.SetActive(false);
            S_2.SetActive(true);
            S_3.SetActive(false);
        }
        else if (i == 2)
        {
            S_2.SetActive(false);
            S_3.SetActive(true);
            S_4.SetActive(false);
        }
        else if (i == 3)
        {
            S_3.SetActive(false);
            S_4.SetActive(true);
            S_5.SetActive(false);
        }
        else if (i == 4)
        {
            next_button.SetActive(true);
            S_4.SetActive(false);
            S_5.SetActive(true);
            S_6.SetActive(false);
        }
        else if (i == 5)
        {
            next_button.SetActive(false);
            S_5.SetActive(false);
            S_6.SetActive(true);
        }
    }
    /*
    void Upgraded()
    {
        if(j==0)
        {
            up.SetActive(false);
            down.SetActive(true);
            Upspaceship();
        }
        else if(j==1)
        {
            up.SetActive(true);
            down.SetActive(false);
            Downspaceship();
        }
    }
    void Downspaceship()
    {
        if(i==0)
        {
            S_1A.SetActive(true);
            S_2A.SetActive(false);
        }
        else if(i==1)
        {
            S_1D.SetActive(true);
            S_2D.SetActive(false);
        }
        else if(i==2)
        {
            S_1C.SetActive(true);
            S_2C.SetActive(false);
        }
    }
    void Upspaceship()
    {
        if(i==0)
        {
            S_1A.SetActive(false);
            S_2A.SetActive(true);
        }
        else if(i==1)
        {
            S_1D.SetActive(false);
            S_2D.SetActive(true);
        }
        else if(i==2)
        {
            S_1C.SetActive(false);
            S_2C.SetActive(true);
        }
    }
    */
}
