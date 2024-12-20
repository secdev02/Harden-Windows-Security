﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//       LottieGen version:
//           8.1.240821.1+077322fa26
//       
//       Command:
//           LottieGen -Language CSharp -Public -WinUIVersion 3.0 -InputFile Deny.json
//       
//       Input file:
//           Deny.json (60199 bytes created 21:19+02:00 Dec 15 2024)
//       
//       LottieGen source:
//           http://aka.ms/Lottie
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// ____________________________________
// |       Object stats       | Count |
// |__________________________|_______|
// | All CompositionObjects   |    36 |
// |--------------------------+-------|
// | Expression animators     |     1 |
// | KeyFrame animators       |     6 |
// | Reference parameters     |     1 |
// | Expression operations    |     0 |
// |--------------------------+-------|
// | Animated brushes         |     1 |
// | Animated gradient stops  |     - |
// | ExpressionAnimations     |     1 |
// | PathKeyFrameAnimations   |     2 |
// |--------------------------+-------|
// | ContainerVisuals         |     1 |
// | ShapeVisuals             |     1 |
// |--------------------------+-------|
// | ContainerShapes          |     1 |
// | CompositionSpriteShapes  |     2 |
// |--------------------------+-------|
// | Brushes                  |     1 |
// | Gradient stops           |     - |
// | CompositionVisualSurface |     - |
// ------------------------------------
using Microsoft.Graphics;
using Microsoft.Graphics.Canvas.Geometry;
using Microsoft.UI.Composition;
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.UI;

namespace AnimatedVisuals
{
    // Name:        add-cancel
    // Frame rate:  24 fps
    // Frame count: 28
    // Duration:    1166.7 mS
    // _____________________________________________________________________________________________
    // |           Marker           |           Constant           | Frame |   mS   |   Progress   |
    // |____________________________|______________________________|_______|________|______________|
    // | NormalToPressed_Start      | M_NormalToPressed_Start      |     0 |    0.0 | 0F           |
    // | NormalToPressed_End        | M_NormalToPressed_End        |     9 |  375.0 | 0.323214293F |
    // | PointerOverToPressed_Start | M_PointerOverToPressed_Start |     9 |  375.0 | 0.323214293F |
    // | PointerOverToPressed_End   | M_PointerOverToPressed_End   |    19 |  791.7 | 0.680357158F |
    // | PressedToNormal_Start      | M_PressedToNormal_Start      |    20 |  833.3 | 0.716071427F |
    // | PressedToNormal_End        | M_PressedToNormal_End        |    28 | 1166.7 | 1F           |
    // | PressedToPointerOver_Start | M_PressedToPointerOver_Start |    28 | 1166.7 | 1F           |
    // | PressedToPointerOver_End   | M_PressedToPointerOver_End   |    28 | 1166.7 | 1F           |
    // ---------------------------------------------------------------------------------------------
    sealed partial class Deny
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
        , Microsoft.UI.Xaml.Controls.IAnimatedVisualSource2
    {
        // Animation duration: 1.167 seconds.
        internal const long c_durationTicks = 11666666;

        // Marker: NormalToPressed_Start.
        internal const float M_NormalToPressed_Start = 0F;

        // Marker: NormalToPressed_End.
        internal const float M_NormalToPressed_End = 0.323214293F;

        // Marker: PointerOverToPressed_Start.
        internal const float M_PointerOverToPressed_Start = 0.323214293F;

        // Marker: PointerOverToPressed_End.
        internal const float M_PointerOverToPressed_End = 0.680357158F;

        // Marker: PressedToNormal_Start.
        internal const float M_PressedToNormal_Start = 0.716071427F;

        // Marker: PressedToNormal_End.
        internal const float M_PressedToNormal_End = 1F;

        // Marker: PressedToPointerOver_Start.
        internal const float M_PressedToPointerOver_Start = 1F;

        // Marker: PressedToPointerOver_End.
        internal const float M_PressedToPointerOver_End = 1F;

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor)
        {
            object ignored = null;
            return TryCreateAnimatedVisual(compositor, out ignored);
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor, out object diagnostics)
        {
            diagnostics = null;

            var res =
                new Deny_AnimatedVisual(
                    compositor
                    );
            res.CreateAnimations();
            return res;
        }

