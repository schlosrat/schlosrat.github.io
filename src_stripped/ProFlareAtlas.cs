// Decompiled with JetBrains decompiler
// Type: ProFlareAtlas
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
