namespace Caveman
{
    public class Player
    {
        public int killed;
        public int death;

        private string name;
        private int id;

        public Player(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
