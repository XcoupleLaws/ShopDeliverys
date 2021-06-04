using System;
using Types;

namespace Domain.GoodsDomain
{
    public abstract class GoodsModel
    { 
	    public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
		
        public abstract GoodsType Type { get; }
        public abstract TimeSpan ProcessTime { get; }

        public override string ToString()
        {
            return Id + ") Name: " + Name + " | " +
                   " Price: " + Price + " | " +
                   " Type: " + Type;
        }
        
    }
}