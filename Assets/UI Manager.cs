using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI StaminaValue;
    public GameObject Page_1;
    public GameObject Page_2;
    public GameObject DEAD_SCENE;
    public int Stamina;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Stamina = 100;
    }

    // Update is called once per frame
    void Update()
    {
        //Stamina will decrease when going to the next choice of outcome
        StaminaValue.text = Stamina.ToString();
        if (Stamina <= 0)
        {
            DEAD_SCENE.SetActive(true);
            Page_2.SetActive(true);
            Page_1.SetActive(false);
        }
    }
   
    public void SchoolScene()
    {
        //This is page_1
        Stamina = Stamina - 50;
        Page_2.SetActive(false);
        Page_1.SetActive(true);
    }
    public void RoofTopScene()
    {
        //this is Page_2
        Stamina = Stamina - 50;
        Page_2.SetActive(true);
        Page_1.SetActive(false);
    }
    public void Restart()
    {
        //Restart when died
        Stamina = 100;
        Page_2.SetActive(true);
        Page_1.SetActive(false);
        DEAD_SCENE.SetActive(false);
    }


}
