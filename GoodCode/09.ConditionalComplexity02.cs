namespace TrainingSessions.GoodCode
{
    // decorator, strategy, or state
    public class ConditionalComplexity02
    {
        public CustomerType GetCustomerType(DateTime currentDateTime)
        {
            if (!IsCookieValid())
                return CustomerType.NotRecognised;
 
            currentDateTime = new DateTime(currentDateTime.Year, currentDateTime.Month, currentDateTime.Day);

            var coverStartDate = new DateTime();

            if (_journeyCookieData != null && _journeyCookieData.Value.CoverStartDate != null)
            {
                    coverStartDate = new DateTime(_journeyCookieData.Value.CoverStartDate.Value.Year,
                    _journeyCookieData.Value.CoverStartDate.Value.Month,
                    _journeyCookieData.Value.CoverStartDate.Value.Day);
            }

            var elevenMonthsAgo = currentDateTime.AddYears(-1).AddDays(30);
            var oneYearAgo = currentDateTime.AddYears(-1);
            var oneMonthAgo = currentDateTime.AddDays(-30);
            var twoMonthsAgo = currentDateTime.AddDays(-60);
            var ninetyDaysAgo = currentDateTime.AddDays(-90);
            var oneDayAgo = currentDateTime.AddDays(-1);

            if (_journeyCookieData.Value.ProductClass == "TA" && !_travelPanelEnabled)
                return CustomerType.NotRecognised;

            if (_journeyCookieData.Value.ProductClass == "TS" && !_travelPanelEnabled)
                return CustomerType.NotRecognised;

            if ((coverStartDate <= elevenMonthsAgo) && (coverStartDate >= oneYearAgo) && 
                _journeyCookieData.Value.ProductClass != "LI" &&
                _journeyCookieData.Value.ProductClass != "EN" &&
                _journeyCookieData.Value.ProductClass != "TS"
                )
            {
                return CustomerType.ElevenMonthReturner;
            }

            if (_journeyCookieData != null && (_journeyCookieData.Value.ProductClass == "EN" &&
                                               _journeyCookieData.Value.LastQuoteDate >= ninetyDaysAgo))
            {
                IsEnergyReturner = true;
                return CustomerType.RecentReturner;
            }

            if (_journeyCookieData != null && (_journeyCookieData.Value.ProductClass == "EN" &&
                                   _journeyCookieData.Value.LastQuoteDate <= ninetyDaysAgo))
            {
                return CustomerType.NotRecent;
            }

            if (_journeyCookieData != null && (_journeyCookieData.Value.LastQuoteDate >= oneMonthAgo &&
                    (_journeyCookieData.Value.ProductClass == "LI" || _journeyCookieData.Value.ProductClass == "TS")
                    ))
            {
                return CustomerType.RecentReturner;
            }

            if (_journeyCookieData != null && ((_journeyCookieData.Value.ProductClass == "LI" || _journeyCookieData.Value.ProductClass == "TS") &&
                                               _journeyCookieData.Value.LastQuoteDate < oneMonthAgo &&
                                               _journeyCookieData.Value.LastQuoteDate >= twoMonthsAgo))
            {
                return CustomerType.RecentlyExpired;
            }

            if ((_journeyCookieData.Value.ProductClass == "LI" || _journeyCookieData.Value.ProductClass == "TS") &&
                (_journeyCookieData.Value.LastQuoteDate < twoMonthsAgo))
            {
                return CustomerType.NotRecent;
            }

            if ((coverStartDate < oneMonthAgo && coverStartDate > elevenMonthsAgo) || (coverStartDate < oneYearAgo))
            {
                return CustomerType.NotRecent;
            }

            if (coverStartDate <= oneDayAgo && coverStartDate >= oneMonthAgo)
            {
                return CustomerType.RecentlyExpired;
            }

            if (coverStartDate >= currentDateTime)
            {
                return CustomerType.RecentReturner;
            }

            return CustomerType.NotRecognised;
        }
    }


           

    public interface ICustomerTypeFactory
    {
        ICustomerType CreateCustomerType();
    }

    public class CustomerTypeFactory : ICustomerTypeFactory
    {
        private readonly List<ICustomerTypeValidator> _customerTypeValidators;

        public CustomerTypeFactory(ICtmJourneyCookieExtension cookie)
        {
            this._customerTypeValidators = new List<ICustomerTypeValidator>
            {
                new NotRecognisedCustomerValidator(cookie),
                new ElevenMonthReturnerCustomerValidator(cookie),
                new NotRecentCustomerValidator(cookie),
                new RecentlyExpiredCustomerValidator(cookie),
                new RecentReturnerCustomerValidator(cookie)
            };
        }

        public ICustomerType CreateCustomerType()
        {
            foreach (var customerTypeValidator in _customerTypeValidators)
            {
                if (customerTypeValidator.Validate())
                    return customerTypeValidator.GetCustomerType();
            }

            return new NotRecognisedCustomer();
        }
    }
}
