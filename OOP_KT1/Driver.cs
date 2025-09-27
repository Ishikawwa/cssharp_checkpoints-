using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KT1
{
    internal class Driver
    {
        public double AverageCarSpeed;
        public double CarCoordinates = 0;
        public double CarCondition = 100;


        private readonly double _cityN1StartPosition = 1010;
        private readonly double _cityN1EndPosition = 1020;

        private readonly double _cityN2StartPosition = 3565;
        private readonly double _cityN2EndPosition = 3580;

        private readonly double _cityN3StartPosition = -2530;
        private readonly double _cityN3EndPosition = -2500;



        public Driver(double averageCarSpeed, double carCoordinates)
        {
            AverageCarSpeed = averageCarSpeed;
            CarCoordinates = carCoordinates;
            CarCondition = 100;
        }

        public double Drive(double time)
        {

            if (CarCondition <= 0)
            {
                Console.WriteLine("Error! Critical car condition! You can't drive this vehicle anymore!");
                return 0;
            }


            double Distance = AverageCarSpeed * time;
            CarCoordinates += Distance;


            if (Distance >= 100)
            {
                int fullHundreds = (int)(Distance / 100);
                CarCondition -= fullHundreds * 0.01;
            }


            return Distance;
        }
        public double DriveBack(double time)
        {
            if (CarCondition <= 0)
            {
                Console.WriteLine("Error! Critical car condition! You can't drive this vehicle anymore!");
                return 0;
            }


            double Distance = AverageCarSpeed * time;
            CarCoordinates -= Distance;


            if (Distance >= 100)
            {
                int fullHundreds = (int)(Distance / 100);
                CarCondition -= fullHundreds * 0.01;
            }


            return Distance;
        }

        public void PrintLocation()
        {
            if (CarCoordinates >= _cityN1StartPosition && CarCoordinates <= _cityN1EndPosition)
            {
                Console.WriteLine("The car is in city N1");
            }
            else if (CarCoordinates >= _cityN2StartPosition && CarCoordinates <= _cityN2EndPosition)
            {
                Console.WriteLine("The car is somewhere in city N2");
            }
            else if (CarCoordinates >= _cityN3StartPosition && CarCoordinates <= _cityN3EndPosition)
            {
                Console.WriteLine("The car is somewhere in city N3");
            }
            else
            {
                Console.WriteLine("The car is somewhere in highway");
            }
        }

        public void PrintCarTechnicalState()
        {
            Console.WriteLine(CarCondition); 
        }
    }
}
