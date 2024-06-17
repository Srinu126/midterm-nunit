using LaptopDiscount;

namespace LaptopDiscountTest;

public class Tests
{
    [Test]
    /*
        Test case for part time employee. As PartTime is one of the employee type and
        the discount should be zero for part time employee
        */
        public void CalculateDiscountedPrice_PartTimeEmployee_NoDiscount()
        {
            var employee = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartTime,
                Price = 1000
            };

            decimal discountedPrice = employee.CalculateDiscountedPrice();

            Assert.AreEqual(1000, discountedPrice);
        }
        [Test]
        /*
        Test case for partial load employee. Testing whether choosing a PartialLoad employee type
        will provide a 5 percent discount
        */
        public void CalculateDiscountedPrice_PartialLoadEmployee_FivePercentDiscount()
        {
            var employee = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartialLoad,
                Price = 2000
            };

            decimal discountedPrice = employee.CalculateDiscountedPrice();

            Assert.AreEqual(1880, discountedPrice);
        }
        [Test]
        /*
        Test case for Full-Time Employee . Testing whether choosing a Full Time employee type
         will provide a 10 percent discount
        */
        public void CalculateDiscountedPrice_FullTimeEmployee_TenPercentDiscount()
        {
            var employee = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                Price = 3000
            };

            decimal discountedPrice = employee.CalculateDiscountedPrice();

            Assert.AreEqual(2670, discountedPrice);
        }
        [Test]
        /*
        Test case for CompanyPurchasing. Testing whether choosing a CompanyPurchasing type
        will provide a 20 percent discount
        */
        public void CalculateDiscountedPrice_CompanyPurchasing_TwentyPercentDiscount()
        {
            var employee = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.CompanyPurchasing,
                Price = 5000
            };

            decimal discountedPrice = employee.CalculateDiscountedPrice();

            Assert.AreEqual(3950, discountedPrice);
        }
        [Test]
        /*
        Test case for Full-Time Employee with Zero Price. Testing whether choosing a Full Time employee type
        with Zero price will provide a valid return type
        */
        public void CalculateDiscountedPrice_FullTimeEmployee_InvalidPrice()
        {
            var employee = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.CompanyPurchasing,
                Price = 0
            };

            decimal discountedPrice = employee.CalculateDiscountedPrice();

            Assert.AreEqual(0, discountedPrice);
        }
        [Test]
        /*
        Test case for Full-Time Employee with Negative Price. Testing whether choosing a Full Time employee type
        with Negative price will provide a valid return type
        */
        public void CalculateDiscountedPrice_FullTimeEmployee_NegativePrice()
        {
            var employee = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.CompanyPurchasing,
                Price = -2000
            };

            decimal discountedPrice = employee.CalculateDiscountedPrice();

            Assert.AreEqual(0, discountedPrice);
        }


}