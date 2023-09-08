//This Builder Interface includes same methods for all type of builders

using System.Text;
using Builder_Pattern.enums;
using Builder_Pattern.product_concreate;

namespace Builder_Pattern.builder_interface
{
    public interface IBuilder 
    {
        void Reset();
        void setModel(String model);
        void setOperatingSystem(String operatingSystem);
        void setProcessor(Processor processor);
        void setMemory(int memory);
        void setStorage(Storage storage);
        void setScreenSize(int screenSize);
        void setScreenResolution(int screenResolution);
        void setBatteryLife(int batteryLife);
        StringBuilder showProduct();
        Product GetProduct();
    }
}