        /// <summary>
        /// Gets the number of frames in the animation.
        /// </summary>
        public double FrameCount => 28d;

        /// <summary>
        /// Gets the frame rate of the animation.
        /// </summary>
        public double Framerate => 24d;

        /// <summary>
        /// Gets the duration of the animation.
        /// </summary>
        public TimeSpan Duration => TimeSpan.FromTicks(11666666);

        /// <summary>
        /// Converts a zero-based frame number to the corresponding progress value denoting the
        /// start of the frame.
        /// </summary>
        public double FrameToProgress(double frameNumber)
        {
            return frameNumber / 28d;
        }

        /// <summary>
        /// Returns a map from marker names to corresponding progress values.
        /// </summary>
        public IReadOnlyDictionary<string, double> Markers =>
            new Dictionary<string, double>
            {
                { "NormalToPressed_Start", 0d },
                { "NormalToPressed_End", 0.323214285714286 },
                { "PointerOverToPressed_Start", 0.323214285714286 },
                { "PointerOverToPressed_End", 0.680357142857143 },
                { "PressedToNormal_Start", 0.716071428571429 },
                { "PressedToNormal_End", 1d },
                { "PressedToPointerOver_Start", 1d },
                { "PressedToPointerOver_End", 1d },
            };

        /// <summary>
        /// Sets the color property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetColorProperty(string propertyName, Color value)
        {
        }

        /// <summary>
        /// Sets the scalar property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetScalarProperty(string propertyName, double value)
        {
        }

