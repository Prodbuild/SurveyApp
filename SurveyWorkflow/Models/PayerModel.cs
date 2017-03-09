using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollmentWorkflow.Models
{
    public class PayerModel
    {
        public String ClaimType { get; set; }

        public String Name { get; set; }

        public int Id { get; set; }

        public String PayerId { get; set; }

        public String ContactName { get; set; }

        public String ContactPhoneNumber { get; set; }

        public IList<String> ServiceStates { get; set; }

        public bool Selected { get; set; }

        public bool OffersRemits { get; set; }
    }

    class PayerComparer : IEqualityComparer<PayerModel>
    {
        // Products are equal if their names and product numbers are equal.
        public bool Equals(PayerModel x, PayerModel y)
        {

            //Check whether the compared objects reference the same data.
            if (Object.ReferenceEquals(x, y)) return true;

            //Check whether any of the compared objects is null.
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            //Check whether the products' properties are equal.
            return x.Id == y.Id;
        }

        public int GetHashCode(PayerModel payer)
        {
            //Check whether the object is null
            if (Object.ReferenceEquals(payer, null)) return 0;

            //Get hash code for the Code field.
            int hashPayerListId = payer.Id.GetHashCode();

            //Calculate the hash code for the product.
            return hashPayerListId;
        }

    }
}