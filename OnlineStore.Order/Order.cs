﻿/*
*	<copyright file="OnlineStore.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Arantes19</author>
*   <date>15/11/2023</date>
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Order
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

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Order class.
        /// </summary>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <param name="totalAmmount">The total amount associated with the order.</param>
        public Order(int orderId, int totalAmmount)
        {
            this.orderId = orderId;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the unique identifier of the order.
        /// </summary>
        public int OrderId
        { get { return orderId; } }

        /// <summary>
        /// Gets the total amount associated with the order.
        /// </summary>
        public int TotalAmmount
        { get { return totalAmmount; } }


        #endregion

        #region Overrides
        #endregion

        #endregion
    }
}