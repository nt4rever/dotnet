namespace NetFundamental.OOP
{
    internal class SingleTon
    {
        private static SingleTon? instance;
        public static SingleTon Instance
        {
            get
            {
                instance ??= new SingleTon();
                return instance;
            }
        }
        private SingleTon() { }

        public int Id { get; set; }
    }
}
