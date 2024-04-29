namespace Training_notes
{
    public class Training
    {
        // Class Field
        int Field;

        // Class property
        public int Property
        {
            get
            {
                return Property;
            }
            set
            {
                Property = value;
            }
        }

        // Backing field
        private int _Value;
        public int Value
        {
            get
            {
                return _Value;
            }
            set 
            { 
                _Value = value; 
            }
        }

        // Shorter property
        public int ShortProperty { get; set; }

        // Property that acts like a readonly field
        // Value cant be changed outside the declaration and constructor
        public int PropertyLikeField { get; } = 12;

        public Training()
        {
            PropertyLikeField = 0;
        }

        void ChangeValue()
        {
            //PropertyLikeField = 0;
        }

        // property init, only set once on object construction
        public string Name { get; init; }
    }
}
