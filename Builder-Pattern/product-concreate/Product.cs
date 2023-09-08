//This Product class is same for all type of builders

using Builder_Pattern.builder_interface;
using Builder_Pattern.enums;

namespace Builder_Pattern.product_concreate
{
    public class Product
    {
        public string Model { get; set; }
        public string OperatingSystem { get; set; }
        public Processor Processor { get; set; }
        public int Memory { get; set; }
        public Storage Storage { get; set; }
        public int ScreenSize { get; set; }
        public int ScreenResolution { get; set; }
        public int BatteryLife { get; set; }
    }
}