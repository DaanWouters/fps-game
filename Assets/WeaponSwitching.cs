using UnityEngine;

public class WeaponSwitching : MonoBehaviour 
{
    public int SelectedWeapon = 0;



    // Start is called before the first frame update
    void Start()
    {
        selectweapon();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (SelectedWeapon <= transform.childCount - 1)
            SelectedWeapon = 0;
            else
            SelectedWeapon++;
        }



    }

    void selectweapon()
    {
        int i = 0;
        foreach ( Transform weapon in transform)
        {
            if ( i == SelectedWeapon )
            
                weapon.gameObject.SetActive( true );
            
            else
                weapon.gameObject.SetActive( false );
            i++;
        }

    }


}
