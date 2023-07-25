﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.BaseField
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class BaseField
  {
    public bool active;
    public bool guiActive;
    public bool guiActiveEditor;
    public string guiName;
    public string guiUnits;
    public string guiFormat;
    public string category;
    public bool advancedTweakable;
    public bool uiControlOnly;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BaseField(
      string name,
      string units,
      string format,
      string category,
      bool advancedTweakable,
      bool uiControlOnly)
    {
      throw null;
    }
  }
}
