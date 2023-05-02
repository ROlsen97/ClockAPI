using ClockAPI.Model;

namespace ClockAPI.Repo
{
    public class ClockReadsRepo
    {
        public List<ClockRead> _items;
        public ClockReadsRepo() 
        { 
            _items = new List<ClockRead>();
        }
        public List<ClockRead> GetAll()
        {
            return _items;
        }
        public void Create(ClockRead item)
        {
            _items.Add(item);
        }
    }
}
