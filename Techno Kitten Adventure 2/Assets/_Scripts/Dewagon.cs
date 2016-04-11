using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Dewagon : MonoBehaviour {

    public void OnClick()
    {
        gameObject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Dewagon");
    }
}
