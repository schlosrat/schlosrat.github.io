// Decompiled with JetBrains decompiler
// Type: KSP.Input.InputLocks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    private const string NEXTSYMMETRYMODE = "nextSymmetryMode";
    private const string PREVSYMMETRYMODE = "previousSymmetryMode";
    private const string SETSYMMETRYMODE = "setSymmetryMirrorMode";
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
    public static InputLockDefinition SymmetryEnabled;
    public static InputLockDefinition SymmetryDisabled;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static InputLocks() => throw null;
  }
}
