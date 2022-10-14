using CardValidation.Core.Enums;
using CardValidation.Core.Services;

namespace CardValidation.test
{
    public class CardNumberValidation
    {
        readonly CardValidationService validator = new();

        [Fact]
        public void ValidateVisaCard()
        {
            /**
             * Validate right data for Visa
             **/
            // ARRANGE
            string cardNumber = "4000000000000";

            // ACT
            PaymentSystemType isVisa = validator.GetPaymentSystemType(cardNumber);


            //ASSERT
            Assert.Equal(PaymentSystemType.Visa, isVisa);
        }

        [Fact]
        public void ValidateMasterCard()
        {
            /**
            * Validate right data for Master
            **/
            // ARRANGE
            string cardNumber = "2221000000000000";

            // ACT
            PaymentSystemType isMaster = validator.GetPaymentSystemType(cardNumber);


            //ASSERT
            Assert.Equal(PaymentSystemType.MasterCard, isMaster);
        }

        [Fact]
        public void ValidateAmEx()
        {
            /**
            * Validate right data for Master
            **/
            // ARRANGE
            string cardNumber = "347000000000000";

            // ACT
            PaymentSystemType isAmEx = validator.GetPaymentSystemType(cardNumber);


            //ASSERT
            Assert.Equal(PaymentSystemType.AmericanExpress, isAmEx);
        }



        [Fact]
        public void ValidateValidCard()
        {
            /**
            * Validate empty data for the card field
            **/
            // ARRANGE
            string cardNumber = "4000000000000";

            // ACT
            bool isValidCard = validator.ValidateNumber(cardNumber);


            //ASSERT
            Assert.True(isValidCard);
        }



        [Fact]
        public void ValidateEmptyCard()
        {
            /**
            * Validate empty data for the card field
            **/
            // ARRANGE
            string cardNumber = "";

            // ACT
            bool isValidCard = validator.ValidateNumber(cardNumber);


            //ASSERT
            Assert.False(isValidCard);
        }

        [Fact]
        public void ValidateInvalidCard()
        {
            /**
            * Validate invalid data for the card field
            **/
            // ARRANGE
            string cardNumber = "138465498";

            // ACT
            bool isValidCard = validator.ValidateNumber(cardNumber);


            //ASSERT
            Assert.False(isValidCard);
        }
    }
}
