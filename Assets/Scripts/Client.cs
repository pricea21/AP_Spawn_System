using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    //public InputField iNumOfWheels;
    //public InputField iNumOfPassengers;
    //public string NumberOfWheels;
    public int  NumberOfWheels;
    public bool Engine;
    //public string Passengers;
    public int Passengers;
    public bool Cargo;

    // Start is called before the first frame update
    void Start()
    {
        NumberOfWheels = Mathf.Max(NumberOfWheels, 1);
        Passengers = Mathf.Max(Passengers, 1);
        //NumberOfWheels = iNumOfWheels.text;
        //Passengers = iNumOfPassengers.text;
        Engine = Cargo;

        VehicleRequirements requirements = new VehicleRequirements();
        requirements.NumberOfWheels = NumberOfWheels;
        requirements.Engine = Engine;
        requirements.Passengers = Passengers;

        IVehicle v = GetVehicle(requirements);
        Debug.Log(v);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private static IVehicle GetVehicle(VehicleRequirements requirements)
    {
        VehicleFactory factory = new VehicleFactory(requirements);
        return factory.Create();
    }

    public void AddEngine()
    {
        if (Engine) 
        { 
            Engine = false; 
        }
        else 
        { 
            Engine = true; 
        }
    }

    public void AddCargo()
    {
        if (Cargo) 
        { 
            Cargo = false; 
        }
        else 
        { 
            Cargo = true; 
        }
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
