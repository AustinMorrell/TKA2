using UnityEngine;
using System.Collections;

public class GameCon : MonoBehaviour {

    [SerializeField]
    public Player Char;

    void Start()
    {
        Instantiate(Char, new Vector3(0, -4, 0), Quaternion.identity);
    }
}
