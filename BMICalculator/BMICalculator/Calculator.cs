using System;
using UIKit;

namespace BMICalculator
{
    public class Calculator
    {
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string Message { get; set; }
        public decimal BMIScore { get; set; }

        public Calculator() { }

        public string GetBMIScore()
        {
            Height = ((AppDelegate)(UIApplication.SharedApplication.Delegate)).height;
            Weight = ((AppDelegate)(UIApplication.SharedApplication.Delegate)).weight;


            if (Weight > 0)
            {
                BMIScore = (Weight / (Height * Height)) * 703;
                BMIScore = decimal.Round(BMIScore, 2);
                Message = "Your BMI Score is " + BMIScore.ToString();
            }
            else
                Message = "You must enter your height and weight";

            return Message;
        }
        public string GetExtraMessage()
        {
            if (BMIScore <= 17)
                Message = "SEVERLY UNDERWEIGHT";
            else if (BMIScore >= 18 && BMIScore <=19)
                Message = "UNDERWEIGHT";
            else if (BMIScore > 19 && BMIScore <= 25)
                Message = "OPTIMAL";
            else if (BMIScore > 25 && BMIScore <= 30)
                Message = "OVERWEIGHT";
            else if (BMIScore > 30 && BMIScore <= 40)
                Message = "OBESE";
            else
                Message = "SEVERLY OBESE";
            return Message;
        }
    }
}
