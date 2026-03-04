using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player_animation : MonoBehaviour
{
    private Animator _animator;
    private NewInput _newInput;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _newInput = GetComponent<NewInput>();
    }

    // Update is called once per frame
    void Update()
    {

        PlayerMoveAnim();
    }

    public void PlayerMoveAnim()
    {
       
        _animator.SetBool("isMoving", _newInput.inputX != 0);
       
    }
   
}
