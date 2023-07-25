﻿// Decompiled with JetBrains decompiler
// Type: AmplifyImpostors.AmplifyImpostorBakePreset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AmplifyImpostors
{
  [CreateAssetMenu(fileName = "New Bake Preset", order = 86)]
  public class AmplifyImpostorBakePreset : ScriptableObject
  {
    [SerializeField]
    public Shader BakeShader;
    [SerializeField]
    public Shader RuntimeShader;
    [SerializeField]
    public int AlphaIndex;
    [SerializeField]
    public List<TextureOutput> Output;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AmplifyImpostorBakePreset() => throw null;
  }
}
