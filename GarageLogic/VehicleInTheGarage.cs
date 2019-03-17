﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class VehicleInTheGarage
    {
        public enum eVehicleStatus
        {
            InProgress,
            WaitingToGetPayment,
            PaidAndReadyToGo,
            AllStatus
                ///////////////////////////////////////////////////
        }

        private readonly string r_OwnerName;
        private readonly string r_OwnerPhoneNumber;
        private Vehicle m_Vehicle;
        private eVehicleStatus m_VehicleStatusInTheGarage;

        public VehicleInTheGarage(string i_OwnerName, string i_OwnerPhoneNumber, Vehicle i_Vehicle)
        {
            r_OwnerName = i_OwnerName;
            r_OwnerPhoneNumber = i_OwnerPhoneNumber;
            m_VehicleStatusInTheGarage = eVehicleStatus.InProgress;
            m_Vehicle = i_Vehicle;
        }

        public string SearchLicenseNumber
        {
            get { return m_Vehicle.LicenseNumber; }
        }
        
        public Vehicle Vehicle
        {
            get { return m_Vehicle; }
        }

        public eVehicleStatus VehicleStatus
        {
            get { return m_VehicleStatusInTheGarage; }
        }
        public string OwnerName
        {
            get { return r_OwnerName; }      
        }

        public eVehicleStatus StatusInTheGarage
        {
            get { return m_VehicleStatusInTheGarage; }
            set { m_VehicleStatusInTheGarage = value; }
        }

        public string VehicleInTheGarageInfo()
        {
            string allInfo;
            string ownerNameInfo = "Owner Name: " + r_OwnerName.ToString();
            string ownerPhoneNumber = "Owner Phone Number:  " + r_OwnerPhoneNumber.ToString();
            string garageStatusInfo = "Garage Status: " + m_VehicleStatusInTheGarage.ToString();
            allInfo = string.Format("{0}\n{1}\n{2},{3}\n", ownerNameInfo, ownerPhoneNumber, garageStatusInfo, m_Vehicle.VehicleInfo());
            return allInfo;

        }
        ////public eVehicleStatus ConvertVehicleStatusFromChar(char i_VehicleNewStatusAsChar)
        ////{
        ////    if (i_VehicleNewStatusAsChar == Constants.k_InProgress)
        ////    {
                
        ////    }
        ////    else if (i_VehicleNewStatusAsChar == Constants.k_WaitingToGetPayment)
        ////    {
        ////    }
        ////    else
        ////    { //// (i_VehicleNewStatusAsChar == Constants.k_PaidAndReadyToGo)

        ////    }
        ////}

    }
}
