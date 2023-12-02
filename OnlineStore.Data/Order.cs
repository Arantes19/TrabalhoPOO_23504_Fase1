﻿/*
*	<copyright file="OnlineStore.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Arantes19</author>
*   <date>15/11/2023</date>
**/

namespace OnlineStore.Data
{
    /// <summary>
    /// Represents an order.
    /// </summary>
    public class Order
    {
        #region Attributes

        private int orderId;
        private int totalAmmount;
        private List<Order> orders;
        private List<Product> product;

        #endregion

        #region Methods 

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Order class.
        /// </summary>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="totalAmmount">The total amount associated with the order.</param>
        public Order(int orderId, Product product, int totalAmmount)
        {
            this.orderId = orderId;
            this.totalAmmount = totalAmmount;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the unique identifier of the order.
        /// </summary>
        public int OrderId
        {
            get { return orderId; }
            set => orderId = value;
        }

        /// <summary>
        /// Gets the total amount associated with the order.
        /// </summary>
        public int TotalAmmount
        {
            get { return totalAmmount; }
            set => totalAmmount = value;
        }

        #endregion

        #region Overrides
        #endregion

        #endregion
    }
}