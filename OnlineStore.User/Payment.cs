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
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace OnlineStore.Order
{
    /// <summary>
    /// Represents the payment 
    /// </summary>
    public class Payment : OnlineStore.Order.Order
    {
        #region Properties
        #endregion

        #region Methods

        #region Constructors

        public Payment(int orderId, int totalAmmount) : base(orderId, totalAmmount)
        {
        }

        #endregion

        #endregion
    }
}
