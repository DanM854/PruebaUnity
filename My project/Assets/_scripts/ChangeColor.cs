using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChangeCOlor : MonoBehaviour

    
{

    public GameObject hexagono;
    private SpriteRenderer _renderer;
    private string position;
    private Color color;


    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        ChangeColor();
        ChangePos();
        Debug.Log(string.Format("la posicion es {0} y su color es {1}", position, color));
        
    }

    // Update is called once per frame
    void ChangeColor()
    {
        _renderer.color = Color.blue;
        color = _renderer.color;
    }

    void ChangePos()
    {
        transform.position = hexagono.transform.position;
        position = transform.position.ToString();
    }
}
