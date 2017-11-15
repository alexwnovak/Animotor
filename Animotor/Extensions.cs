using System.Windows;

namespace Animotor
{
   public static class Extensions
   {
      public static IAnimationBuilder Animate( this UIElement element, Property property )
      {
         return new SimpleAnimationBuilder( element );
      }
   }
}
