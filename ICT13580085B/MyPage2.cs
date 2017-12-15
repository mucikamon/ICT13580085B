using System;

using Xamarin.Forms;

namespace ICT13580085B
{
    public class MyPage2 : ContentPage
    {
        public MyPage2()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

