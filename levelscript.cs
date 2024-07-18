using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Levelscript : MonoBehaviour
{
    public GameObject MenuScreen, LevelScreen, puzzleScreen;
    public GameObject[] buttons;
    public Sprite lockImg, tick;

    
    void OnEnable()
    {
        for(int i = 0; i < buttons.Length; i++)
        {
            int checkId = PlayerPrefs.GetInt("completePuzzle" + i);
            buttons[i].GetComponentInChildren<Text>().text = (i + 1).ToString();
            if(checkId == 1)
            {
                buttons[i].GetComponent<Image>().sprite = tick;
            } else
            {
                buttons[i].GetComponent<Image>().sprite = lockImg;
            }
          
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void btnClick(int no)
    {
        PlayerPrefs.SetInt("curruntPuzzle", no);
        LevelScreen.SetActive(false);
        puzzleScreen.SetActive(true);      
    }
    public void backbtn()
    {
        LevelScreen.SetActive(false);
        MenuScreen.SetActive(true);
    }
    public void backbtn1()
    {
        puzzleScreen.SetActive(false);
       LevelScreen.SetActive(true);
    }


}
