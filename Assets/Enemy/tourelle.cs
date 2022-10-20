using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tourelle : Vaticanais
{
    float cooldown;
    public override void follow()
    {
        if(cooldown > 0)
        {
            base.follow();

        }
    }
    private void Update()
    {
        cooldown += Time.deltaTime;
        if(cooldown > 2)
        {
            cooldown = -1;
        }
        follow();
    }
}
