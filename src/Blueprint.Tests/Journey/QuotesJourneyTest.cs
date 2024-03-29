﻿using Blueprint.Tests.Support;
using Blueprint.Tests.Support.Pages;
using NUnit.Framework;

namespace Blueprint.Tests.Journey
{
    [TestFixture]
    public class QuotesJourneyTest
    {
        [Test]
        public void ShouldDisplayAListOfQuotes()
        {
            // Given
            // in the repository store 5 quotes

            // When
            var page = Browser.Current.NavigateTo<QuotesPage>();

            page.Alert();

            Assert.That(page.WibbleText, Is.EqualTo("Hello World"));

            // Then
            Assert.That(page.Quotes.Count, Is.EqualTo(5));
        } 
    }
}