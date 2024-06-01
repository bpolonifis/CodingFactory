using InterfaceApp.Interfaces;


namespace InterfaceApp.Types
{
    internal class Point : AbstractPoint, IMoveable
    {
        public override string? ToString()
        {
            return $"x={X}";
        }
    }
}
