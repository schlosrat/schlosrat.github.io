﻿// Decompiled with JetBrains decompiler
// Type: SubtitleBacking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

[ExecuteInEditMode]
public class SubtitleBacking : MonoBehaviour
{
  [SerializeField]
  private MeshRenderer _backgroundQuadRenderer;
  [SerializeField]
  private Vector2 _extraBorder;
  [SerializeField]
  private MeshFilter _textMeshFilter;
  [SerializeField]
  private TextMeshProUGUI _text;
  private Vector3 initialScale;
  private float initialOffset;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public SubtitleBacking() => throw null;
}
