using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpdChange3 : Token
{
    // Start is called before the first frame update
    void Update()
    {
        if(Bomb.gameover3 == 1){
           Enemy.dir = Random.Range(180, 269);
           SetVelocity(Enemy.dir, Enemy.spd);
           Bomb.gameover3 = 0;
        }
    }
}