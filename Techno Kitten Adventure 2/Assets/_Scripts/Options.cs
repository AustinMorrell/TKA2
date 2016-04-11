using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour {

    public void OnClick()
    {
        gameObject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Options-Menu");
    }
}
