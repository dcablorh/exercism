using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

class RemoteControlCar
{
    private int battery = 100;
    private int distance; 
    public static RemoteControlCar Buy()
    {

         return new RemoteControlCar();
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Buy() method");
         
       
    }

    public string DistanceDisplay()
{
    return $"Driven {distance} meters";
        throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDisplay() method");
    }

    public string BatteryDisplay()
    {
        if (battery > 0)
        {
            
            return $"Battery at {battery}%";
        }
        else
        {
            return "Battery empty";
        }
        
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
    }

    public void Drive()
    {
        if (battery > 0)
        {
            distance = distance + 20;
            battery = battery - 1;
        }
        
    }
}
