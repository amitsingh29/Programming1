//-----------------------------------------------------------------------
// <copyright file="FacadeMain.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------


namespace DesignPattern.StructuralDesignPattern.FacadeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// FacadeMain class
    /// </summary>
    public class FacadeMain
    {

        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            CarFacade carFacade = new CarFacade();
            carFacade.CreateCompleteCar();
        }
    }
}
