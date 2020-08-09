using UnityEngine;
using System.Collections;

public class Automatic : Gun
{
    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            
            if(Time.time - timeOfLastShot >= 1 / fireRate) //if firerate is 10, this would be 0.10 and could shoot 10x in a sec
            {
                Fire();
                timeOfLastShot = Time.time;
            }
        }
    }
}
