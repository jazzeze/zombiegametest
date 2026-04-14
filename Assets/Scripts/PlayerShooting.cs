using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public Gun gun;

    void Update()
    {
        if(Input.GetMouseButton(0) && gun != null)
        {
            gun.Shoot();
        }
    }
}
