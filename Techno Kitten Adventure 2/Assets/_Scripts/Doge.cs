using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Doge : MonoBehaviour {

    public void OnClick()
    {
        gameObject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Doge Map");
    }
}
