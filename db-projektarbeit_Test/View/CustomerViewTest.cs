using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using db_projektarbeit.View;

namespace db_projektarbeit_Test.View
{
    public class CustomerViewTest
    {

        [Fact]
        public void ValidateEmail_ValidInput_RegexReturnsTrue()
        {
            var customerView = new CustomerView();

            string input = "max.mustermann@t.ch";

            Assert.True(customerView.ValidateEmail(input));
        }


        [Fact]
        public void ValidateEmail_ValidInput_RegexReturnsTrue1()
        {
            var customerView = new CustomerView();

            string input = "m.m@t.ch";

            Assert.True(customerView.ValidateEmail(input));
        }

        [Fact]
        public void ValidateEmail_ValidInput_RegexReturnsTrue2()
        {
            var customerView = new CustomerView();

            string input = "m_@t.ch";

            Assert.True(customerView.ValidateEmail(input));
        }

        [Fact]
        public void ValidateEmail_ValidInput_RegexReturnsTrue3()
        {
            var customerView = new CustomerView();

            string input = "m_1993@t.ch";

            Assert.True(customerView.ValidateEmail(input));
        }

        [Fact]
        public void ValidateEmail_ValidInput_RegexReturnsTrue4()
        {
            var customerView = new CustomerView();

            string input = "1993@t.eu";

            Assert.True(customerView.ValidateEmail(input));
        }

        [Fact]
        public void ValidateEmail_ValidInput_RegexReturnsTrue5()
        {
            var customerView = new CustomerView();

            string input = "eric_testluechingertest@t.at";

            Assert.True(customerView.ValidateEmail(input));
        }

        [Fact]
        public void ValidateEmail_ValidInput_RegexReturnsTrue6()
        {
            var customerView = new CustomerView();

            string input = "12@1.com";

            Assert.True(customerView.ValidateEmail(input));
        }

        [Fact]
        public void ValidateEmail_ValidInput_RegexReturnsTrue7()
        {
            var customerView = new CustomerView();

            string input = "elias.bachmann.sfs@sfs-online.ch";

            Assert.True(customerView.ValidateEmail(input));
        }

        [Fact]
        public void ValidateEmail_InvalidInput_RegexReturnsFalse()
        {
            var customerView = new CustomerView();

            string input = "eric.luechinger";

            Assert.False(customerView.ValidateEmail(input));
        }

        [Fact]
        public void ValidateEmail_InvalidInput_RegexReturnsFalse1()
        {
            var customerView = new CustomerView();

            string input = "eric";

            Assert.False(customerView.ValidateEmail(input));
        }

        [Fact]
        public void ValidateEmail_InvalidInput_RegexReturnsFalse2()
        {
            var customerView = new CustomerView();

            string input = "eric@abacus";

            Assert.False(customerView.ValidateEmail(input));
        }

        [Fact]
        public void ValidateEmail_InvalidInput_RegexReturnsFalse3()
        {
            var customerView = new CustomerView();

            string input = "max@sfs.";

            Assert.False(customerView.ValidateEmail(input));
        }

        [Fact]
        public void ValidateEmail_InvalidInput_RegexReturnsFalse4()
        {
            var customerView = new CustomerView();

            string input = "?@.com";

            Assert.False(customerView.ValidateEmail(input));
        }

        [Fact]
        public void ValidateEmail_InvalidInput_RegexReturnsFalse5()
        {
            var customerView = new CustomerView();

            string input = "@";

            Assert.False(customerView.ValidateEmail(input));
        }

        [Fact]
        public void ValidateEmail_InvalidInput_RegexReturnsFalse6()
        {
            var customerView = new CustomerView();

            string input = "";

            Assert.False(customerView.ValidateEmail(input));
        }

        [Fact]
        public void ValidateEmail_InvalidInput_RegexReturnsFalse7()
        {
            var customerView = new CustomerView();

            string input = " ";

            Assert.False(customerView.ValidateEmail(input));
        }

