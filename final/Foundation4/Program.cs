using System;
using System.Collections.Generic;
    class Program
    {
// This checks if the activity at the gym is a running activity, a cycling activity, or a swimming activity.
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();
            activities.Add(new RunningActivity(new DateTime(2023, 30, 3), 30, 3.0));
            activities.Add(new CyclingActivity(new DateTime(2022, 30, 3), 30, 12.0));
            activities.Add(new SwimmingActivity(new DateTime(2022, 30, 3), 30, 30));

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

            Console.ReadKey();
        }
    }

   

    

