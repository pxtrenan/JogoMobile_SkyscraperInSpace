using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private int cena;
    private int temp = 0;
    public GameObject menu;
    public GameObject settingsMenu;
    public GameObject musicON;
    public GameObject musicOFF;
    public GameObject player2;
    public GameObject fundo1;
    public GameObject fundo2;
    public GameObject scenary;
    public GameObject tap;
    public GameObject player;
    public GameObject trueSpawn;
    public GameObject button;
    public GameObject otherGame;

   


    public void TapScene()
    {
        player2.gameObject.SetActive(false);
        fundo1.gameObject.SetActive(false);
        fundo2.gameObject.SetActive(false);
        scenary.gameObject.SetActive(true);
        player.gameObject.SetActive(true);
        trueSpawn.gameObject.SetActive(true);
        tap.gameObject.SetActive(false);
        button.gameObject.SetActive(false);
        

       
    }
  

    public void Settings()
    {
        menu.gameObject.SetActive(false);
        settingsMenu.gameObject.SetActive(true);

    }

    public void OtherGames()
    {
        menu.gameObject.SetActive(false);
        otherGame.gameObject.SetActive(true);
    }

    public void Voltar()
    {
        menu.gameObject.SetActive(true);
        settingsMenu.gameObject.SetActive(false);
    }

    public void Voltar2()
    {
        menu.gameObject.SetActive(true);
        otherGame.gameObject.SetActive(false);
    }

    public void Mute()
    {
        AudioListener.pause = true;
        if (AudioListener.pause)
            musicON.gameObject.SetActive(false);
        musicOFF.gameObject.SetActive(true);
    }
    public void Desmute()
    {
        AudioListener.pause = false;
        musicON.gameObject.SetActive(true);
        musicOFF.gameObject.SetActive(false);
    }


    public void CarregaCena(string nomeCena)
    {

        {
            SceneManager.LoadScene(nomeCena);
        }
    }
    public void CarregarLevelEN(string nomeLevel)
    {

        cena = Random.Range(1, 7);
        Debug.Log(cena);

        while (temp == cena)
        {
            cena = Random.Range(1, 7);
        }

        temp = cena;

        switch (cena)
        {
            case 1:
                SceneManager.LoadScene("Game1");
                break;
            case 2:
                SceneManager.LoadScene("Game2");
                break;
            case 3:
                SceneManager.LoadScene("Game3");
                break;
            case 4:
                SceneManager.LoadScene("Game4");
                break;
            case 5:
                SceneManager.LoadScene("Game5");
                break;
            case 6:
                SceneManager.LoadScene("Game6");
                break;
           
        }
    }
}
