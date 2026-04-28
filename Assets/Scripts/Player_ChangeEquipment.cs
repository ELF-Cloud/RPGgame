using UnityEngine;

public class Player_ChangeEquipment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public Player_Combat combat;
    public Player_Bow bow;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("ChangeEquipment"))
        {
            bow.enabled = !bow.enabled;
        }
    }
}
