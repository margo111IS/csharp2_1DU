namespace Archery
{
    public class Archer
    {
        string _name;
        int _arrowCount;

        public Archer(string name, int arrowCount)
        {
            _name = name;
            _arrowCount = arrowCount;
        }

        public void Fire()
        {
            if (_arrowCount <= 0)
            {
                Console.WriteLine("No arrows available.");
                return;
            }
            _arrowCount--;
            Console.WriteLine("Arrow has been fired.");
        }

        public void AddArrows(int count)
        {
            if (count > 0)
            {
                _arrowCount += count;
                Console.WriteLine($"{count} arrows has been added.");
            }
        }

        public void ShowState()
        {
            Console.WriteLine($"\nSTATUS: {_name} has {_arrowCount} arrows.\n");
        }
    }
}