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
    ///     xmlns:MyNamespace="clr-namespace:WpfApplication1"
    ///
    ///
    /// 1b단계) 다른 프로젝트에 있는 XAML 파일에서 이 사용자 지정 컨트롤 사용.
    /// 이 XmlNamespace 특성을 사용할 마크업 파일의 루트 요소에 이 특성을 
    /// 추가합니다.
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfApplication1;assembly=WpfApplication1"
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
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    public class BuildingInfoControl : Control
    {
        static BuildingInfoControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BuildingInfoControl), new FrameworkPropertyMetadata(typeof(BuildingInfoControl)));
        }

        public static readonly DependencyProperty BuildingSourceProperty = DependencyProperty.Register("BuildingSource", typeof(ImageSource), typeof(BuildingInfoControl));
        public ImageSource BuildingSource
        {
            get { return (ImageSource)GetValue(BuildingSourceProperty); }
            set { SetValue(BuildingSourceProperty, value); }
        }

        public static readonly DependencyProperty ProgressProperty = DependencyProperty.Register("Progress", typeof(double), typeof(BuildingInfoControl));
        public double Progress
        {
            get { return (double)GetValue(ProgressProperty); }
            set { SetValue(ProgressProperty, value); }
        }

        public static readonly DependencyProperty HpProperty = DependencyProperty.Register("Hp", typeof(string), typeof(BuildingInfoControl));
        public string Hp
        {
            get { return (string)GetValue(HpProperty); }
            set { SetValue(HpProperty, value); }
        }

        public static readonly DependencyProperty DefProperty = DependencyProperty.Register("Def", typeof(string), typeof(BuildingInfoControl));
        public string Def
        {
            get { return (string)GetValue(DefProperty); }
            set { SetValue(DefProperty, value); }
        }

        public static readonly DependencyProperty GenerateProductProperty = DependencyProperty.Register("GenerateProduct", typeof(string), typeof(BuildingInfoControl));
        public string GenerateProduct
        {
            get { return (string)GetValue(GenerateProductProperty); }
            set { SetValue(GenerateProductProperty, value); }
        }
    }
}
