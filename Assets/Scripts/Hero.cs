using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    private Rigidbody2D rb;
    private Rigidbody2D heroRB;

    public float maxSpeed = 3;
    public float speed = 50f;
    public float jumpPower = 150f;
    public float jumpVelocity = 6;
    public float checkRadius;

    public Transform groundCheck, headCheck;

    private bool isGrounded = false;
    private bool headHit = false;
    bool isGameOver = false;


    public LayerMask whatIsGround;

    private int health = 1;
    private int extraJumps;
    public int extraJumpsValue;

    float posX = 0.0f;


    platformScroller myPlatformController;

    [SerializeField]
    GameObject restartButton;



    //Added newly
    private ScoreManager theScoreManager;




    private void OnTriggerEnter2D(Collider2D col)
    {
        //Added newly
        theScoreManager.scoreIncreasing = false;
  

        health--;
        if (health == 0)
        {
            Destroy(gameObject);
            restartButton.SetActive(true);
        }

       
    }


    // Use this for initialization
    void Start()
    {

        myPlatformController = FindObjectOfType<platformScroller>();


        // Initialise the heros rigidbody so that it can be used for functions such as jump
        GameObject temporary = GameObject.Find("hero");
        heroRB = temporary.GetComponent<Rigidbody2D>();

        // Store the headcheck variable so that we can get the transform of the ground
        GameObject tempor = GameObject.Find("HeadCheck");
        headCheck = tempor.GetComponent<Transform>();

        // Store the groundcheck variable so that we can get the transform of the ground
        GameObject temp = GameObject.Find("GroundCheck");
        groundCheck = temp.GetComponent<Transform>();

        // Jump value
        extraJumps = extraJumpsValue;

        posX = transform.position.x;

        // Added newly
        theScoreManager = FindObjectOfType<ScoreManager>();


        // Hides the jump button
        restartButton.SetActive(false);
    }




    private void FixedUpdate()
    {

        // If the hero is knocked of his initial position on the x axis the game ends
        if (transform.position.x < posX)
        {
            GameOver();
        }

        // Used to tell if the hero is currently walking on the floor tag element if he is and game isn't over, he is able to jump
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        if (Input.GetButtonDown("jumpButton") && !isGameOver)
        {
            jump();
        }


        // Added newly
        //theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;


    }




    // Used to debug and check that the hero is currently standing on the floor, using the groundcheck attached to his feet,
    // the radius of the check and what element we defined as ground in the Unity editor.
    private void groundCheckLog()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        if (isGrounded == true)
        {
            extraJumps = 1;
            Debug.Log("You are standing on the floor");

        } 
        if (isGrounded == false)
        {
            Debug.Log("You are not standing on the floor");
        }
    }


    // Operates in a similar way to groundcheck, this was placed on the heros head to prevent him from dying when his head hit
    // the bottom of the platform. When his head hits the platform then he will translate down the y axis at the same speed he 
    // jumped and hit it. 

    private void headCheckLog()
    {
        headHit = Physics2D.OverlapCircle(headCheck.position, checkRadius, whatIsGround);
        if (headHit == true)
        {
            extraJumps = 1;
            Debug.Log("You are standing on the floor");
            GetComponent<Rigidbody2D>().velocity = Vector2.down * jumpPower;

        }
    }


    // Used for logging to see if the colliders were working correctly
    private void Update()
    {
        groundCheckLog();
    }


    // ends the game
    void GameOver()
    {
        isGameOver = true;
        myPlatformController.GameOver();

    }


    // This function is attatched to a button press. When the button is pressed the hero's rigidbody will translate up the 
    // y axis and make him jump. This can only be done if his jump count is greater than 0. He will be able to jump until he has 
    // 0 jumps left because the value is deducted from every time the hero jumps. 
    public void jump()
    {
        if (extraJumps > 0)
        {
            heroRB.velocity = Vector2.up * jumpPower;
            extraJumps--;
        }
    }


}
