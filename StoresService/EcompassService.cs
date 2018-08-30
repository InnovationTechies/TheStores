using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StoresService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.

    [DataContract]
    public class HelloWorldData
    {
        [DataMember]
        public bool SayHello { get; set; }

        [DataMember]
        public string Name { get; set; }

        public HelloWorldData()
        {
            Name = "Hello ";
            SayHello = false;
        }
    }

    public class HelloWorldService : IHelloWorldService
    {
        public HelloWorldData GetHelloData(HelloWorldData helloWorldData)
        {
            if (helloWorldData == null)
                throw new ArgumentException("helloWorldData");

            if (helloWorldData.SayHello)
                helloWorldData.Name = "Hello World to {helloWorldData.Name}";

            return helloWorldData;
        }

        public string SayHelloTo(string name)
        {
            return "Hello World to you, {name}";
        }
    }


    public class EcompassService : IEcompassService
    {
        EcompassContext ecompassContext = new EcompassContext();
      


        public List<PnpProducts> GetProductsData()
        {
            return ecompassContext.Products.ToList();
        }

        //public string SayHelloTo()
        //{
        //    return "Hello World to you, Ecompass";
        //}

    }
}
