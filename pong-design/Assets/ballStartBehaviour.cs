using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ballStartBehaviour : MonoBehaviour {

    //Integeres for Ball Control
    int Invert;
    public int TowardsPlayer = 1;
    private Rigidbody myRigidbody;
    public float speed = 30;

    private double playerLeft;
    private double playerRight;
    
    public Text countPlayerLeft;
    public Text countPlayerRight;

    // Use this for initialization
    void Start () {
        StartCoroutine(startSetup());
    }
    IEnumerator startSetup()
    {
        playerLeft=0;
        playerRight=0;

        setplayerLeftScore();
        setplayerRightScore();
        countPlayerLeft.text = "3!";
        countPlayerRight.text = "3!";
        yield return new WaitForSeconds(1);
        countPlayerLeft.text = "2!";
        countPlayerRight.text = "2!";
        yield return new WaitForSeconds(1);
        countPlayerLeft.text = "1!";
        countPlayerRight.text = "1!";
        yield return new WaitForSeconds(1);
        finishSetup();        
    }

    void finishSetup() {
        Invert = 1;
        TowardsPlayer = 1;
        this.myRigidbody = this.GetComponent<Rigidbody>();
        myRigidbody.velocity = new Vector3(10.0f, 0.0f, 15.0f);
    }

    IEnumerator endGame()
    {
        if(playerLeft >= 3) {
            countPlayerLeft.text = "Win!";
            countPlayerRight.text = "Lose...";
        }
        else if(playerRight >= 3) {
            countPlayerRight.text = "Win!";
            countPlayerLeft.text = "Lose...";
        }
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("start-up");        
    }
	
	// Update is called once per frame
	void Update () {
        /*
        if (transform.position.z < -5.5f)
        {


            //GameObject.Find("Main Camera").GetComponent<Score>().IncreaseScore(1);
            Start();
            transform.position = Vector3.zero;

        }
        if (transform.position.z > 5.5f)
        {

            //GameObject.Find("Main Camera").GetComponent<Score>().IncreaseScore(2);

            Start();
            transform.position = Vector3.zero;

        }
        */
    }

    void OnCollisionEnter(Collision collision)
    {
       
        if (collision.collider.tag == "RacketLeft")
        {
            Invert = Invert * -1;
            myRigidbody.velocity = new Vector3(10.0f * Invert, 0.0f, -15.0f * TowardsPlayer); 

        }
        else if (collision.collider.tag == "RacketRight")
        {
            TowardsPlayer = 1;
            myRigidbody.velocity = new Vector3(10.0f * Invert, 0.0f, 15.0f);
            // Debug.Log("touched right racket");
        }
        else if (collision.collider.tag == "WallLeft")
        {
            playerRight = playerRight + 0.5;
            setplayerRightScore();
            //Application.Quit();
            // Debug.Log("right player wins");
        }
        else if (collision.collider.tag == "WallRight")
        {
            playerLeft = playerLeft + 0.5;
            setplayerLeftScore();
            //Application.Quit();
            // Debug.Log("left player wins");
        }
        if(playerLeft < 3 && playerRight < 3) {
            return;
        }
        myRigidbody.velocity = new Vector3(0f, 0.0f, 0.0f);
        StartCoroutine(endGame());
    }

    void setplayerLeftScore(){
        if(playerLeft == 0) {
            countPlayerLeft.text = "O";
            return;
        }
        countPlayerLeft.text = playerLeft.ToString();
    }

    void setplayerRightScore(){
        if(playerRight == 0) {
            countPlayerRight.text = "O";
            return;
        }
        countPlayerRight.text = playerRight.ToString();
    }

}
