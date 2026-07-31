using System;

  class Street_Light
{

   public void show()
    {
        
        int totalPower = 0;
        int maintenanceCount = 0;
        int normalCount = 0;
        int efficientCount = 0;

        for (int lightNo = 1; lightNo <= 30; lightNo++)
        {
            int power = 80 + (lightNo * 5);

            Console.Write("Light " + lightNo + " : " + power + " W - ");

            if (power > 180)
            {
                Console.WriteLine("Maintenance Required");
                maintenanceCount++;
            }
            else if (power >= 140 && power <= 180)
            {
                Console.WriteLine("Normal Operation");
                normalCount++;
            }
            else
            {
                Console.WriteLine("Energy Efficient");
                efficientCount++;
            }

            totalPower += power;
        }

        double averagePower = (double)totalPower / 30;

        Console.WriteLine("\nTotal Power = " + totalPower + " W");
        Console.WriteLine("Average Power = " + averagePower + " W");
        Console.WriteLine("Maintenance = " + maintenanceCount);
        Console.WriteLine("Normal = " + normalCount);
        Console.WriteLine("Energy Efficient = " + efficientCount);
    }
    
}