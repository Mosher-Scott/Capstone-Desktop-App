using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Classes
{
    public class Car
    {
        public string nickname;
        public string color;
        public string type;
        public string maker;
        public int yearMade;

        public Car(string carNickname, string carColor, string carType, string carMaker, int carYearMade)
        {
            nickname = carNickname;
            color = carColor;
            type = carType;
            maker = carMaker;
            yearMade = carYearMade;
        }

        public void MoveForward()
        {
            Console.WriteLine($"{nickname} moved forwards");
        } 
        
        public void Brake()
        {
            Console.WriteLine($"You stepped on the brake while driving {nickname}");
        }

        public void Crash()
        {
            Console.WriteLine($"You just crashed {nickname}");
        }

        public void CarSummary()
        {
            Console.WriteLine($"Your car is a {type}, and the color is {color}.  It was made by {maker} in {yearMade}. You called your car {nickname}");
        }

    }

}
