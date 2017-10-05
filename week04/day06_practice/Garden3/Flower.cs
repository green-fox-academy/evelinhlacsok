namespace Garden3
{
    public class Flower : Plant
    {
        public Flower(string color)
        {
            this.color = color;
            waterNeed = 5;
            waterAbsorb = 0.75;
            this.type = "flower";
        } 
    }
}