// Decompiled with JetBrains decompiler
// Type: ProFlareAtlas
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ProFlareAtlas : MonoBehaviour
{
  public Texture2D texture;
  public int elementNumber;
  public bool editElements;
  [SerializeField]
  public List<ProFlareAtlas.Element> elementsList;
  public string[] elementNameList;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateElementNameList() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ProFlareAtlas() => throw null;

  [Serializable]
  public class Element
  {
    public string name;
    public Rect UV;
    public bool Imported;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Element() => throw null;
  }
}
