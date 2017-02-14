﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace efcWeb.CoreClasses
{

    [System.Serializable]
    public class EngineMessageException : System.Exception
    {

        public EngineMessageException() { }
        public EngineMessageException(string message) : base( message ) { }
        public EngineMessageException(string message, System.Exception inner) : base( message, inner ) { }
        protected EngineMessageException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base( info, context ) { }
    }

    [Flags]
    public enum EngineStatus
    {
        Stopped = 0,
        Running = 1,
        Reverse = 2,
        Fault = 4,
        Accelerating = 8,
        Decelerating = 10,
        SpeedReached = 1,
        DcBreaking = 14
    }

    public enum EngineModel
    {
        VegaDrive = 7
    }

    public enum EngineVersion
    {
        Version_1_0_E = 313045,
        Version_5_0_E = 353045
    }




    public interface IEngine
    {
        EngineStatus Status();
        void Start();
        void Stop();
        void Reverse();
        void Reset();
        void EmergencyStop();

        EngineModel GetInverterModel();
        EngineVersion GetInverterVersion();
        void SetReferneceFrequenct(int newFrequency);

    }
}