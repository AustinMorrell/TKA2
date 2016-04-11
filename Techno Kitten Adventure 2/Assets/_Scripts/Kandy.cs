using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Kandy : MonoBehaviour {

    public void OnClick()
    {
        gameObject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Kandy Map");
    }
}
