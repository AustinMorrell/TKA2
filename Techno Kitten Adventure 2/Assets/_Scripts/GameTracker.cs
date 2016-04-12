using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameTracker : MonoBehaviour {

    [SerializeField]
    private GameObject Fire;
    [SerializeField]
    private Text Stuff;
    [SerializeField]
    protected float WaitForFire;
    protected float count;
    protected bool DoIt;
    public int Score;

    // Use this for initialization
    void Start ()
    {
        Score = 0;
        DoIt = false;
	}

    // Update is called once per frame
    void Update()
    {
        Score += 1;
        Stuff.text = "Score: " + Score;

        if (Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene("Choose-Map");
        }

        if (DoIt)
        {
            transform.position = new Vector3(Random.Range(-9.0f, 9.0f), transform.position.y, transform.position.z);
            Instantiate(Fire, gameObject.transform.position, Quaternion.identity);
            DoIt = false;
        }
        else
        {
            count += Time.deltaTime;
            if (count >= WaitForFire)
            {
                DoIt = true;
                count = 0;
            }
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
