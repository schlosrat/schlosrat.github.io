// Decompiled with JetBrains decompiler
// Type: MaterialColorUpdater
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class MaterialColorUpdater
{
  public List<Renderer> renderers;
  public int propertyID;
  private Color setColor;
  private MaterialPropertyBlock mpb;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public MaterialColorUpdater(Transform t, int propertyID) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateRendererList(Transform t, int propertyID) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Update(Color color, bool force = false) => throw null;
}
