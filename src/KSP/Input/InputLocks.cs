// Decompiled with JetBrains decompiler
// Type: KSP.Input.InputLocks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Input
{
  public static class InputLocks
  {
    private const string STAGE = "Stage";
    private const string YAW = "Yaw";
    private const string PITCH = "Pitch";
    private const string ROLL = "Roll";
    private const string TRANSLATE_X = "TranslateX";
    private const string TRANSLATE_Y = "TranslateY";
    private const string TRANSLATE_Z = "TranslateZ";
    private const string INTERACT = "Interact";
    private const string INTERACT_ALT = "InteractAlt";
    private const string INTERACT_ALT_2 = "InteractAlt2";
    private const string TIMEWARP_INCREASE = "TimeWarpIncrease";
    private const string TIMEWARP_DECREASE = "TimeWarpDecrease";
    private const string TIMEWARP_STOP = "TimeWarpStop";
    public static InputLockDefinition GlobalInputEnabled;
    public static InputLockDefinition GlobalInputDisabled;
    public static InputLockDefinition FlightInputEnabled;
    public static InputLockDefinition FlightInputDisabled;
    public static InputLockDefinition EVAInputEnabled;
    public static InputLockDefinition EVAInputDisabled;
    public static InputLockDefinition FlightInteractEnabled;
    public static InputLockDefinition FlightInteractDisabled;
    public static InputLockDefinition OABInputEnabled;
    public static InputLockDefinition OABInputDisabled;
    public static InputLockDefinition MapViewInputEnabled;
    public static InputLockDefinition MapViewInputDisabled;
    public static InputLockDefinition RDInputEnabled;
    public static InputLockDefinition RDInputDisabled;
    public static InputLockDefinition KSCInputEnabled;
    public static InputLockDefinition KSCInputDisabled;
    public static InputLockDefinition AudioInputEnabled;
    public static InputLockDefinition AudioInputDisabled;
    public static InputLockDefinition FlightStagingEnabled;
    public static InputLockDefinition FlightStagingDisabled;
    public static InputLockDefinition FlightTranslationEnabled;
    public static InputLockDefinition FlightTranslationDisabled;
    public static InputLockDefinition FlightPitchYawRollEnabled;
    public static InputLockDefinition FlightPitchYawRollDisabled;
    public static InputLockDefinition TimeWarpEnabled;
    public static InputLockDefinition TimeWarpDisabled;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static InputLocks() => throw null;
  }
}
