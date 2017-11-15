using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace Animotor
{
   public interface IAnimationBuilder
   {
      IAnimationBuilder After( double milliseconds );

      void Add( AnimationTimeline animation );

      Storyboard Build();

      IAnimator Property( Property property );
   }

   public class Property
   {
      //public static IAnimator Foreground = new ColorAnimator(  );


      private Property()
      {
      }
   }

   public struct AnimationSegment
   {
      public object From
      {
         get;
      }

      public object To
      {
         get;
      }

      public TimeSpan Duration
      {
         get;
      }
   }

   public abstract class AnimationBuilderBase : IAnimationBuilder
   {
      private readonly UIElement _element;
      private readonly Storyboard _storyboard = new Storyboard();
      private readonly List<AnimationSegment> _segments = new List<AnimationSegment>();
      private double _startTime;

      protected AnimationBuilderBase( UIElement element )
      {
         _element = element;
      }

      public IAnimationBuilder After( double milliseconds )
      {
         _startTime = milliseconds;
         return this;
      }

      public void Add( AnimationTimeline animation )
      {
         _storyboard.Children.Add( animation );
      }

      public Storyboard Build()
      {
         return _storyboard;
      }

      public IAnimator Property()
      {
         return null;
      }

      public IAnimator Property( Property property )
      {
         return null;
      }
   }

   public class SimpleAnimationBuilder : AnimationBuilderBase
   {
      public SimpleAnimationBuilder( UIElement element ) : base( element )
      {
      }
   }

   //public class SequentialAnimationBuilder : AnimationBuilderBase
   //{
   //   public SequentialAnimationBuilder( IAnimationBuilder builder ) : base()
   //   {
   //      _builder = builder;
   //   }

   //   public void Add( AnimationTimeline animation )
   //   {
   //   }

   //   public Storyboard Build()
   //   {
   //      return new Storyboard();
   //   }
   //}

   //public class ConcurrentAnimationBuilder : IAnimationBuilder
   //{
   //   private readonly IAnimationBuilder _builder;

   //   public ConcurrentAnimationBuilder( IAnimationBuilder builder )
   //   {
   //      _builder = builder;
   //   }

   //   public void Add( AnimationTimeline animation )
   //   {
   //   }

   //   public Storyboard Build()
   //   {
   //      return new Storyboard();
   //   }
   //}

   public interface IAnimator
   {
      IAnimationBuilder After( double milliseconds );
      IAnimationBuilder Then();
      IAnimationBuilder And();
      Task PlayAsync();
   }

   public class ColorAnimator : IAnimator
   {
      private readonly IAnimationBuilder _builder;

      public ColorAnimator( IAnimationBuilder builder )
      {
         _builder = builder;
      }

      public IAnimationBuilder After( double milliseconds )
      {
         _builder.After( milliseconds );
         return _builder;
      }

      public IAnimationBuilder Then()
      {
         throw new System.NotImplementedException();
      }

      public IAnimationBuilder And()
      {
         return new SimpleAnimationBuilder( null );
      }

      public Task PlayAsync()
      {
         var tcs = new TaskCompletionSource<bool>();

         var storyboard = _builder.Build();
         storyboard.Completed += ( sender, args ) => tcs.SetResult( true );
         storyboard.Begin();

         return tcs.Task;
      }
   }
}
