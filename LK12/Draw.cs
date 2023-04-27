namespace LK12
{
    abstract class Draw
    {
        public abstract void PlantInfo();
        
    }
    class DrawM:Draw
    {
        public override void PlantInfo()
        {
            Console.WriteLine("-----------------------------------------");
        }
    }
}
