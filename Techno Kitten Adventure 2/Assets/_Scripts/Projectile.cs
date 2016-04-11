using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    protected Player You;
    protected GameTracker TheGame;
    protected float count;

    void Start()
    {
        You = FindObjectOfType<Player>();
        TheGame = FindObjectOfType<GameTracker>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == You.name)
        {
                TheGame.Restart();
        }
    }

    void Update()
    {
        transform.Rotate(0, 0, 20);
        count += Time.deltaTime;
        if (count >= 4)
        {
            Destroy(gameObject);
        }
    }
}
