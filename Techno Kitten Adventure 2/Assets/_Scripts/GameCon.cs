using UnityEngine;
using System.Collections;

public class GameCon : MonoBehaviour {

    [SerializeField]
    public Player Char;
    private SaveLoad Word = new SaveLoad();

    void Start()
    {
        Word.Load();
        Instantiate(Char, new Vector3(0, -4, 0), Quaternion.identity);
    }
}
