using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpdChange2 : Token
{
    void Update()
    {
        if(Bomb.gameover2 == 1){
           Enemy.dir = Random.Range(90, 179);
           SetVelocity(Enemy.dir, Enemy.spd);
           Bomb.gameover2 = 0;
        }
    }
}
