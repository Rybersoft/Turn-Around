using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameController : MonoBehaviour
{
    [SerializeField]Player player;
    // used to refer the next direction to turn into
    // 0-left 1 right
    int nextDirection = 1 ;
    double speed = 1.0f;
    Rigidbody playerRBody;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // detect if the player falls off the boundry
        if(player.isFalling())
            gameOver();
        if(Input.anyKeyDown){
            if(nextDirection == 1){
                player.turnRight();
            }else{
                player.turnLeft();
            }
        }
    }
    void gameOver(){
        // tobe implemented later
        Debug.Log("Game Over");
    }
}
