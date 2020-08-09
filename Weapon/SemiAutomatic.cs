using UnityEngine;

public class SemiAutomatic : Gun
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
//De semiautomatic werkt, maar blijft in de gamemode niet op de playercamera (weaponhandler) op eenzelfde positie hangen. 
//Deze kan schieten, damage dealen, maar zweeft wel op een compleet andere plek dan de bedoeling is. 