using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class Player : MonoBehaviour {

    public float speed;

    [Serializable]
    protected class Box
    {
        public float MinX, MinY, MaxX, MaxY;
    }

    [SerializeField]
    protected Box m_ScreenBorders;

    // Use this for initialization
    void Start () {
        m_ScreenBorders.MaxX = 9;
        m_ScreenBorders.MaxY = 5;
        m_ScreenBorders.MinX = -9;
        m_ScreenBorders.MinY = -5;
	}

    void Lerp(float a, float b, float c)
    {
        gameObject.transform.position = new Vector3(transform.position.x + a, transform.position.y - b, transform.position.z + c);
    }

    // Update is called once per frame
    void Update ()
    {
        Lerp(Input.GetAxis("Horizontal") * speed, -Input.GetAxis("Vertical") * speed, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, m_ScreenBorders.MinX, m_ScreenBorders.MaxX), Mathf.Clamp(transform.position.y, m_ScreenBorders.MinY, m_ScreenBorders.MaxY), transform.position.z);
    }
}
