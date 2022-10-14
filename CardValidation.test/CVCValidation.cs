using CardValidation.Core.Services;

namespace CardValidation.test
{
    public class CVCValidation
    {
        readonly CardValidationService validator = new();

        [Fact]
        public void ValidateThreeNumberCVC()
        {
            /**
             * Validate CVC with 3 chars
             **/
            // ARRANGE
            string cvcNumber = "123";

            // ACT
            bool isValid = validator.ValidateCvc(cvcNumber);


            //ASSERT
            Assert.True(isValid);
        }

        [Fact]
        public void ValidateFourNumberCVC()
        {
            /**
             * Validate CVC with 4 chars
             **/
            // ARRANGE
            string cvcNumber = "1234";

            // ACT
            bool isValid = validator.ValidateCvc(cvcNumber);


            //ASSERT
            Assert.True(isValid);
        }


        [Fact]
        public void ValidateTwoNumberCVC()
        {
            /**
             * Validate error for CVC with 2 chars
             **/
            // ARRANGE
            string cvcNumber = "12";

            // ACT
            bool isValid = validator.ValidateCvc(cvcNumber);


            //ASSERT
            Assert.False(isValid);
        }


        [Fact]
        public void ValidateFiveNumberCVC()
        {
            /**
             * Validate error for CVC with 5 chars
             **/
            // ARRANGE
            string cvcNumber = "12345";

            // ACT
            bool isValid = validator.ValidateCvc(cvcNumber);


            //ASSERT
            Assert.False(isValid);
        }


        [Fact]
        public void ValidateEmptyCVC()
        {
            /**
             * Validate error for empty CVC
             **/
            // ARRANGE
            string cvcNumber = "";

            // ACT
            bool isValid = validator.ValidateCvc(cvcNumber);


            //ASSERT
            Assert.False(isValid);
        }
    }
}
