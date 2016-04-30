//using System;
//using System.Linq.Expressions;
//using System.Reflection;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Media.Animation;

//namespace Animotor
//{
//   public abstract class AnimatorBase<T> : IAnimator<T>
//   {
//      public UIElement Element
//      {
//         get;
//      }

//      protected DependencyProperty DependencyProperty
//      {
//         get;
//      }

//      protected string PropertyPath
//      {
//         get;
//      }

//      protected T FromValue
//      {
//         get;
//         set;
//      }

//      protected T ToValue
//      {
//         get;
//         set;
//      }

//      protected TimeSpan ForValue
//      {
//         get;
//         set;
//      }

//      protected EasingFunctionBase EasingValue
//      {
//         get;
//         set;
//      }

//      private AnimatorBase( UIElement element )
//      {
//         Element = element;
//      }

//      protected AnimatorBase( UIElement element, DependencyProperty dependencyProperty ) : this( element )
//      {
//         DependencyProperty = dependencyProperty;
//      }

//      protected AnimatorBase( UIElement element, string propertyPath ) : this( element )
//      {
//         PropertyPath = propertyPath;
//      }

//      protected IAnimator<T> Set<U>( Expression<Func<U>> property, U value )
//      {
//         var propertyExpression = property.Body as MemberExpression;

//         if ( propertyExpression != null )
//         {
//            var propertyInfo = (PropertyInfo) propertyExpression.Member;
//            propertyInfo.SetValue( this, value );
//         }

//         return this;
//      }

//      public IAnimator<T> From( T value ) => Set( () => FromValue, value );
//      public IAnimator<T> To( T value ) => Set( () => ToValue, value );
//      public IAnimator<T> For( double milliseconds ) => Set( () => ForValue, TimeSpan.FromMilliseconds( milliseconds ) );
//      public IAnimator<T> For( TimeSpan duration ) => Set( () => ForValue, duration );

//      public IAnimator<T> EaseIn<TEase>() where TEase : EasingFunctionBase, new() => SetEasing<TEase>( EasingMode.EaseIn );
//      public IAnimator<T> EaseOut<TEase>() where TEase : EasingFunctionBase, new() => SetEasing<TEase>( EasingMode.EaseOut );
//      public IAnimator<T> EaseInOut<TEase>() where TEase : EasingFunctionBase, new() => SetEasing<TEase>( EasingMode.EaseInOut );

//      private IAnimator<T> SetEasing<TEase>( EasingMode easingMode ) where TEase : EasingFunctionBase, new()
//      {
//         return Set( () => EasingValue, new TEase
//         {
//            EasingMode = easingMode
//         } );
//      }

//      protected abstract AnimationTimeline GetAnimation();

//      public virtual Task PlayAsync()
//      {
//         var tcs = new TaskCompletionSource<bool>();

//         var animation = GetAnimation();
//         animation.Duration = new Duration( ForValue );
//         animation.Completed += ( sender, e ) => tcs.SetResult( true );

//         var storyboard = new Storyboard();
//         storyboard.Children.Add( animation );
//         Storyboard.SetTarget( animation, Element );
//         Storyboard.SetTargetProperty( animation, new PropertyPath( PropertyPath ) );
//         storyboard.Begin();

//         return tcs.Task;
//      }
//   }
//}
