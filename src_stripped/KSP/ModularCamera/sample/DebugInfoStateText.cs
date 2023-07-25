// Decompiled with JetBrains decompiler
// Type: KSP.ModularCamera.sample.DebugInfoStateText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.ModularCamera.sample
{
  public class DebugInfoStateText : MonoBehaviour
  {
    [Header("Debug UI elements to update")]
    public List<DebugInfoStateText.DebugTextEntry> DebugTextEntries;
    [Header("Driver UI elements to update")]
    public Text TargetDistance;
    public Text GimbalPitch;
    public Text GimbalYaw;
    public Text GimbalRoll;
    [Header("Used for printing values")]
    [Space]
    public string textFormatFloat;
    private float lastDist;
    private float lastPitch;
    private float lastYaw;
    private float lastRoll;

    private string TextFormatFloat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string FormatChangedFloat(float newVal, float oldVal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDebugTexts(string key, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDriverValues(ICameraDriver driver) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DebugInfoStateText() => throw null;

    [Serializable]
    public struct DebugTextEntry
    {
      public string name;
      public Text element;
      public string format;
    }
  }
}
