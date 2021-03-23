using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text playerStatsText;
    public Rigidbody bullet;
    public Transform bulletSpawn;
    private Camera cam;
    private Player data;

    private CharacterController controller;


    private void Start()
    {
        controller = GetComponent<CharacterController>();
        cam = Camera.main;
        cam.transform.parent = transform;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        MovePlayer();
        RotatePlayer();
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    private void MovePlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * vertical + transform.right * horizontal;
        controller.Move(data.movementSpeed * Time.deltaTime * movement);
    }
    private void RotatePlayer()
    {
        float horizontal = Input.GetAxis("Mouse X");
        float vertical = Input.GetAxis("Mouse Y");
        transform.Rotate(0, horizontal * data.mouseSensitivity, 0);
        cam.transform.Rotate(-vertical * data.mouseSensitivity, 0, 0);
        Vector3 rot = cam.transform.localEulerAngles;
        if (rot.x > 180)
        {
            rot.x -= 360;
        }
        rot.x = Mathf.Clamp(rot.x, 20, 50);
        cam.transform.localRotation = Quaternion.Euler(rot);
    }
    private void Shoot()
    {
        var instance = Instantiate(bullet, bulletSpawn.position, Quaternion.identity, bulletSpawn);
        instance.AddForce(transform.forward * 100, ForceMode.Impulse);
    }
    public void Init(Player data)
    {
        this.data = data;
        ShowStats();
    }
    private void ShowStats()
    {
        playerStatsText.text = $"NAME: {data.GetPlayerName()} \n DMG: {data.GetDamage()}";
    }
}
