// Decompiled with JetBrains decompiler
// Type: JBooth.VertexPainterPro.VertexInstanceStream
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace JBooth.VertexPainterPro
{
  [ExecuteInEditMode]
  public class VertexInstanceStream : MonoBehaviour
  {
    public bool keepRuntimeData;
    [HideInInspector]
    [SerializeField]
    private Color[] _colors;
    [HideInInspector]
    [SerializeField]
    private List<Vector4> _uv0;
    [SerializeField]
    [HideInInspector]
    private List<Vector4> _uv1;
    [SerializeField]
    [HideInInspector]
    private List<Vector4> _uv2;
    [SerializeField]
    [HideInInspector]
    private List<Vector4> _uv3;
    [HideInInspector]
    [SerializeField]
    private Vector3[] _positions;
    [HideInInspector]
    [SerializeField]
    private Vector3[] _normals;
    [HideInInspector]
    [SerializeField]
    private Vector4[] _tangents;
    private bool enforcedColorChannels;
    private Mesh meshStream;

    public Color[] colors
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public List<Vector4> uv0
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public List<Vector4> uv1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public List<Vector4> uv2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public List<Vector4> uv3
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3[] positions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3[] normals
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector4[] tangents
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnforceOriginalMeshHasColors(Mesh stream) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Mesh Apply(bool markNoLongerReadable = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VertexInstanceStream() => throw null;
  }
}
