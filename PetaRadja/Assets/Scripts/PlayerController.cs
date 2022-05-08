using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    private enum State { None, Started, Lose, Win }

    public float moveSpeed = 0.25f;
    public float rotateSpeed = 2.1f;
    public Animator anim;
    public GameObject gameLosePrompt;
    public GameObject gameWinPrompt;

    private State state;

    public bool IsLose()
    {
        if (state == State.Lose)
            return true;
        return false;
    }

    public bool IsWin()
    {
        if (state == State.Win)
            return true;
        return false;
    }

    public void Lose ()
    {
        gameLosePrompt.SetActive(true);
        state = State.Lose;
        anim.SetBool("Die", true);
    }

    public void Win ()
    {
        state = State.Win;
        gameWinPrompt.SetActive(true);
        anim.SetBool("Win", true);
    }

    public void End ()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        state = State.Started;
        gameLosePrompt.SetActive(false);
        gameWinPrompt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (state == State.Lose || state == State.Win)
            return;
        float verticalMovement = Input.GetAxis("Vertical");
        float position = verticalMovement * moveSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;    
        transform.Translate(0, 0, position);
        transform.Rotate(0, rotation, 0);

        if ( verticalMovement != 0 )
            anim.SetBool("Walk", true);
        else
            anim.SetBool("Walk", false);
    }
}
