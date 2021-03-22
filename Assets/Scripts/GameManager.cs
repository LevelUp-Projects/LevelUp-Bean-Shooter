using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public InputField input;

    public List<Vehicle> vehicles;
    public PlayerController playerController;
    private void Start()
    {
        CreateCarList();
    }
    public void CreatePlayer(string name)
    {
        Player player = new Player();
        player.SetPlayerName(name);
        player.SetDamage(20);
        SpawnPlayer(player);
    }
    private void SpawnPlayer(Player player)
    {
        PlayerController instance = Instantiate(playerController);
        instance.Init(player);
    }
    private void CreateCarList()
    {

        vehicles = new List<Vehicle>{
            {new Car("Tesla", "S", 2016)},
            {new Car("Mazda","RX-7",1997)},
            {new Car("Ford","Focus",2005)},
            {new Motocycle(2009)}
        };
        foreach (Vehicle car in vehicles)
        {
            print(car.brand);
            car.Zatrub();
        }
    }
}
