using CardValidation.Core.Services;

namespace CardValidation.test
{
    public class DateValidation
    {
        readonly CardValidationService validator = new();

        [Fact]
        public void ValidateDateFourNumbersYear()
        {
            /**
             * Validate date with 4 digits year 
             **/
            // ARRANGE
            string date = "11/2022";

            // ACT
            bool isValid = validator.ValidateIssueDate(date);


            //ASSERT
            Assert.True(isValid);
        }

        [Fact]
        public void ValidateDateTwoNumbersYear()
        {
            /**
             * Validate date with 2 digits year 
             **/
            // ARRANGE
            string date = "11/22";

            // ACT
            bool isValid = validator.ValidateIssueDate(date);


            //ASSERT
            Assert.True(isValid);
        }

        [Fact]
        public void ValidateDateFiveNumbersYear()
        {
            /**
             * Validate error for date with 5 digits year 
             **/
            // ARRANGE
            string date = "11/20223";

            // ACT
            bool isValid = validator.ValidateIssueDate(date);


            //ASSERT
            Assert.False(isValid);
        }

        [Fact]
        public void ValidateDateOneNumberYear()
        {
            /**
             * Validate error for date with 1 digits year 
             **/
            // ARRANGE
            string date = "11/3";

            // ACT
            bool isValid = validator.ValidateIssueDate(date);


            //ASSERT
            Assert.False(isValid);
        }

        [Fact]
        public void ValidateExpiredCardDate()
        {
            /**
             * Validate error for expired card date
             **/
            // ARRANGE
            string date = "10/2022";

            // ACT
            bool isValid = validator.ValidateIssueDate(date);


            //ASSERT
            Assert.False(isValid);
        }

        [Fact]
        public void ValidateInvalidMonthLimitUp()
        {
            /**
             * Validate error for month bigger than 12
             **/
            // ARRANGE
            string date = "13/2022";

            // ACT
            bool isValid = validator.ValidateIssueDate(date);


            //ASSERT
            Assert.False(isValid);
        }

        [Fact]
        public void ValidateInvalidMonthLimitdown()
        {
            /**
             * Validate error for month smaller than 01
             **/
            // ARRANGE
            string date = "00/2022";

            // ACT
            bool isValid = validator.ValidateIssueDate(date);


            //ASSERT
            Assert.False(isValid);
        }

        [Fact]
        public void ValidateEmptyMonth()
        {
            /**
             * Validate error for empty month
             **/
            // ARRANGE
            string date = "/2022";

            // ACT
            bool isValid = validator.ValidateIssueDate(date);


            //ASSERT
            Assert.False(isValid);
        }

        [Fact]
        public void ValidateEmptyYear()
        {
            /**
             * Validate error for empty year
             **/
            // ARRANGE
            string date = "12/";

            // ACT
            bool isValid = validator.ValidateIssueDate(date);


            //ASSERT
            Assert.False(isValid);
        }

        [Fact]
        public void ValidateInvalidDateFormat()
        {
            /**
             * Validate error for date with invalid format yyyy/mm
             **/
            // ARRANGE
            string date = "2022/12";

            // ACT
            bool isValid = validator.ValidateIssueDate(date);


            //ASSERT
            Assert.False(isValid);
        }

        [Fact]
        public void ValidateEmptyDate()
        {
            /**
             * Validate error for empty date
             **/
            // ARRANGE
            string date = "";

            // ACT
            bool isValid = validator.ValidateIssueDate(date);


            //ASSERT
            Assert.False(isValid);
        }

        [Fact]
        public void ValidateInvalidDate()
        {
            /**
             * Validate error for date invalid
             **/
            // ARRANGE
            string date = "mm/yyyy";

            // ACT
            bool isValid = validator.ValidateIssueDate(date);


            //ASSERT
            Assert.False(isValid);
        }
    }
}
