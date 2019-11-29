using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;


namespace Presentation
{
    public class Vehicle
    {
        private string brand;
        private bool door;
        private bool wheels;
        private int numberOfPassagers;
        private string propulsion;
        private bool thePresenceOfAnAlarm;
        private string brakingSystem;
        private string lighting;
        private int driverAge;
        private string typeOfControl;
        private int carryingCapacity;
        private bool trailer;
        private int maxDistance;
        private int maxSpeed;
        private string vehicleType;
        private int numberOfDoors;
        private int numberOfWheels;
        private int capacity;
        Fuel Fuel;

        public void read_Numder_Of_Passagers(int number)
        {
            numberOfPassagers = number;
        }

        public void read_thePresenceOfAnAlarm(bool a)
        {
            thePresenceOfAnAlarm = a;
        }

        public void choose_ligthing(string name_ligth)
        {
            lighting = name_ligth;
        }

        public void read_driverAge(int age)
        {
            driverAge = age;
        }

        public void read_door(bool b)
        {
            door = b;
        }

        public void read_wheels(bool c)
        {
            wheels = c;
        }

        public void read_propulsion(string forse)
        {
            propulsion = forse;
        }

        public void read_brakingSystem(string nameBrakingSystem)
        {
            brakingSystem = nameBrakingSystem;
        }

        public void read_carryingCapacity(int numbercarryingCapacity)
        {
            carryingCapacity = numbercarryingCapacity;
        }

        public void read_trailer(bool f)
        {
            trailer = f;
        }

        public void read_maxDistance(int distance)
        {
            maxDistance = distance;
        }

        public void read_maxSpeed(int speed)
        {
            maxSpeed = speed;
        }

        public void read_capacity(int cap)
        {
            capacity = cap;
        }
    }

    class avto : Vehicle
    {


    }

    class truck : Vehicle
    {


    }

    class loader : Vehicle
    {


    }

    class bus : Vehicle
    {


    }

    class trolleubus : Vehicle
    {


    }

    class tram : Vehicle
    {


    }

    class motocycle : Vehicle
    {


    }

    class horse_drawn_cart : Vehicle
    {


    }

    class bike : Vehicle
    {


    }

    class scooter : Vehicle
    {


    }

    class punzer : Vehicle
    {


    }
}
