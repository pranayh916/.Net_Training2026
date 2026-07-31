using System;

class Conveyor
{
    public void light()
    {
        int totalPackages = 20;
        int qualityCount = 0;
        int priorityCount = 0;
        int normalCount = 0;

        for (int packageId = 1001; packageId <= 1020; packageId++)
        {
            Console.Write("Package " + packageId + " : ");

            if (packageId % 4 == 0)
            {
                Console.WriteLine("Quality Check Required");
                qualityCount++;
            }
            else if (packageId % 5 == 0)
            {
                Console.WriteLine("Priority Shipment");
                priorityCount++;
            }
            else
            {
                Console.WriteLine("Normal Processing");
                normalCount++;
            }
        }

        Console.WriteLine("\nTotal Packages = " + totalPackages);
        Console.WriteLine("Quality Check = " + qualityCount);
        Console.WriteLine("Priority Shipment = " + priorityCount);
        Console.WriteLine("Normal Processing = " + normalCount);
    }
}