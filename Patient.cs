// See https://aka.ms/new-console-template for more information
using System;

namespace Program
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Weight { get; set; } // in KG
        public double Height { get; set; } // in Centimeters

        public Patient(string firstName, string lastName, double weight, double height)
        {
            FirstName = firstName;
            LastName = lastName;
            Weight = weight;
            Height = height;
        }

        public double CalculateBMI()
        {
            double heightInMeters = Height / 100;
            double bmi = Weight / (heightInMeters * heightInMeters);
            return bmi;
        }

        public string CalculateBloodPressure(int systolic, int diastolic)
        {
            if (systolic < 90 || diastolic < 60)
            {
                return "Low blood pressure (Hypotension). Please consult your doctor.";
            }
            else if (systolic >= 90 && systolic <= 120 && diastolic >= 60 && diastolic <= 80)
            {
                return "Normal blood pressure.";
            }
            else if (systolic >= 120 && systolic <= 129 && diastolic < 80)
            {
                return "Elevated blood pressure.";
            }
            else if (systolic >= 130 && systolic <= 139 || diastolic >= 80 && diastolic <= 89)
            {
                return "High blood pressure (Hypertension) Stage 1.";
            }
            else if (systolic >= 140 && systolic <= 180 || diastolic >= 90 && diastolic <= 120)
            {
                return "High blood pressure (Hypertension) Stage 2.";
            }
            else if (systolic > 180 || diastolic > 120)
            {
                return "Hypertensive crisis. Please consult your doctor immediately.";
            }
            else
            {
                return "Invalid blood pressure values.";
            }
        }

        public void PrintPatientInformation()
        {
            Console.WriteLine("Patient Information:");
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Height: {Height} cm");

            int systolic = 110;
            int diastolic = 75;
            string bloodPressureResult = CalculateBloodPressure(systolic, diastolic);
            Console.WriteLine($"Blood Pressure: {bloodPressureResult}");

            double bmi = CalculateBMI();
            Console.WriteLine($"BMI: {bmi}");

            string bmiStatus;
            if (bmi >= 25.0)
            {
                bmiStatus = "Overweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                bmiStatus = "Normal (In the healthy range)";
            }
            else
            {
                bmiStatus = "Underweight";
            }
            Console.WriteLine($"BMI Status: {bmiStatus}");
        }
    }
}
