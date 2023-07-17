using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "MQTT_Field", Guid = "0f793ebc01b89841089c95b3110c56ac")]
public class AnalogAlarmTBP : FTOptix.Alarm.ExclusiveLevelAlarmController
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public FTOptix.NetLogic.NetLogicObject AlarmPublisher
    {
        get
        {
            return (FTOptix.NetLogic.NetLogicObject)Refs.GetObject("AlarmPublisher");
        }
    }
#endregion
}
