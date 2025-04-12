using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Bullets : MonoBehaviour
{
    
    //Tutorial is from https://www.youtube.com/watch?v=wZ2UUOC17AY
    //bullet
    public GameObject bullet;

    //bullet Force
    public float shootForce, upwardForce;
    
    //Gun Stats
    public float timeBetweenShooting, spread, reloadTime, timeBetweenShots;
    public int magazineSize, bulletsPerTap;
    public bool allowButtonHold;
    private int bulletsleft, bulletsShot;
    
    //bools
    bool shooting, readyToShoot, reloading;
    
    //bug fixing
    public bool allowInvoke = true;

    private void Awake()
    {
        //make sure mag is full
        bulletsleft = magazineSize;
        readyToShoot = true;
        
    }

    private void Update()
    {
        MyInput();
    }

    private void MyInput()
    {
        //check if allowed to hold down button
        if (allowButtonHold) shooting = Input.GetKey(KeyCode.Mouse0);
        else shooting = Input.GetKey(KeyCode.Mouse0);
        
        //shooting
        if (readyToShoot && shooting && !reloading && bulletsleft > 0)
        {
            //set bullets shot to 0
            bulletsShot = 0;
            Shoot();
        }
    }

    private void Shoot()
    {
        readyToShoot = false;
        
        //Find the exact hit position using raycast
        bulletsleft--;
        bulletsShot++;
    }
}
