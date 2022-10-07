using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PDC60_MOD04
{
    public class NumericValidationBehavior: Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextchanged;
            base.OnAttachedTo(entry);   
        }
        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextchanged;
            base.OnDetachingFrom(entry);
        }
        void OnEntryTextchanged(object sender, TextChangedEventArgs args)
        {
            double result;
            bool isValid = double.TryParse(args.NewTextValue, out result);
            ((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;


        }
    }
}
