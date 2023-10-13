// Decompiled with JetBrains decompiler
// Type: MaterialColorUpdater
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
