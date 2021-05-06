
namespace Racers
{
    class Base : IRaceable
    {
        protected int _passedDistance;
        protected string _model;
        protected int _speed;


        protected Base(string model)
        {
            _model = model;
        }


        public int GetPassedDistnace() { return _passedDistance; }
        public string GetModel() { return _model; }
        public int GetSpeed() { return _speed; }


        public bool Race()
        {
            System.Random rm = new();
            
            _passedDistance += rm.Next(0,_speed);
            
            if(_passedDistance >= 100)
            {
                System.Console.WriteLine(_model + " WIN! Points : " + _passedDistance);
                return true;
            }

            return false;
        }
    }
}