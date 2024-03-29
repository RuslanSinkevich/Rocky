﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Rocky_Utilitu
{
    public static class WC
    {
        public const string ImgPath = @"\img\product";

        public const string NoImage = @"\img\no-image.png";

        public const string SessionCart = "ShoppingCartSession";
        public const string SessionInquiryId = "InquirySession";

        public const string AdminRole = "Admin";
        public const string CustomerRole = "Customer";

        public const string EmailAdmin = "team_speak@mail.ru";

        public const string CategoryName = "Category";
        public const string ApplicationTypeName = "ApplicationType";

        public const string Success = "Success";
        public const string Error = "Error";

        public const string StatusPending = "Pending";
        public const string StatusApproved = "Approved";
        public const string StatusInProcess = "InProcess";
        public const string StatusShipped = "Shipped";
        public const string StatusCancelled = "Cancelled";
        public const string StatusRefunded = "Refunded";

        public static readonly IEnumerable<string> ListStatus = new ReadOnlyCollection<string>(
            new List<string>
            {
                StatusPending, StatusApproved, StatusInProcess,
                StatusShipped, StatusCancelled, StatusRefunded
            });

    }
}
