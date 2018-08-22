using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using Sledge.BspEditor.Documents;
using Sledge.BspEditor.Modification;
using Sledge.BspEditor.Modification.Operations;
using Sledge.BspEditor.Modification.Operations.Mutation;
using Sledge.BspEditor.Primitives.MapData;
using Sledge.BspEditor.Primitives.MapObjects;
using Sledge.BspEditor.Rendering.Viewport;
using Sledge.BspEditor.Tools.Draggable;
using Sledge.BspEditor.Tools.Selection.TransformationHandles;
using Sledge.BspEditor.Tools.Widgets;
using Sledge.DataStructures.Geometric;
using Sledge.Rendering.Cameras;
using Sledge.Rendering.Engine;
using Sledge.Rendering.Viewports;

namespace Sledge.BspEditor.Tools.Selection
{
    public class SelectionBoxDraggableState : BoxDraggableState
    {
        private readonly SelectTool _tool;

        public enum TransformationMode
        {
            Resize,
            Rotate,
            Skew
        }

        private List<IDraggable>[] _handles;
        public TransformationMode CurrentTransformationMode { get; private set; }
        private RotationOrigin _rotationOrigin;

        public List<Widget> Widgets { get; private set; }

        private bool _showWidgets;
        public bool ShowWidgets
        {
            get => _showWidgets;
            set
            {
                _showWidgets = value;
                Update();
            }
        }

        private readonly RotationWidget _rotationWidget;

        public SelectionBoxDraggableState(SelectTool tool) : base(tool)
        {
            _tool = tool;
            Widgets = new List<Widget>
            {
                (_rotationWidget = new RotationWidget(tool.Document) { Active = false })
            };
            BindWidgets();
        }

        private void BindWidgets()
        {
            foreach (var w in Widgets)
            {
                w.Transforming += WidgetTransforming;
                w.Transformed += WidgetTransformed;
            }
        }

        private void WidgetTransforming(Widget sender, Matrix4x4? transformation)
        {
            if (transformation.HasValue)
            {
                Engine.Interface.SetSelectiveTransform(transformation.Value);
            }
        }

        private void WidgetTransformed(Widget sender, Matrix4x4? transformation)
        {
            if (transformation.HasValue)
            {
                var objects = Tool.Document.Selection.GetSelectedParents().ToList();

                var transaction = new Transaction();

                // Perform the operation
                var matrix = transformation.Value;
                var transformOperation = new Transform(matrix, objects);
                transaction.Add(transformOperation);

                // Texture for texture operations
                var tl = Tool.Document.Map.Data.GetOne<TransformationFlags>() ?? new TransformationFlags();
                if (tl.TextureLock && sender.IsUniformTransformation)
                {
                    transaction.Add(new TransformTexturesUniform(matrix, objects.SelectMany(x => x.FindAll())));
                }
                else if (tl.TextureScaleLock && sender.IsScaleTransformation)
                {
                    transaction.Add(new TransformTexturesScale(matrix, objects.SelectMany(x => x.FindAll())));
                }

                MapDocumentOperation.Perform(Tool.Document, transaction);
            }
            Engine.Interface.SetSelectiveTransform(Matrix4x4.Identity);
        }

        public void Update()
        {
            _rotationWidget.Active = State.Action != BoxAction.Idle && CurrentTransformationMode == TransformationMode.Rotate && ShowWidgets;
            _rotationWidget.SetPivotPoint(_rotationOrigin.Position);
        }

        protected override void CreateBoxHandles()
        {
            var resize = new List<IDraggable>
            {
                new ResizeTransformHandle(this, ResizeHandle.TopLeft),
                new ResizeTransformHandle(this, ResizeHandle.TopRight),
                new ResizeTransformHandle(this, ResizeHandle.BottomLeft),
                new ResizeTransformHandle(this, ResizeHandle.BottomRight),

                new ResizeTransformHandle(this, ResizeHandle.Top),
                new ResizeTransformHandle(this, ResizeHandle.Right),
                new ResizeTransformHandle(this, ResizeHandle.Bottom),
                new ResizeTransformHandle(this, ResizeHandle.Left),

                new ResizeTransformHandle(this, ResizeHandle.Center), 
            };

            if (_rotationOrigin == null)
            {
                _rotationOrigin = new RotationOrigin(Tool);
                _rotationOrigin.DragMoved += (sender, args) => Update();
            }

            var rotate = new List<IDraggable>
            {
                _rotationOrigin,

                new RotateTransformHandle(this, ResizeHandle.TopLeft, _rotationOrigin),
                new RotateTransformHandle(this, ResizeHandle.TopRight, _rotationOrigin),
                new RotateTransformHandle(this, ResizeHandle.BottomLeft, _rotationOrigin),
                new RotateTransformHandle(this, ResizeHandle.BottomRight, _rotationOrigin),

                new ResizeTransformHandle(this, ResizeHandle.Center), 
            };

            var skew = new List<IDraggable>
            {
                new SkewTransformHandle(this, ResizeHandle.Top),
                new SkewTransformHandle(this, ResizeHandle.Right),
                new SkewTransformHandle(this, ResizeHandle.Bottom),
                new SkewTransformHandle(this, ResizeHandle.Left),

                new ResizeTransformHandle(this, ResizeHandle.Center), 
            };

            _handles = new [] { resize, rotate, skew };
        }

