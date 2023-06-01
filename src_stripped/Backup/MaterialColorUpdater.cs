// Decompiled with JetBrains decompiler
// Type: MaterialColorUpdater
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
