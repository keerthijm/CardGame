namespace CardGame.Models
{
    public static class ErrorMessage
    {
        public static string NotRecognised = "Card not recognised";
        public static string Duplicated = "Cards cannot be duplicated";
        public static string TowJokers = "A hand cannot contain more than two Jokers";
        public static string InvalidInputString = "Invalid input string";
        public static string NoError = "No Error";
    }

    public static class ResultMessage
    {
        public static string YourScore = "Hear Is your score : ";
    }
}