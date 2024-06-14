using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    //public Text levelCleared;
    public GameObject transition;

    private void Update()
    {
        AllFruitCollected();
    }

    public void AllFruitCollected() {

        if (transform.childCount==0)
        {
            Debug.Log("Has recolectado todas las frutas, Victoria!");
            //levelCleared.gameObject.SetActive(true);
            transition.SetActive(true);
            Invoke("ChangeScene",1);


            PlayerPrefs.DeleteAll();

        }

    }

    void ChangeScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }

}
