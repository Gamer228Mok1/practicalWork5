using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalWork5.BuilderBurger
{
    public class BurgerDirector
    {
        private readonly IBurgerBuilder _builder;

        public BurgerDirector(IBurgerBuilder builder)
        {
            _builder = builder;
        }

        public void BuildDefault()
        {
            _builder
                .AddCheese()
                .AddTomato().
                AddPickles();
        }

        public void BuildWithBeacon()
        {
            _builder
                .AddTomato()
                .AddBacon()
                .AddLetuce();
        }
        public partial class Burgers
        {
            public int ID { get; set; }

            public bool? Cheese { get; set; }
            public bool? Bacon { get; set; }
            public bool? Letuce { get; set; }
            public bool? Tomato { get; set; }
            public bool? Pickles { get; set; }

            public Burgers()
            {
                Cheese = false;
                Bacon = false;
                Letuce = false;
                Tomato = false;
                Pickles = false;
            }
        }
    }


}
