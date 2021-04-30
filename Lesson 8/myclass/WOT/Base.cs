using System;

namespace WOT
{

    public class Base
    {
        protected int _maneuverability;
        protected int _ammunition;
        protected int _armor;

        protected bool _live;


        protected Base()
        {
            Random rm = new();
            _ammunition = rm.Next(0, 100);
            _armor = rm.Next(0, 100);
            _maneuverability = rm.Next(0, 100);
            _live = true;
        }

        public static Base operator *(Base first, Base second)
        {
            int my_first = 0;
            int my_second = 0;

            if (first._live == false || second._live == false)
                throw new Exceptions.TankAlreadyDestroyed();

            if (first._ammunition > second._ammunition)
                my_first++;
            else if (first._ammunition < second._ammunition)
                my_second++;

            if (first._armor > second._armor)
                my_first++;
            else if (first._armor < second._armor)
                my_second++;

            if (first._maneuverability > second._maneuverability)
                my_first++;
            else if (first._maneuverability < second._maneuverability)
                my_second++;

            if (my_first > my_second)
            {
                second._live = false;
                return first;
            }
            else if (my_first < my_second)
            {
                first._live = false;
                return second;
            }

            return null;

        }
    }
}
