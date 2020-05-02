namespace IMMRequest.Exceptions
{
    public class LogicExceptions
    {
        public const string NOT_IMPLEMENTED = "Method not implemented.";
        public const string GENERIC_INVALID_ID = "No items with the indicated id were found.";
        public const string GENERIC_NO_ELEMENTS = "No items found.";
        public const string INVALID_ID_AREA = "The id of the indicated area is incorrect.";
        public const string INVALID_ID_TOPIC = "The id of the indicated topic is incorrect.";
        public const string INVALID_ID_TYPE = "The id of the indicated type is incorrect.";
        public const string INVALID_ID_ADMINISTRATOR = "The id of the indicated administrator is incorrect.";
        public const string INVALID_ID_ADDITIONAL_FIELD = "The id of the indicated additional field is incorrect.";
        public const string INVALID_ID_REQUEST = "The id of the indicated request is incorrect.";
        public const string INVALID_EMAIL_FORMAT = "the format of the given email is incorrect, it must be of the format (example@example.eg).";
        public const string INNVALID_EMAIL_IN_USE = "The email given is already registered in the system.";
        public const string INVALID_CREDENTIALS = "The credentials provided are invalid.";
        public const string INVALID_PHONE_FORMAT = "The format of the given phone is invalid.";
        public const string INVALID_ADDITIONAL_FIELD = "The additional fields given are invalid, one or more of them does not belong to the indicated type.";
        public const string INVALID_LENGTH = "One of the fields was not entered.";
        public const string WRONG_DATE_FORMAT = "The given date format is invalid, must be 'MM/dd/yyyy'.";
        public const string WRONG_INTEGER_FORMAT = "The given integer is invalid.";
        public const string ALREADY_EXISTS_ADDITIONAL_FIELD = "There is already an additional field with the same name within the indicated type.";
        public const string ALREADY_EXISTS_TYPE = "There is already a type with the same name within the indicated topic.";
        public const string ALREADY_EXISTS_AREA = "There is already an area with the given name.";
        public const string ALREADY_EXISTS_TOPIC = "There is already a topic with the same name within the indicated area.";
        public const string RANGE_NOT_LISTED = "The additional field does not correspond to the given specifications.";
        public static string INVALID_TYPE_NOT_EXIST = "Type not found";
        public static string INVALID_ADDITIONAL_FIELD_REQUEST_ID = "The request id of the additional field does not map to the request id itself";
        public static string INVALID_ADDITIONAL_FIELD_RANGES = "The indicated type does not have the additional field";
    }
}