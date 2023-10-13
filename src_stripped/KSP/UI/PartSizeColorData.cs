// Decompiled with JetBrains decompiler
// Type: KSP.UI.PartSizeColorData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  [CreateAssetMenu(fileName = "PartSizeColorData", menuName = "ScriptableObjects/PartSizeColorData")]
  public class PartSizeColorData : ScriptableObject
  {
    [SerializeField]
    private List<Color> colors;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Color GetColor(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetColorCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartSizeColorData() => throw null;
  }
}
