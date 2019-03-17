﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Motorcycle : Vehicle
    {
        public enum eLicenseType
        {
            A,
            A1,
            B1,
            B2  
        }

        private readonly eLicenseType r_LicenseType;
        private readonly int r_EngineCapacityInCC;

        public Motorcycle(string i_ModelName, string i_LicenseNumber, eLicenseType i_LicenseType, int i_EngineCapacityInCC, Engine i_MotorcycleEngine, string i_WheelModel) :
            base(i_ModelName, i_LicenseNumber, Constants.k_MotorcycleNumberOfWheels, i_MotorcycleEngine, Constants.k_MaxMotorcycleAirPressure,i_WheelModel)
        {
            r_LicenseType = i_LicenseType;
            r_EngineCapacityInCC = i_EngineCapacityInCC;
        }

        public eLicenseType LicenseType
        {
            get { return r_LicenseType; }
        }

        public int EngineCapacityInCC
        {
            get { return r_EngineCapacityInCC; }
        }

        public override string UniqueVehicleInfo()
        {
            string lisenceTypeInfo = "Motorcycle License Type: " + r_LicenseType.ToString();
            string engineCapacityInfo = "Motorcycle Engine Capacity: " +r_EngineCapacityInCC + " CC";
            return string.Format("{0}\n{1}", lisenceTypeInfo, engineCapacityInfo);
        }
    }
}
