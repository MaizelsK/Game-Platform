using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Game_Platform.Helpers
{
    public static class NotifyPropertyChangedExtension
    {
        public static void Mutateverbose<T>(this INotifyPropertyChanged instance, ref T field, T newValue,
            Action<PropertyChangedEventArgs> raise, [CallerMemberName]string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, newValue))
                return;

            field = newValue;
            raise?.Invoke(new PropertyChangedEventArgs(propertyName));
        }
    }
}
