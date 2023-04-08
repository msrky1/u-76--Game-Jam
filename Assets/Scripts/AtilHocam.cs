using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AtilHocam : MonoBehaviour
{ 

   public  float radNum = 0f;
   
    public float speed = 0f;
    private SpriteRenderer _spriteRender;


    private Animator _animator;
    private Rigidbody2D _r2D;
  
    void Start()
    {
  

        _animator = GetComponent<Animator>();
        _spriteRender = GetComponent<SpriteRenderer>();
        _r2D = GetComponent<Rigidbody2D>();
      
    
    }

    

  
    void Update()
    {


        
    //   radNum = Random.Range(1,10);
    //   Debug.Log(radNum);





    }
}
