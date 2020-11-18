using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField]GameObject game_over_menu;
    // used to refer the next direction to turn into
    // 0-left 1 right
    int nextDirection = 1;
    Rigidbody playerRBody;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // detect if the player falls off the boundry
        if (player.isFalling())
            gameOver();
        // move player on swiping
        movePlayerOnSwipe();
    }
    void gameOver()
    {
        Debug.Log("Game Over");
        game_over_menu.SetActive(true);
    }
    public void restart(){
        SceneManager.LoadScene("SampleScene");
    }

    void movePlayerOnSwipe()
    {
        Vector2 firstPressPos = new Vector2(0, 0);
        Vector2 secondPressPos;
        Vector2 currentSwipe;
        if (Input.touches.Length > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Began)
            {
                //save began touch 2d point
                firstPressPos = new Vector2(t.position.x, t.position.y);
            }
            if (t.phase == TouchPhase.Ended)
            {
                // player.turnRight();
                //save ended touch 2d point
                secondPressPos = new Vector2(t.position.x, t.position.y);

                //create vector from the two points
                currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);
                //swipe left
                if (currentSwipe.x < 0)
                {
                    player.turnLeft();
                }
                //swipe right
                if (currentSwipe.x > 0)
                {
                    player.turnRight();
                }
            }
        }
    }
}
