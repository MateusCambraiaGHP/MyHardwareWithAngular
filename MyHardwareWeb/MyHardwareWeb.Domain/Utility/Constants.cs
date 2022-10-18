namespace MyHardware.Utility
{
    public class Constants
    {
        public class StatusActive
        {
            public const string Active   = "1";
            public const string Inactive = "0";
        }

        public class DefaultValue
        {
            public const int IdNullValue = 0;
            public const int IdMinValue = 1;
        }

        public class ComboboxItem
        {
            public string Value { get; set; }
            public string Text { get; set; }

            public ComboboxItem(string value, string text)
            {
                this.Value = value;
                this.Text = text;
            }
        }

        public class ProductType
        {
            public const string PersonalComputer = "1";
            public const string Microphone       = "2";
            public const string Screen           = "3";
            public const string Speaker          = "4";
            public const string Keyboard         = "5";
            public const string Mouse            = "6";

            public static string GetDescription(string productName)
            {
                switch (productName)
                {
                    case PersonalComputer: return "Computador";
                    case Microphone:       return "Microfone";
                    case Screen:           return "Monitor";
                    case Speaker:          return "Caixa de som";
                    case Keyboard:         return "Teclado";
                    case Mouse:            return "Mouse";
                    default: return "";
                }
            }

            public static List<ComboboxItem> GetComboboxList()
            {
                return new List<ComboboxItem>
                {
                    new ComboboxItem(PersonalComputer, GetDescription(PersonalComputer)),
                    new ComboboxItem(Microphone      , GetDescription(Microphone)),
                    new ComboboxItem(Screen          , GetDescription(Screen)),
                    new ComboboxItem(Speaker         , GetDescription(Speaker)),
                    new ComboboxItem(Keyboard        , GetDescription(Keyboard)),
                    new ComboboxItem(Mouse           , GetDescription(Mouse)),
                };
            }
        }
    }
}
