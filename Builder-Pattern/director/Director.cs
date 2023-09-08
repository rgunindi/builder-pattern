//This Director class is orchestrating the building process of the product

using Builder_Pattern.builder_interface;
using Builder_Pattern.product_concreate;
using Builder_Pattern.enums;
namespace Builder_Pattern.director
{
    public class Director
    {
        public void BuildMsiHome(IBuilder builder)
        {
            builder.Reset();
            builder.setModel("Msi Home");
            builder.setOperatingSystem("Windows 10");
            builder.setProcessor(Processor.IntelCoreI7);
            builder.setMemory(16);
            builder.setStorage(Storage.SSD);
            builder.setScreenSize(15);
            builder.setScreenResolution(1920);
            builder.setBatteryLife(6);
        }

        public void BuildMacbookAir(IBuilder builder)
        {
            builder.Reset();
            builder.setModel("Macbook Air");
            builder.setOperatingSystem("MacOS");
            builder.setProcessor(Processor.M1);
            builder.setMemory(8);
            builder.setStorage(Storage.SSD);
            builder.setScreenSize(13);
            builder.setScreenResolution(2560);
            builder.setBatteryLife(10);
        }

        public void BuildMsiGaming(IBuilder builder)
        {
            builder.Reset();
            builder.setModel("Msi Gaming");
            builder.setOperatingSystem("Windows 10");
            builder.setProcessor(Processor.IntelCoreI9);
            builder.setMemory(32);
            builder.setStorage(Storage.SSD);
            builder.setScreenSize(17);
            builder.setScreenResolution(1920);
            builder.setBatteryLife(4);
        }

        public void BuildMacbookPro(IBuilder builder)
        {
            builder.Reset();
            builder.setModel("Macbook Pro");
            builder.setOperatingSystem("MacOS");
            builder.setProcessor(Processor.M2);
            builder.setMemory(32);
            builder.setStorage(Storage.SSD);
            builder.setScreenSize(16);
            builder.setScreenResolution(3072);
            builder.setBatteryLife(11);
        }
        public void BuildMacPro(IBuilder builder)
        {
            builder.Reset();
            builder.setModel("Mac Pro");
            builder.setOperatingSystem("MacOS");
            builder.setProcessor(Processor.IntelXeonW);
            builder.setMemory(64);
            builder.setStorage(Storage.SSD);
            builder.setScreenSize(0);
            builder.setScreenResolution(0);
            builder.setBatteryLife(0);
        }
    }
}