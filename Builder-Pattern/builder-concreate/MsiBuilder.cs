//This builder class is specific to MsiBuilder

using System.Text;
using Builder_Pattern.builder_interface;
using Builder_Pattern.enums;
using Builder_Pattern.product_concreate;

namespace Builder_Pattern.builder_concreate
{
    public class MsiBuilder : IBuilder
    {
        private Product _product;

        public void Reset()
        {
            _product = new Product();
        }

        public void setModel(string model)
        {
            _product.Model = model;
        }

        public void setOperatingSystem(string operatingSystem)
        {
            _product.OperatingSystem = operatingSystem;
        }

        public void setProcessor(Processor processor)
        {
            _product.Processor = processor;
        }

        public void setMemory(int memory)
        {
            _product.Memory = memory;
        }

        public void setStorage(Storage storage)
        {
            _product.Storage = storage;
        }

        public void setScreenSize(int screenSize)
        {
            _product.ScreenSize = screenSize;
        }

        public void setScreenResolution(int screenResolution)
        {
            _product.ScreenResolution = screenResolution;
        }

        public void setBatteryLife(int batteryLife)
        {
            _product.BatteryLife = batteryLife;
        }

        public StringBuilder showProduct()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Model: " + _product.Model + "\n");
            builder.Append("Operating System: " + _product.OperatingSystem + "\n");
            builder.Append("Processor: " + _product.Processor + "\n");
            builder.Append("Memory: " + _product.Memory + "\n");
            builder.Append("Storage: " + _product.Storage + "\n");
            builder.Append("Screen Size: " + _product.ScreenSize + "\n");
            builder.Append("Screen Resolution: " + _product.ScreenResolution + "\n");
            builder.Append("Battery Life: " + _product.BatteryLife + "\n");
            return builder;
        }

        public Product GetProduct()
        {
            var product = _product;
            Reset();
            return product;
        }
    }
}