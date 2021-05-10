extern "C"
{
    float GetBatteryLevel()
    {
        [UIDevice currentDevice].batteryMonitoringEnabled = YES;
        return [UIDevice currentDevice].batteryLevel;
    }

    bool IsBatteryCharging()
    {
        [UIDevice currentDevice].batteryMonitoringEnabled = YES;
        return ([UIDevice currentDevice].batteryState != UIDeviceBatteryStateUnplugged);
    }
}