        public override IEnumerable<IDraggable> GetDraggables()
        {
            if (State.Action == BoxAction.Idle || State.Action == BoxAction.Drawing) return new IDraggable[0];
            return _handles[(int)CurrentTransformationMode];
        }

        public override bool CanDrag(MapViewport viewport, ViewportEvent e, Vector3 position)
        {
            return false;
        }

        public override void Render(IViewport viewport, OrthographicCamera camera, Vector3 worldMin, Vector3 worldMax, Graphics graphics)
        {
            base.Render(viewport, camera, worldMin, worldMax, graphics);
        }

        // public override IEnumerable<Element> GetViewportElements(MapViewport viewport, OrthographicCamera camera)
        // {
        //     var list = new List<Element>();
        //     var tf = GetTransformationMatrix(viewport, camera, Tool.Document);
        //     if (State.Action == BoxAction.Resizing && tf.HasValue)
        //     {
        //         // todo this looks pretty silly when the box doesn't perfectly match the transformed selection
        //         var box = new Box(State.OrigStart, State.OrigEnd);
        //         box = box.Transform(Matrix.FromOpenTKMatrix4x4(tf.Value));
        //         if (ShouldDrawBox())
        //         {
        //             foreach (var face in box.GetBoxFaces())
        //             {
        //                 var verts = face.Select(x => new PositionVertex(new Position(x.ToVector3()), 0, 0)).ToList();
        //                 var rc = GetRenderBoxColour();
        //                 var fe = new FaceElement(PositionType.World, Material.Flat(Color.FromArgb(rc.A / 8, rc)), verts)
        //                 {
        //                     RenderFlags = RenderFlags.Wireframe,
        //                     CameraFlags = CameraFlags.Orthographic,
        //                     AccentColor = GetRenderBoxColour(),
        //                     ZIndex = -20 // Put this face underneath the grid because it's semi-transparent
        //                 };
        //                 list.Add(fe);
        //             }
        //         }
        //         if (ShouldDrawBoxText())
        //         {
        //             list.AddRange(GetBoxTextElements(viewport, box.Start.ToVector3(), box.End.ToVector3()));
        //         }
        //     }
        //     else
        //     {
        //         list.AddRange(base.GetViewportElements(viewport, camera));
        //     }
        //     return list;
        // }

        public Matrix4x4? GetTransformationMatrix(MapViewport viewport, OrthographicCamera camera, MapDocument doc)
        {
            if (State.Action != BoxAction.Resizing) return null;
            var tt = Tool.CurrentDraggable as ITransformationHandle;
            return tt?.GetTransformationMatrix(viewport, camera, State, doc);
        }

        public TextureTransformationType GetTextureTransformationType(MapDocument doc)
        {
            if (State.Action != BoxAction.Resizing) return TextureTransformationType.None;
            var tt = Tool.CurrentDraggable as ITransformationHandle;
            return tt?.GetTextureTransformationType(doc) ?? TextureTransformationType.None;
        }

        public void Cycle()
        {
            var intMode = (int) CurrentTransformationMode;
            var numModes = Enum.GetValues(typeof (TransformationMode)).Length;
            var nextMode = (intMode + 1) % numModes;
            SetTransformationMode((TransformationMode) nextMode);
        }

        public void SetTransformationMode(TransformationMode mode)
        {
            CurrentTransformationMode = mode;

            _rotationOrigin.Position = new Box(State.Start, State.End).Center;

            //_scaleWidget.Active = _currentTransformationMode == TransformationMode.Resize;
            _rotationWidget.Active = CurrentTransformationMode == TransformationMode.Rotate && ShowWidgets;
            //_skewWidget.Active = _currentTransformationMode == TransformationMode.Skew;

            _tool.TransformationModeChanged(CurrentTransformationMode);
            Update();
        }
    }
}