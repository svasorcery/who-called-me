namespace WhoCalledMe.Entities
{
    public class DefCode
    {
        public int Prefix { get; set; }

        public int Min { get; set; }
        public int Max { get; set; }

        public int OperatorId { get; set; }
        public Operator Operator { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }
    }
}
