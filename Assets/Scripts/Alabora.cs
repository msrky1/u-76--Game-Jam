using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alabora : MonoBehaviour
{


    public float speed;

    private SpriteRenderer _spriteRender;

    Vector3 newVector;
    private Animator _animator;
    private Rigidbody2D _r2D;


    public float kitapSayac;


    public GameObject gorevOne;
    public float up;
    public float down;


    public Text sayac;








    void Awake()
    {
        _animator = GetComponent<Animator>();
        _spriteRender = GetComponent<SpriteRenderer>();
        _r2D = GetComponent<Rigidbody2D>();


    }
    void Start()
    {
        speed = 0f;
        up = 0f;
        down = 0f;
        kitapSayac = 0;





    }



    void Update()
    {

        _animator.SetFloat("speed", speed);
        _animator.SetFloat("up", up);
        _animator.SetFloat("down", down);
    }

    void FixedUpdate()
    {


        sayac.text = kitapSayac.ToString();






        if (Input.GetKey(KeyCode.D))
        {

            speed = 2f;
            transform.position += new Vector3(Time.deltaTime * speed, 0, 0);

            _spriteRender.flipX = false;

            if (Input.GetKey(KeyCode.W))
            {

                speed = 2f;
                up = 2f;
                transform.position += new Vector3(Time.deltaTime * speed, Time.deltaTime * up, 0);
            }

            if (Input.GetKey(KeyCode.S))
            {

                speed = 2f;
                down = 2f;
                transform.position += new Vector3(Time.deltaTime * speed, Time.deltaTime * -down, 0);
            }




        }
        else if (Input.GetKey(KeyCode.A))
        {




            speed = 2f;
            transform.position += new Vector3(Time.deltaTime * -speed, 0, 0);

            _spriteRender.flipX = true;


            if (Input.GetKey(KeyCode.S))
            {
                speed = 2f;
                down = 2f;

                transform.position += new Vector3(Time.deltaTime * -speed, Time.deltaTime * -down, 0);
            }


        }
        else if (Input.GetKey(KeyCode.S))
        {

            down = 2f;

            transform.position += new Vector3(0, Time.deltaTime * -down, 0);


        }








        else
        {


            speed = 0f;
            down = 0f;
            up = 0f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.A))
            {

                speed = 2f;
                up = 2f;
                transform.position += new Vector3(Time.deltaTime * -speed, Time.deltaTime * up, 0);

                _spriteRender.flipX = true;
            }
            else
            {

                up = 2f;
                transform.position += new Vector3(0, Time.deltaTime * up, 0);

            }



        }

        if (kitapSayac == 5)
        {




           Destroy(gorevOne);

           sayac = 5;




        }



    }

    private void OnCollisionEnter2D(Collision2D other)
    {



        if (other.gameObject.CompareTag("kitap"))
        {


            kitapSayac++;
            Destroy(other.gameObject);



        }



    }
}
