using UnityEngine;
using UnityEngine.UI;
public class puzzelscript : MonoBehaviour
    
{
    public GameObject welcomeText;
    public Text textdisplay;
    public Sprite[] puzzleImages;
    public Image puzzleImage;
    public Image skip;
    string[] answers = { "10","25","12","11","68","128","50","","","","","3011","14","","","","","","",""};
    int curruntPuzzle;
    public int levels;
    public GameObject MenuScreen, LevelScreen, puzzleScreen;

   
    public  void OnEnable()
    {
        textdisplay.text = "";
        curruntPuzzle = PlayerPrefs.GetInt("curruntPuzzle");
        puzzleImage.sprite = puzzleImages[curruntPuzzle - 1];
    }
    
    // Start is called before  the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void btnClick(string num)
    {

        if (textdisplay.text == "Answer")
        {
            textdisplay.text = num;
        }
        else
        {
            textdisplay.text += num;
        }
    }
    public void skippuzzal()
    {
        
            PlayerPrefs.SetInt("curruntPuzzle", curruntPuzzle + 1);
            PlayerPrefs.SetInt("completePuzzle" + (curruntPuzzle - 1), 1);
            puzzleScreen.SetActive(false);
            puzzleScreen.SetActive(true);
        
    }
    public void backSpace()
    {
        textdisplay.text = textdisplay.text.Remove(textdisplay.text.Length - 1);
    }
    public void ans(string num)
    {
        if (textdisplay.text == answers[curruntPuzzle - 1] )
        {
            PlayerPrefs.SetInt("curruntPuzzle", curruntPuzzle + 1);
            PlayerPrefs.SetInt("completePuzzle" + (curruntPuzzle - 1), 1);
            puzzleScreen.SetActive(false);
            puzzleScreen.SetActive(true);
           
        }
       
    }
}
