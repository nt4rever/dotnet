namespace NetFundamental.OOP
{
    internal class LoginRequest : FormRequest
    {
        public LoginRequest(string message)
        {
            this.message = message;
        }

        public override void Rules()
        {
            base.Rules();
            Console.WriteLine("This is rules in Login Request class");
            Console.WriteLine($"UserId: {SingleTon.Instance.Id}");
            var obj = new
            {
                fullName = "Jonh",
                age = 16
            };
            Console.WriteLine(obj.fullName);
        }
    }
}
