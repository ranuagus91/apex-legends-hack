namespace ApexHack.Core.Memory;

/// <summary>Structure offsets for Apex Legends — update after each game patch.</summary>
public static class Offsets
{
    /// <summary>Module-level addresses (relative to module base).</summary>
    public static class Client
    {
        public const nint LocalPlayer        = 0x16478DE;
        public const nint EntityList         = 0x1888AE3;
        public const nint ViewMatrix         = 0x19EEE3C;
        public const nint GameRules          = 0x18AD5A9;
        public const nint GlobalVars         = 0x171A5B9;
        public const nint InputSystem        = 0x1A6B3A9;
    }

    /// <summary>Entity / pawn struct field offsets.</summary>
    public static class Entity
    {
        public const nint Health             = 0x3DE;
        public const nint TeamNum            = 0x3A4;
        public const nint Origin             = 0x12E3;
        public const nint EyeAngles          = 0x1648;
        public const nint SceneNode          = 0x33C;
        public const nint ModelState         = 0x16E;
        public const nint ShotsFired         = 0x25A9;
        public const nint AimPunch           = 0x1722;
        public const nint IsScoped           = 0x24B9;
        public const nint CrosshairId        = 0x15A1;
        public const nint Flags              = 0x1A9;
        public const nint Velocity           = 0x15E6;
        public const nint FlashDuration      = 0x15BE;
        public const nint SpottedMask        = 0x167C;
        public const nint BoneMatrix         = 0x835;
    }

    /// <summary>Bone indices for skeleton rendering and aim targeting.</summary>
    public static class Bones
    {
        public const int Head               = 6;
        public const int Neck               = 5;
        public const int SpineUpper         = 4;
        public const int SpineMid           = 3;
        public const int Pelvis             = 0;
        public const int LeftShoulder       = 8;
        public const int LeftElbow          = 9;
        public const int LeftHand           = 13;
        public const int RightShoulder      = 30;
        public const int RightElbow         = 31;
        public const int RightHand          = 35;
        public const int LeftKnee           = 22;
        public const int LeftFoot           = 24;
        public const int RightKnee          = 44;
        public const int RightFoot          = 46;
    }
}
