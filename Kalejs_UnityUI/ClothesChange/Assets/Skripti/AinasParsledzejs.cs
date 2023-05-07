using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinasParsledzejs : MonoBehaviour {

    public void uzSakumu()
    {
        SceneManager.LoadScene("GameChangeClothes", LoadSceneMode.Single);
    }


    public void varonis_1()
    {
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }

    public void varonis_2()
    {
        SceneManager.LoadScene("Sakums 1", LoadSceneMode.Single);
    }


    public void Apturet()
    {
        Application.Quit();
    }
}
