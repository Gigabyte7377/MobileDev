using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LabelTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var label = new Label
            {
                Text = "Тестовый проект с Label",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.Blue
            };
            this.Content = label;

            // установка цвета фона страницы
            //this.BackgroundColor = new Color(1.0, 1.0, 0, 1.0);

            // установка семейства шрифта и размера
            //label.FontFamily = "Times New Roman";
            //label.FontSize = 20;

            // установка полужирного курсива
            //label.FontAttributes = FontAttributes.Bold | FontAttributes.Italic;

            //большой блок текста в метке
            label.Text = "Alice was beginning to get very tired of sitting by " +
                         "her sister on the bank, and of having nothing to do: " +
                         "once or twice she had peeped into the book her sister " +
                         "was reading, but it had no pictures or conversations " +
                         "in it, “and what is the use of a book,” thought Alice, " +
                         "“without pictures or conversations?”";

            //свойство переноса установлено в режим обрезки начала и конца текста
            //label.LineBreakMode = LineBreakMode.MiddleTruncation;

            //выравнивание текста по центру
            //label.HorizontalTextAlignment = TextAlignment.Center;
            //выравнивание текста по правому краю
            //label.HorizontalTextAlignment = TextAlignment.End;

            //настройка положения по свойствам унаследованным от VisualElement
            //label.TranslationX = 30;
            //label.TranslationY = 30;

            //масштабирование
            //label.Scale = 2.0;

            //вращение
            //label.Rotation = -45;

            //анимация
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                label.Rotation = 0;
                await label.RotateTo(90, 3000);
            };
            //добавляем анимацию к метке
            label.GestureRecognizers.Add(tap);
        }
    }
}
