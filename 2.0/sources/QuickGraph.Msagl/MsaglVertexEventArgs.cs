using System;
using Microsoft.Msagl.Drawing;

namespace QuickGraph.Msagl
{
    public sealed class MsaglVertexEventArgs<TVertex> : VertexEventArgs<TVertex>
    {
        private readonly Node node;

        public MsaglVertexEventArgs(TVertex vertex, Node node)
            : base(vertex)
        {
            this.node = node;
        }

        public Node Node
        {
            get { return this.node; }
        }
    }

    public delegate void MsaglVertexNodeEventHandler<Vertex>(
        object sender,
        MsaglVertexEventArgs<Vertex> args);
}
