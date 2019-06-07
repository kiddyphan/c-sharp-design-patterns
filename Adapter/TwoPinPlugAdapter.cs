using System;

namespace Adapter
{
    public class TwoPinPlugAdapter: ITwoPinPlug
    {
        private ThreePinPlug _plug;

        public TwoPinPlugAdapter(ThreePinPlug plug)
        {
            this._plug = plug;
        }

        public void GetPower()
        {
            this._plug.GetPowerViaThreePin();
        }
    }
}