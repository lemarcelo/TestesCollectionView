using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TesteCollectionView.Behaviors
{
    public class ItemSelectedBehaviors : Behavior<CollectionView>
    {
        public static BindableProperty CommandProperty = 
            BindableProperty.Create(
                propertyName:"Command", 
                returnType: typeof(ICommand), 
                declaringType: typeof
                (ItemSelectedBehaviors));


        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        protected override void OnAttachedTo(CollectionView CollectionBindable)
        {
            base.OnAttachedTo(CollectionBindable);
            CollectionBindable.SelectionChanged += BindableOnSelectedItem;
            CollectionBindable.BindingContextChanged += CollectionBindable_BindingContextChanged;
        }

        private void CollectionBindable_BindingContextChanged(object sender, EventArgs e)
        {
            var cv = sender as CollectionView;
            BindingContext = cv?.BindingContext;
        }

        protected override void OnDetachingFrom(CollectionView CollectionBindable)
        {
            base.OnDetachingFrom(CollectionBindable);
            CollectionBindable.SelectionChanged -= BindableOnSelectedItem;
            CollectionBindable.BindingContextChanged -= CollectionBindable_BindingContextChanged;
        }

        private void BindableOnSelectedItem(object sender, SelectionChangedEventArgs e)
        {

            Command.Execute(null);
            
        }
    }
}
