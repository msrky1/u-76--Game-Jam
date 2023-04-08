using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
public class NPCAtil : MonoBehaviour
{

    public float radNum = 0f;

    public float speed = 0f;
    private SpriteRenderer _spriteRender;




   



    float currentTime = 0f;

  float startingTime;

    void Start()
    {


        currentTime = startingTime;

      
        _spriteRender = GetComponent<SpriteRenderer>();



    }




    void Update()
    {

          

        startingTime = 5f;
        currentTime -= 1 * Time.deltaTime;

        if(currentTime >= 0) {
        speed = 0.5f;
       transform.localPosition += new Vector3(speed * Time.deltaTime, 0, 0);
         _spriteRender.flipX = true;

        }
        
        else if (currentTime < 0)
        {




            
            speed = 0.5f;
            transform.localPosition += new Vector3(-speed * Time.deltaTime, 0, 0);
            _spriteRender.flipX = false;


                 if(currentTime < -5 ) {



                     currentTime = 5f;


                 }
          

        }
 

    

    












    }
}
