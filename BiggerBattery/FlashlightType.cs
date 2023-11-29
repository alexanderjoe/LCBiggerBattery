namespace BiggerBattery
{
    // The FlashlightItem sort of a parent class for the Flashlight, ProFlashlight, and LaserPointer.
    // The are differentiated by the flashlightTypeID field.
    public enum FlashlightType
    {
        ProFlashlight = 0,
        Flashlight = 1,
        LaserPointer = 2,
    }
}