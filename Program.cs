using System;
using TransactionalEntities;

namespace TransactionalEntityPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            Config.Init();
            Config.connectionString = "Data Source=LocalHost;Initial Catalog=Test;Integrated Security=True";


            var t = new MyType {Value1 = "test2", Id = Guid.NewGuid()};
            t.Commit();

        }
    }
   
    public class MyType : Entity
    {
        public string Value1 { get; set; }

    }
   
}
