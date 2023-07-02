// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_WheelBogey
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_WheelBogey : ModuleData
  {
    [KSPDefinition]
    [Tooltip("The reference transform for the wheels (the spinny bits).")]
    public string wheelTransformRefName;
    [KSPDefinition]
    [Tooltip("The wheel transform name (the spinny bits). If multiple they have to have the same transform name.")]
    public string wheelTransformBaseName;
    [KSPDefinition]
    [Tooltip("The transform name for the bogey that is rotated/pitched.")]
    public string bogeyTransformName;
    [Tooltip("The bogey reference transform")]
    [KSPDefinition]
    public string bogeyRefTransformName;
    [Tooltip("")]
    [KSPDefinition]
    public float maxPitch;
    [KSPDefinition]
    [Tooltip("The minimum pitch angle")]
    public float minPitch;
    [KSPDefinition]
    [Tooltip("The resting pitch (angle in degrees)")]
    public float restPitch;
    [KSPDefinition]
    [Tooltip("How fast the pitch of the bogey is rotated (in secs).")]
    public float pitchResponse;
    [KSPDefinition]
    [Tooltip("The axis the bogey rotates around.")]
    public Vector3 bogeyAxis;
    [KSPDefinition]
    [Tooltip("The up axis for the bogey.")]
    public Vector3 bogeyUpAxis;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_WheelBogey() => throw null;
  }
}
