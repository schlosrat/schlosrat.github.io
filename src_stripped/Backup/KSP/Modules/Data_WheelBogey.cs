// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_WheelBogey
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
    [Tooltip("The transform name for the bogey that is rotated/pitched.")]
    [KSPDefinition]
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
    [Tooltip("The up axis for the bogey.")]
    [KSPDefinition]
    public Vector3 bogeyUpAxis;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_WheelBogey() => throw null;
  }
}
