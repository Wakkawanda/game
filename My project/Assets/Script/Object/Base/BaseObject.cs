namespace Script.Object.Base
{
    public abstract class BaseObject
    {
        private float _price;
        private float _weight;
        private ERareObject _eRare;
        private float _volume; // TODO Будит ли нужен объём

        public BaseObject(float weight)
        {
            _price = Pricing();
            _eRare = Rare();
            _weight = weight;
        }

        private float Pricing() // TODO Настроить цено образование. Default - 100
        {
            return 100f;
        }

        private ERareObject Rare() // TODO Настроить генерацию редкости. Default - Rare  
        {
            return ERareObject.Rare; 
        }
        

    }
}