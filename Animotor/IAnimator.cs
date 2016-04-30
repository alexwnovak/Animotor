//using System;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Media.Animation;

//namespace Animotor
//{
//   public interface IAnimator
//   {
//      UIElement Element
//      {
//         get;
//      }

//      Task PlayAsync();
//   }

//   public interface IAnimator<in T> : IAnimator
//   {
//      IAnimator<T> From( T value );
//      IAnimator<T> To( T value );
//      IAnimator<T> For( double milliseconds );
//      IAnimator<T> For( TimeSpan duration );
//      IAnimator<T> EaseIn<TEase>() where TEase : EasingFunctionBase, new();
//      IAnimator<T> EaseOut<TEase>() where TEase : EasingFunctionBase, new();
//      IAnimator<T> EaseInOut<TEase>() where TEase : EasingFunctionBase, new();
//   }

//   public class FooAnimatorBase : IAnimator<double>
//   {
//      public UIElement Element
//      {
//         get
//         {
//            throw new NotImplementedException();
//         }
//      }

//      private readonly IAnimationBuilder _builder;

//      public FooAnimatorBase( IAnimationBuilder builder, UIElement element, string propertyPath )
//      {
//         _builder = builder;
//      }

//      public IAnimator<double> From( double value )
//      {
//         throw new NotImplementedException();
//      }

//      public IAnimator<double> To( double value )
//      {
//         throw new NotImplementedException();
//      }

//      public IAnimator<double> For( double milliseconds )
//      {
//         throw new NotImplementedException();
//      }

//      public IAnimator<double> For( TimeSpan duration )
//      {
//         throw new NotImplementedException();
//      }

//      public IAnimator<double> EaseIn<TEase>() where TEase : EasingFunctionBase, new()
//      {
//         throw new NotImplementedException();
//      }

//      public IAnimator<double> EaseOut<TEase>() where TEase : EasingFunctionBase, new()
//      {
//         throw new NotImplementedException();
//      }

//      public IAnimator<double> EaseInOut<TEase>() where TEase : EasingFunctionBase, new()
//      {
//         throw new NotImplementedException();
//      }

//      public Task PlayAsync()
//      {
//         throw new NotImplementedException();
//      }
//   }
//}
