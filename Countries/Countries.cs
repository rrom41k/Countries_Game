using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries
{
    internal class Countries
    {
        string name;
        string flag;
        string capital;
        string language;
        string currency;
        int area;
        int population;
        
        public Countries(string name, string flag, string capital, string language, string currency, int area, int population) {
            this.name = name;
            this.flag = flag;
            this.capital = capital;
            this.language = language;
            this.currency = currency;
            this.area = area;
            this.population = population;
        }
    }
}