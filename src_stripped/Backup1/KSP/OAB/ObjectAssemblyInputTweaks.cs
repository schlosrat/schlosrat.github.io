// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyInputTweaks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.ModularCamera;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  [CreateAssetMenu(fileName = "ObjectAssemblyInputTweaks", menuName = "ScriptableObjects/ObjectAssemblyInputTweaks")]
  [Serializable]
  public class ObjectAssemblyInputTweaks : ScriptableObject
  {
    public static readonly float EPSILON_SQR;
    private const float MIN_EASE = 0.0f;
    private const float MAX_EASE = 0.995f;
    private static ObjectAssemblyInputTweaks.InputTweakValues identity;
    [Header("Move (3D) Tweaks")]
    public ObjectAssemblyInputTweaks.InputTweakValues MoveTweaks;
    [Header("Drag (2D) Tweaks")]
    public ObjectAssemblyInputTweaks.InputTweakValues DragTweaks;
    [Header("Scroll (1D) Tweaks")]
    public ObjectAssemblyInputTweaks.InputTweakValues ScrollTweaks;
    [Space]
    [Header("Optional Tweaks for other Bindings")]
    public List<ObjectAssemblyInputTweaks.TypedInputTweakValues> AdditionalTweaks;
    private Dictionary<CameraInputBinding, ObjectAssemblyInputTweaks.InputTweakValues> cachedMap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CacheMapping() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyInputTweaks.InputTweakValues GetTweaks(CameraInputBinding binding) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyInputTweaks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ObjectAssemblyInputTweaks() => throw null;

    [Serializable]
    public class InputTweakValues
    {
      [Header("Attack/Decay:   0 = quick, 1 = slow")]
      [Range(0.0f, 0.995f)]
      public float inputAttack;
      [Range(0.0f, 0.995f)]
      public float inputDecay;
      [Header("'Fast' is when shift held")]
      public bool isFastEnabled;
      public float sensitivity;
      public float fastSensitivity;

      public float InputAttack
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public float InputDecay
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputTweakValues() => throw null;
    }

    [Serializable]
    public class TypedInputTweakValues : ObjectAssemblyInputTweaks.InputTweakValues
    {
      [Header("Input bindings that use these Tweaks")]
      public List<CameraInputBinding> inputs;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public TypedInputTweakValues() => throw null;
    }
  }
}
