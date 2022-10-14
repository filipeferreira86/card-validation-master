using CardValidation.Core.Services;

namespace CardValidation.test
{
    public class CardOwnerValidation
    {
        [Fact]
        public void ValidateOwnerData()
        {
            /**
             * Validate right data for name of the owner
             **/
            // ARRANGE
            var validator = new CardValidationService();
            string name = "Filipe F Jesus";

            // ACT
            bool nameAssertion = validator.ValidateOwner(name);

            //ASSERT
            Assert.True(nameAssertion, name+" should be valid please check the error");

        }

        [Fact]
        public void ValidateEmptyOwnerData()
        {
            /**
             * Validate error for the owner empty
             **/
            // ARRANGE
            var validator = new CardValidationService();
            string name = "";

            // ACT
            bool nameAssertion = validator.ValidateOwner(name);

            //ASSERT
            Assert.False(nameAssertion, "The owner is empty the result should be false");

        }

        [Fact]
        public void ValidateOwnerDataNumber()
        {
            /**
             * Validate error for owner with numbers instead of letters
             **/
            // ARRANGE
            var validator = new CardValidationService();
            string name = "1234";

            // ACT
            bool nameAssertion = validator.ValidateOwner(name);

            //ASSERT
            Assert.False(nameAssertion, "the owner name is " + name+ " and only contain numbers so the return should be false");

        }

        [Fact]
        public void ValidateOwnerDataFourWords()
        {
            /**
             * Validate right data for name of the owner
             **/
            // ARRANGE
            var validator = new CardValidationService();
            string name = "Filipe F de Jesus";

            // ACT
            bool nameAssertion = validator.ValidateOwner(name);

            //ASSERT
            Assert.False(nameAssertion, "the owner name is " + name + " and only contain numbers so the return should be false");

        }
    }
}
