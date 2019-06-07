namespace Decorator
{
    public class Room : IService
    {
        const int ROOM_COST = 10;

        public int getCost()
        {
            return ROOM_COST;
        }

        public string getDescription()
        {
            return "Booking Room";
        }
    }
}