using System.Globalization;


namespace InterfaceTestApplication.Entities
{
    class Invoice
    {
        //Creating variables:
        public double BasicPayment { get; set; }
        public double Tax { get; set; }


        public double TotalPayment
        {
            get
            {
                return BasicPayment + Tax;
            }
        }

        //Creating constructor:
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public override string ToString()
        {
            return $"Basic payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nTax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nTotal payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";

        }

    }
}