        [Fact]
        public void ValidateWebsite_ValidInput_RegexReturnsTrue()
        {
            var customerView = new CustomerView();

            string input = "www.google.com";

            Assert.True(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidateWebsite_ValidInput_RegexReturnsTrue1()
        {
            var customerView = new CustomerView();

            string input = "http://www.google.com";

            Assert.True(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidateWebsite_ValidInput_RegexReturnsTrue2()
        {
            var customerView = new CustomerView();

            string input = "https://www.google.com";

            Assert.True(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidateWebsite_ValidInput_RegexReturnsTrue3()
        {
            var customerView = new CustomerView();

            string input = "google.com";

            Assert.True(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidateWebsite_ValidInput_RegexReturnsTrue4()
        {
            var customerView = new CustomerView();

            string input = "https://policies.google.com";

            Assert.True(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidateWebsite_ValidInput_RegexReturnsTrue5()
        {
            var customerView = new CustomerView();

            string input = "https://policies.google.com/technologies/voice?hl=de&gl=ch";

            Assert.True(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidateWebsite_ValidInput_RegexReturnsTrue6()
        {
            var customerView = new CustomerView();

            string input = "request.google.c";

            Assert.True(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidateWebsite_ValidInput_RegexReturnsTrue7()
        {
            var customerView = new CustomerView();

            string input = "bundesrat.schweiz";

            Assert.True(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidateWebsite_ValidInput_RegexReturnsTrue8()
        {
            var customerView = new CustomerView();

            string input = "abacus.eu";

            Assert.True(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidateWebsite_ValidInput_RegexReturnsTrue9()
        {
            var customerView = new CustomerView();

            string input = "https://stackoverflow.com/questions/5717312/regular-expression-for-url";

            Assert.True(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidateWebsite_ValidInput_RegexReturnsTrue10()
        {
            var customerView = new CustomerView();

            string input = "example.com/file[/].html";

            Assert.True(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidateWebsite_ValidInput_RegexReturnsTrue11()
        {
            var customerView = new CustomerView();

            string input = "siemens.com/op";

            Assert.True(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidateWebsite_InvalidInput_RegexReturnsFalse()
        {
            var customerView = new CustomerView();

            string input = "http://www.example.com/grave`accent";

            Assert.False(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidateWebsite_InvalidInput_RegexReturnsFalse1()
        {
            var customerView = new CustomerView();

            string input = "";

            Assert.False(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidateWebsite_InvalidInput_RegexReturnsFalse2()
        {
            var customerView = new CustomerView();

            string input = " ";

            Assert.False(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidateWebsite_InvalidInput_RegexReturnsFalse3()
        {
            var customerView = new CustomerView();

            string input = "amazon3*.ch";

            Assert.False(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidateWebsite_InvalidInput_RegexReturnsFalse4()
        {
            var customerView = new CustomerView();

            string input = "amazon";

            Assert.False(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidateWebsite_InvalidInput_RegexReturnsFalse5()
        {
            var customerView = new CustomerView();

            string input = "amazon.1";

            Assert.False(customerView.ValidateWebsite(input));
        }

        [Fact]
        public void ValidatePassword_ValidInput_RegexReturnsTrue()
        {
            var customerView = new CustomerView();

            string input = "Testtes1";

            Assert.True(customerView.ValidatePassword(input));
        }

        [Fact]
        public void ValidatePassword_ValidInput_RegexReturnsTrue1()
        {
            var customerView = new CustomerView();

            string input = "-----3aA";

            Assert.True(customerView.ValidatePassword(input));
        }

        [Fact]
        public void ValidatePassword_ValidInput_RegexReturnsTrue2()
        {
            var customerView = new CustomerView();

            string input = "ABCDEFGH1a";

            Assert.True(customerView.ValidatePassword(input));
        }

        [Fact]
        public void ValidatePassword_ValidInput_RegexReturnsTrue3()
        {
            var customerView = new CustomerView();

            string input = "abcdefgH1";

            Assert.True(customerView.ValidatePassword(input));
        }

        [Fact]
        public void ValidatePassword_ValidInput_RegexReturnsTrue4()
        {
            var customerView = new CustomerView();

            string input = "TESTtest1";

            Assert.True(customerView.ValidatePassword(input));
        }

        [Fact]
        public void ValidatePassword_InvalidInput_RegexReturnsFalse()
        {
            var customerView = new CustomerView();

            string input = "A";

            Assert.False(customerView.ValidatePassword(input));
        }

        [Fact]
        public void ValidatePassword_InvalidInput_RegexReturnsFalse1()
        {
            var customerView = new CustomerView();

            string input = "AB";

            Assert.False(customerView.ValidatePassword(input));
        }

        [Fact]
        public void ValidatePassword_InvalidInput_RegexReturnsFalse2()
        {
            var customerView = new CustomerView();

            string input = "ABC";

            Assert.False(customerView.ValidatePassword(input));
        }

        [Fact]
        public void ValidatePassword_InvalidInput_RegexReturnsFalse3()
        {
            var customerView = new CustomerView();

            string input = "ABCD";

            Assert.False(customerView.ValidatePassword(input));
        }

        [Fact]
        public void ValidatePassword_InvalidInput_RegexReturnsFalse4()
        {
            var customerView = new CustomerView();

            string input = "ABCDE";

            Assert.False(customerView.ValidatePassword(input));
        }

        [Fact]
        public void ValidatePassword_InvalidInput_RegexReturnsFalse5()
        {
            var customerView = new CustomerView();

            string input = "ABCDEF";

            Assert.False(customerView.ValidatePassword(input));
        }

        [Fact]
        public void ValidatePassword_InvalidInput_RegexReturnsFalse6()
        {
            var customerView = new CustomerView();

            string input = "ABCDEFG";

            Assert.False(customerView.ValidatePassword(input));
        }

        [Fact]
        public void ValidatePassword_InvalidInput_RegexReturnsFalse7()
        {
            var customerView = new CustomerView();

            string input = "ABCDEFGH";

            Assert.False(customerView.ValidatePassword(input));
        }

        [Fact]
        public void ValidatePassword_InvalidInput_RegexReturnsFalse8()
        {
            var customerView = new CustomerView();

            string input = "ABCDEFGH1";

            Assert.False(customerView.ValidatePassword(input));
        }

        [Fact]
        public void ValidatePassword_InvalidInput_RegexReturnsFalse9()
        {
            var customerView = new CustomerView();

            string input = "12345678";

            Assert.False(customerView.ValidatePassword(input));
        }

        [Fact]
        public void ValidatePassword_InvalidInput_RegexReturnsFalse10()
        {
            var customerView = new CustomerView();

            string input = "abcdefgh";

            Assert.False(customerView.ValidatePassword(input));
        }

        [Fact]
        public void ValidatePassword_InvalidInput_RegexReturnsFalse11()
        {
            var customerView = new CustomerView();

            string input = "????????";

            Assert.False(customerView.ValidatePassword(input));
        }


    }
}
