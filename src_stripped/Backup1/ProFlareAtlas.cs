// Decompiled with JetBrains decompiler
// Type: ProFlareAtlas
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