        sealed partial class Deny_AnimatedVisual
            : Microsoft.UI.Xaml.Controls.IAnimatedVisual
            , Microsoft.UI.Xaml.Controls.IAnimatedVisual2
        {
            const long c_durationTicks = 11666666;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            AnimationController _animationController_0;
            CompositionColorBrush _animatedColorBrush_AlmostTomato_FFF44336_to_AlmostTomato_FFF44336;
            CompositionContainerShape _containerShape;
            CompositionPath _path_0;
            CompositionPath _path_1;
            CompositionPath _path_2;
            CompositionPath _path_3;
            CompositionPathGeometry _pathGeometry_0;
            CompositionPathGeometry _pathGeometry_1;
            CompositionSpriteShape _spriteShape_0;
            CompositionSpriteShape _spriteShape_1;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_0;
            ScalarKeyFrameAnimation _strokeThicknessScalarAnimation_5_to_5;
            StepEasingFunction _holdThenStepEasingFunction;
            StepEasingFunction _stepThenHoldEasingFunction;

            void BindProperty(
                CompositionObject target,
                string animatedPropertyName,
                string expression,
                string referenceParameterName,
                CompositionObject referencedObject)
            {
                _reusableExpressionAnimation.ClearAllParameters();
                _reusableExpressionAnimation.Expression = expression;
                _reusableExpressionAnimation.SetReferenceParameter(referenceParameterName, referencedObject);
                target.StartAnimation(animatedPropertyName, _reusableExpressionAnimation);
            }

            ColorKeyFrameAnimation CreateColorKeyFrameAnimation(float initialProgress, Color initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateColorKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InterpolationColorSpace = CompositionColorSpace.Rgb;
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            PathKeyFrameAnimation CreatePathKeyFrameAnimation(float initialProgress, CompositionPath initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreatePathKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            ScalarKeyFrameAnimation CreateScalarKeyFrameAnimation(float initialProgress, float initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateScalarKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                return result;
            }

            AnimationController AnimationController_0()
            {
                if (_animationController_0 != null) { return _animationController_0; }
                var result = _animationController_0 = _c.CreateAnimationController();
                result.Pause();
                BindProperty(_animationController_0, "Progress", "_.Progress", "_", _root);
                return result;
            }

            CanvasGeometry Geometry_0()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(13.7889996F, 13.7889996F));
                    builder.AddCubicBezier(new Vector2(13.7889996F, 13.7889996F), new Vector2(-13.7889996F, -13.7889996F), new Vector2(-13.7889996F, -13.7889996F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_1()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(13.4119997F, 13.4119997F));
                    builder.AddCubicBezier(new Vector2(13.4119997F, 13.4119997F), new Vector2(-13.4119997F, -13.4119997F), new Vector2(-13.4119997F, -13.4119997F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_2()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(-13.7889996F, 13.7889996F));
                    builder.AddCubicBezier(new Vector2(-13.7889996F, 13.7889996F), new Vector2(13.7889996F, -13.7889996F), new Vector2(13.7889996F, -13.7889996F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_3()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(-13.4020004F, 13.4020004F));
                    builder.AddCubicBezier(new Vector2(-13.4020004F, 13.4020004F), new Vector2(13.4020004F, -13.4020004F), new Vector2(13.4020004F, -13.4020004F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // Color
            ColorKeyFrameAnimation ColorAnimation_AlmostTomato_FFF44336_to_AlmostTomato_FFF44336()
            {
                // Frame 0.
                var result = CreateColorKeyFrameAnimation(0F, Color.FromArgb(0xFF, 0xF4, 0x43, 0x36), StepThenHoldEasingFunction());
                // Frame 5.
                // AlmostTomato_FFF44336
                result.InsertKeyFrame(0.178571433F, Color.FromArgb(0xFF, 0xF4, 0x43, 0x36), HoldThenStepEasingFunction());
                // Frame 9.
                // AlmostSeaGreen_FF429F46
                result.InsertKeyFrame(0.321428567F, Color.FromArgb(0xFF, 0x42, 0x9F, 0x46), CubicBezierEasingFunction_0());
                // Frame 19.
                // AlmostSeaGreen_FF429F46
                result.InsertKeyFrame(0.678571403F, Color.FromArgb(0xFF, 0x42, 0x9F, 0x46), CubicBezierEasingFunction_0());
                // Frame 23.
                // AlmostTomato_FFF44336
                result.InsertKeyFrame(0.821428597F, Color.FromArgb(0xFF, 0xF4, 0x43, 0x36), CubicBezierEasingFunction_0());
                return result;
            }

            CompositionColorBrush AnimatedColorBrush_AlmostTomato_FFF44336_to_AlmostTomato_FFF44336()
            {
                if (_animatedColorBrush_AlmostTomato_FFF44336_to_AlmostTomato_FFF44336 != null) { return _animatedColorBrush_AlmostTomato_FFF44336_to_AlmostTomato_FFF44336; }
                var result = _animatedColorBrush_AlmostTomato_FFF44336_to_AlmostTomato_FFF44336 = _c.CreateColorBrush();
                return result;
            }

            // Shape tree root for layer: Plus-Cross
            CompositionContainerShape ContainerShape()
            {
                if (_containerShape != null) { return _containerShape; }
                var result = _containerShape = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(24F, 24F);
                var shapes = result.Shapes;
                // ShapeGroup: Group 2 Offset:<23.999, 24>
                shapes.Add(SpriteShape_0());
                // ShapeGroup: Group 2 Offset:<23.999, 24>
                shapes.Add(SpriteShape_1());
                return result;
            }

            CompositionPath Path_0()
            {
                if (_path_0 != null) { return _path_0; }
                var result = _path_0 = new CompositionPath(Geometry_0());
                return result;
            }

            CompositionPath Path_1()
            {
                if (_path_1 != null) { return _path_1; }
                var result = _path_1 = new CompositionPath(Geometry_1());
                return result;
            }

            CompositionPath Path_2()
            {
                if (_path_2 != null) { return _path_2; }
                var result = _path_2 = new CompositionPath(Geometry_2());
                return result;
            }

            CompositionPath Path_3()
            {
                if (_path_3 != null) { return _path_3; }
                var result = _path_3 = new CompositionPath(Geometry_3());
                return result;
            }

            // - - Shape tree root for layer: Plus-Cross
            // ShapeGroup: Group 2 Offset:<23.999, 24>
            CompositionPathGeometry PathGeometry_0()
            {
                if (_pathGeometry_0 != null) { return _pathGeometry_0; }
                var result = _pathGeometry_0 = _c.CreatePathGeometry();
                return result;
            }

            // - - Shape tree root for layer: Plus-Cross
            // ShapeGroup: Group 2 Offset:<23.999, 24>
            CompositionPathGeometry PathGeometry_1()
            {
                if (_pathGeometry_1 != null) { return _pathGeometry_1; }
                var result = _pathGeometry_1 = _c.CreatePathGeometry();
                return result;
            }

            // - Shape tree root for layer: Plus-Cross
            // Path 1
            CompositionSpriteShape SpriteShape_0()
            {
                // Offset:<23.999, 24>
                if (_spriteShape_0 != null) { return _spriteShape_0; }
                var result = _spriteShape_0 = CreateSpriteShape(PathGeometry_0(), new Matrix3x2(1F, 0F, 0F, 1F, 23.9990005F, 24F)); ;
                result.StrokeBrush = AnimatedColorBrush_AlmostTomato_FFF44336_to_AlmostTomato_FFF44336();
                result.StrokeMiterLimit = 5F;
                return result;
            }

            // - Shape tree root for layer: Plus-Cross
            // Path 1
            CompositionSpriteShape SpriteShape_1()
            {
                // Offset:<23.999, 24>
                if (_spriteShape_1 != null) { return _spriteShape_1; }
                var result = _spriteShape_1 = CreateSpriteShape(PathGeometry_1(), new Matrix3x2(1F, 0F, 0F, 1F, 23.9990005F, 24F)); ;
                result.StrokeBrush = AnimatedColorBrush_AlmostTomato_FFF44336_to_AlmostTomato_FFF44336();
                result.StrokeMiterLimit = 5F;
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                if (_root != null) { return _root; }
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                // Shape tree root for layer: Plus-Cross
                result.Children.InsertAtTop(ShapeVisual_0());
                return result;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_0()
            {
                return (_cubicBezierEasingFunction_0 == null)
                    ? _cubicBezierEasingFunction_0 = _c.CreateCubicBezierEasingFunction(new Vector2(0.333000004F, 0F), new Vector2(0.666999996F, 1F))
                    : _cubicBezierEasingFunction_0;
            }

            // - - - Shape tree root for layer: Plus-Cross
            // - ShapeGroup: Group 2 Offset:<23.999, 24>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_0()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_0(), StepThenHoldEasingFunction());
                // Frame 9.
                result.InsertKeyFrame(0.321428567F, Path_0(), HoldThenStepEasingFunction());
                // Frame 11.
                result.InsertKeyFrame(0.392857134F, Path_1(), CubicBezierEasingFunction_0());
                // Frame 17.
                result.InsertKeyFrame(0.607142866F, Path_1(), CubicBezierEasingFunction_0());
                // Frame 19.
                result.InsertKeyFrame(0.678571403F, Path_0(), CubicBezierEasingFunction_0());
                return result;
            }

            // - - - Shape tree root for layer: Plus-Cross
            // - ShapeGroup: Group 2 Offset:<23.999, 24>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_1()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_2(), StepThenHoldEasingFunction());
                // Frame 9.
                result.InsertKeyFrame(0.321428567F, Path_2(), HoldThenStepEasingFunction());
                // Frame 11.
                result.InsertKeyFrame(0.392857134F, Path_3(), CubicBezierEasingFunction_0());
                // Frame 17.
                result.InsertKeyFrame(0.607142866F, Path_3(), CubicBezierEasingFunction_0());
                // Frame 19.
                result.InsertKeyFrame(0.678571403F, Path_2(), CubicBezierEasingFunction_0());
                return result;
            }

            // - Shape tree root for layer: Plus-Cross
            // Rotation
            ScalarKeyFrameAnimation RotationAngleInDegreesScalarAnimation_0_to_90()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                // Frame 3.
                result.InsertKeyFrame(0.107142858F, 0F, HoldThenStepEasingFunction());
                // Frame 5.
                result.InsertKeyFrame(0.178571433F, -5F, CubicBezierEasingFunction_0());
                // Frame 9.
                result.InsertKeyFrame(0.321428567F, 50F, CubicBezierEasingFunction_0());
                // Frame 11.
                result.InsertKeyFrame(0.392857134F, 45F, CubicBezierEasingFunction_0());
                // Frame 17.
                result.InsertKeyFrame(0.607142866F, 45F, CubicBezierEasingFunction_0());
                // Frame 19.
                result.InsertKeyFrame(0.678571403F, 40F, CubicBezierEasingFunction_0());
                // Frame 23.
                result.InsertKeyFrame(0.821428597F, 95F, CubicBezierEasingFunction_0());
                // Frame 25.
                result.InsertKeyFrame(0.892857134F, 90F, CubicBezierEasingFunction_0());
                return result;
            }

            // StrokeThickness
            ScalarKeyFrameAnimation StrokeThicknessScalarAnimation_5_to_5()
            {
                // Frame 0.
                if (_strokeThicknessScalarAnimation_5_to_5 != null) { return _strokeThicknessScalarAnimation_5_to_5; }
                var result = _strokeThicknessScalarAnimation_5_to_5 = CreateScalarKeyFrameAnimation(0F, 5F, StepThenHoldEasingFunction());
                // Frame 5.
                result.InsertKeyFrame(0.178571433F, 5F, HoldThenStepEasingFunction());
                // Frame 9.
                result.InsertKeyFrame(0.321428567F, 6F, CubicBezierEasingFunction_0());
                // Frame 19.
                result.InsertKeyFrame(0.678571403F, 6F, CubicBezierEasingFunction_0());
                // Frame 23.
                result.InsertKeyFrame(0.821428597F, 5F, CubicBezierEasingFunction_0());
                return result;
            }

            // Shape tree root for layer: Plus-Cross
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(48F, 48F);
                result.Shapes.Add(ContainerShape());
                return result;
            }

            StepEasingFunction HoldThenStepEasingFunction()
            {
                if (_holdThenStepEasingFunction != null) { return _holdThenStepEasingFunction; }
                var result = _holdThenStepEasingFunction = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            StepEasingFunction StepThenHoldEasingFunction()
            {
                if (_stepThenHoldEasingFunction != null) { return _stepThenHoldEasingFunction; }
                var result = _stepThenHoldEasingFunction = _c.CreateStepEasingFunction();
                result.IsInitialStepSingleFrame = true;
                return result;
            }

            internal Deny_AnimatedVisual(
                Compositor compositor
                )
            {
                _c = compositor;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(48F, 48F);
            void IDisposable.Dispose() => _root?.Dispose();

            public void CreateAnimations()
            {
                _animatedColorBrush_AlmostTomato_FFF44336_to_AlmostTomato_FFF44336.StartAnimation("Color", ColorAnimation_AlmostTomato_FFF44336_to_AlmostTomato_FFF44336(), AnimationController_0());
                _containerShape.StartAnimation("RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_0_to_90(), AnimationController_0());
                _pathGeometry_0.StartAnimation("Path", PathKeyFrameAnimation_0(), AnimationController_0());
                _pathGeometry_1.StartAnimation("Path", PathKeyFrameAnimation_1(), AnimationController_0());
                _spriteShape_0.StartAnimation("StrokeThickness", StrokeThicknessScalarAnimation_5_to_5(), AnimationController_0());
                _spriteShape_1.StartAnimation("StrokeThickness", StrokeThicknessScalarAnimation_5_to_5(), AnimationController_0());
            }

            public void DestroyAnimations()
            {
                _animatedColorBrush_AlmostTomato_FFF44336_to_AlmostTomato_FFF44336.StopAnimation("Color");
                _containerShape.StopAnimation("RotationAngleInDegrees");
                _pathGeometry_0.StopAnimation("Path");
                _pathGeometry_1.StopAnimation("Path");
                _spriteShape_0.StopAnimation("StrokeThickness");
                _spriteShape_1.StopAnimation("StrokeThickness");
            }

        }
    }
}
