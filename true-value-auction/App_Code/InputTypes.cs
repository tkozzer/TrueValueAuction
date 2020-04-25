namespace truevalueauction.App_Code
{
    public enum InputTypes
    {
        Email,
        Password,
        ConfirmPassword,
        FirstName,
        LastName,
        FullAddress
    }

    static class InputTypeValue
    {
        /*
         * This pattern requires at least two lowercase letters,
         * two uppercase letters, two digits, and two special characters.
         * There must be a minimum of 9 characters and maximum of 20 total,
         * and no white space characters are allowed.
         */
        private static readonly string passwordValue = @"^(?=.*[a-z].*[a-z])(?=.*[A-Z].*[A-Z])(?=.*\d.*\d)(?=.*\W.*\W)[a-zA-Z0-9\S]{9,20}$";

        /*
         * Regex for first and last names. Checks for all letter characters plus a series of other
         * special characters including [.,'-]. Examples: Mathias d'Arras, Martin Luther King, Jr., plus any
         * hypeneated last name.
         *
         */
        private static readonly string nameValue = @"^[a-zA-Z,.'-]+$";

        public static string Value(this InputTypes inputType)
        {
            switch(inputType)
            {
                case InputTypes.FirstName:
                case InputTypes.LastName: return nameValue;
                case InputTypes.Password: return passwordValue;
                default: return "";
            }
            
        }
    }
}
