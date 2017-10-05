namespace Garden3
{
    public class Tree : Plant
    {
        public Tree(string color)
        {
            this.color = color;
            waterNeed = 10;
            waterAbsorb = 0.4;
            this.type = "tree";
        }
    }
}