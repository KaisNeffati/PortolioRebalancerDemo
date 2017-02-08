using System;
namespace WebApplication.Services
{
    public class NormalDestribution: INormalDestribution{
        public double _mi {get;set;}
        public double _di {get;set;}

        private Random rand =new Random();
        public double normalFunction(){
            double u1 = 1.0-rand.NextDouble(); //uniform(0,1] random doubles
            double u2 = 1.0-rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
            Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            double randNormal =_mi + _di * randStdNormal;
            if(randNormal<0){
                randNormal=0;
            }
            return randNormal;
        }
    }
}