using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCAtil : MonoBehaviour
{

    public float radNum = 0f;

    public float speed = 0f;
    private SpriteRenderer _spriteRender;


    public GameObject gorevOne;

    
    public GameObject kitaplar;
    private Animator _animator;
    public float task;

    public float taskone;


    

    private SpriteRenderer _spriteRenderer;

 





    float currentTime = 0f;

    float startingTime;

    void Start()
    {

        task = 0f;

        taskone = 0f;
        currentTime = startingTime;


        _spriteRender = GetComponent<SpriteRenderer>();

        _animator = GetComponent<Animator>();

    }




    void Update()
    {


        _animator.SetFloat("task", task);
        startingTime = 5f;
        currentTime -= 1 * Time.deltaTime;
        // Debug.Log(currentTime);


        if (task == 0)
        {

            if (currentTime >= 0)
            {
                speed = 0.5f;
                transform.localPosition += new Vector3(speed * Time.deltaTime, 0, 0);
                _spriteRender.flipX = true;

            }

            else if (currentTime < 0)
            {





                speed = 0.5f;
                transform.localPosition += new Vector3(-speed * Time.deltaTime, 0, 0);
                _spriteRender.flipX = false;


                if (currentTime < -5)
                {



                    currentTime = 5f;


                }


            }







        }



        if (task == 2f)
        {

            if (Input.GetKey(KeyCode.Space))
            {


                task = 0;
                // Debug.Log("Test");
                gorevOne.SetActive(false);

                taskone = 1f;

            }



            //Görevler Görev Başlangıcı

            if (taskone == 1f)
            {

        
                 Debug.Log("Görev Başladı");


               
               kitaplar.SetActive(true);


            

         

            }


        }





    }

    private void OnCollisionEnter2D(Collision2D other)
    {



        if (other.gameObject.CompareTag("Player"))
        {

            task = 2f;

            gorevOne.SetActive(true);

            // Debug.Log("Player Dokunuş");


        }
   

    }
}
