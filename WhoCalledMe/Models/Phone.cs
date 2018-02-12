namespace WhoCalledMe.Models
{
    public class Phone
    {
        public string CountryCode { get; set; }
        public string Prefix { get; set; }
        public string Number { get; set; }

        public string FullNumber => $"+{CountryCode}({Prefix}){Number}";
    }
}
