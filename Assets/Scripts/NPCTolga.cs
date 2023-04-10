using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NPCTolga : MonoBehaviour
{

    // public float radNum = 0f;
 public float radNum = 0f;

    public float speed = 0f;
    private SpriteRenderer _spriteRender;


    public GameObject gorevOne;


    public GameObject kitap01;
    public GameObject kitap02;
    public GameObject kitap03;
    public GameObject kitap04;
    public GameObject kitap05;
    private Animator _animator;
    public float task;

    public float taskone;
    public GameObject _text;



    private SpriteRenderer _spriteRenderer;





    [SerializeField] private Image _time;
    [SerializeField] private Text _timeText;
    [SerializeField] private float _currentTime;
    [SerializeField] private float _duration;

    public GameObject Timer;


    float currentTime = 0f;

    float startingTime;

    void Start()
    {

        task = 0f;

        taskone = 0f;
        currentTime = startingTime;


        _spriteRender = GetComponent<SpriteRenderer>();

        _animator = GetComponent<Animator>();

        _currentTime = _duration;
        _timeText.text = _currentTime.ToString();
       

    }

 private IEnumerator CountdownTime()
    {
        while (_currentTime >= 0)
        {
            _time.fillAmount = Mathf.InverseLerp(0, _duration, _currentTime);
            _timeText.text = _currentTime.ToString();
            yield return new WaitForSeconds(1f);
            _currentTime--;

            
        }
        if( _currentTime == -1 ){

                  SceneManager.LoadScene(5);


            }  
        yield return null;
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
                _text.SetActive(true);
                taskone = 1f;
                Timer.SetActive(true);
                StartCoroutine(CountdownTime());


            }



            //Görevler Görev Başlangıcı

            if (taskone == 1f)
            {


                Debug.Log("Görev Başladı");



                kitap01.SetActive(true);
                kitap02.SetActive(true);
                kitap03.SetActive(true);
                kitap04.SetActive(true);
                kitap05.SetActive(true);






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
