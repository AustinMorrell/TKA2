using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Leaderboard : MonoBehaviour {

    public void OnClick()
    {
        gameObject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Leaderboard-Menu");
    }
}
