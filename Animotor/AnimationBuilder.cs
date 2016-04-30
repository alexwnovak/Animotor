//using System.Windows;

//namespace Animotor
//{
//   public interface IAnimationBuilder
//   {
//      void Build();
//   }
//   public class CompositeAnimationBuilder : IAnimationBuilder
//   {
//      public void Build()
//      {
//      }
//      //private readonly List
//   }


//   public class AnimationBuilder : IAnimationBuilder
//   {
//      private readonly UIElement _element;
//      private readonly IAnimator _parent;

//      public FooAnimatorBase Foo() => new FooAnimatorBase( this, _element, "Opacity" );
//      //public DoubleAnimator Opacity() => new DoubleAnimator( _element, "Opacity" );
//      //public ColorAnimator Foreground() => new ColorAnimator( _element, "Foreground.Color" );
//      //public ColorAnimator Background() => new ColorAnimator( _element, "Background.Color" );
//      //public DoubleAnimator FontSize() => new DoubleAnimator( _element, "FontSize" );
//      //public DoubleAnimator Width() => new DoubleAnimator( _element, "Width" );
//      //public DoubleAnimator Height() => new DoubleAnimator( _element, "Height" );

//      public AnimationBuilder( UIElement element )
//      {
//         _element = element;
//      }

//      public AnimationBuilder( IAnimator previous )
//      {
//         _parent = previous;
//         _element = previous.Element;
//      }

//      public void Build()
//      {
//      }
//   }
//}
