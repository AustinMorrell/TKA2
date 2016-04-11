using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Waterfall : MonoBehaviour {

    public void OnClick()
    {
        gameObject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Waterfall");
    }
}
