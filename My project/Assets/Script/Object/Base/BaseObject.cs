namespace Script.Object.Base
{
    public abstract class BaseObject
    {
        private float _price;
        private float _weight;
        private RareObject _rare;
        private float _volume; // TODO Будит ли нужен объём

        public BaseObject(float weight)
        {
            _price = Pricing();
            _weight = weight;
            _rare = Rare();
        }

        private float Pricing() // TODO Настроить цено образование. Default - 100
        {
            return 100f;
        }

        private RareObject Rare() // TODO Настроить генерацию редкости. Default - Rare  
        {
            return RareObject.Rare; 
        }
        

    }
}