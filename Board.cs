using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prototype.Library
{
    /// <summary>
    /// XAML 파일에서 이 사용자 지정 컨트롤을 사용하려면 1a 또는 1b단계를 수행한 다음 2단계를 수행하십시오.
    ///
    /// 1a단계) 현재 프로젝트에 있는 XAML 파일에서 이 사용자 지정 컨트롤 사용.
    /// 이 XmlNamespace 특성을 사용할 마크업 파일의 루트 요소에 이 특성을 
    /// 추가합니다.
    ///
    ///     xmlns:MyNamespace="clr-namespace:Prototype"
    ///
    ///
    /// 1b단계) 다른 프로젝트에 있는 XAML 파일에서 이 사용자 지정 컨트롤 사용.
    /// 이 XmlNamespace 특성을 사용할 마크업 파일의 루트 요소에 이 특성을 
    /// 추가합니다.
    ///
    ///     xmlns:MyNamespace="clr-namespace:Prototype;assembly=Prototype"
    ///
    /// 또한 XAML 파일이 있는 프로젝트의 프로젝트 참조를 이 프로젝트에 추가하고
    /// 다시 빌드하여 컴파일 오류를 방지해야 합니다.
    ///
    ///     솔루션 탐색기에서 대상 프로젝트를 마우스 오른쪽 단추로 클릭하고
    ///     [참조 추가]->[프로젝트]를 차례로 클릭한 다음 이 프로젝트를 찾아서 선택합니다.
    ///
    ///
    /// 2단계)
    /// 계속 진행하여 XAML 파일에서 컨트롤을 사용합니다.
    ///
    ///     <MyNamespace:Board/>
    ///
    /// </summary>
    public class Board : Control
    {
        static Board()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Board), new FrameworkPropertyMetadata(typeof(Board)));
        }
        /// <summary>
        /// Building Image Source
        /// </summary>
        public static readonly DependencyProperty BuildingSourceProperty =
            DependencyProperty.Register("BuildingSource", typeof(ImageSource), typeof(Board));
        public ImageSource BuildingSource
        {
            get { return (ImageSource)GetValue(BuildingSourceProperty); }
            set { SetValue(BuildingSourceProperty, value); }
        }

        /// <summary>
        /// Unit Image Source
        /// </summary>
        public static readonly DependencyProperty UnitSourceProperty =
            DependencyProperty.Register("UnitSource", typeof(ImageSource), typeof(Board));
        public ImageSource UnitSource
        {
            get { return (ImageSource)GetValue(UnitSourceProperty); }
            set { SetValue(UnitSourceProperty, value); }
        }
        /// <summary>
        /// Background ImageSource
        /// </summary>
        public static readonly DependencyProperty BackgroundSourceProperty =
            DependencyProperty.Register("BackgroundSource", typeof(ImageSource), typeof(Board));
        public ImageSource BackgroundSource
        {
            get { return (ImageSource)GetValue(BackgroundSourceProperty); }
            set { SetValue(BackgroundSourceProperty, value); }
        }

        public static readonly DependencyProperty BuildingNameProperty =
            DependencyProperty.Register("BuildingName", typeof(string), typeof(Board));
        public string BuildingName
        {
            get { return (string)GetValue(BuildingNameProperty); }
            set { SetValue(BuildingNameProperty, value); }
        }

        public static readonly DependencyProperty UnitNameProperty =
            DependencyProperty.Register("UnitName", typeof(string), typeof(Board));
        public string UnitName
        {
            get { return (string)GetValue(UnitNameProperty); }
            set { SetValue(UnitNameProperty, value); }
        }

        /// <summary>
        /// Control의 위치
        /// </summary>
        public string Position { get; set; }
    }
}
