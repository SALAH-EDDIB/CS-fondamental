   M S B A M L   `   `   `  ����I  EfileManagerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:fileManagerApp.CControlsfileManagerApp.CControls  5      *    $fileManagerApp.CControls.CardControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:fileManagerApp.CControls     5      -   5          >�Name$  _CardControl��5      $��15(�5
       � 	Resources 5         CardButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding �� CornerRadius � RowDefinitions	 � ColumnDefinitions
 A�Name J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   	Direction   ShadowDepth   Color   
BlurRadius j� Stretch �� ImageSource �� ElementName �� TargetNullValue �� FallbackValue �Name � Value  ProgressBarStyle1 �� Orientation F�Name 
 recent ��Name �� Triggers P� Property P� Value �� 
TargetName  ProgressBar.Progress �� Color  ProgressBar.Background  ProgressBar.Border �Name'  !System.Windows.VisualStateManager    VisualStateGroups%  System.Windows.VisualStateGroup!   States   System.Windows.VisualState"   
Storyboard# g� RepeatBehavior$ �� TargetProperty% �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame& O� KeyTime' O� Value8  2System.Windows.Media.Animation.EasingPointKeyFrame( $� KeyTime) $� Value* ��Name+ �� RadiusX, �� RadiusY- J� RenderTransformOrigin. �� Angle��%�  &	        7  7F�&	 7	    &	 Z	    &	 }	    &	 �	    7  7  7  �� 5   
   " d�6(   .�5      ��  � ��
 �����6+   �� 5       � ��$	 200��6'   �� 5       � ��$	 290��6&   �� 5       � ��$ 0q�60   �� 5       � �� 5      �� 5      " d�6&   .R�5      �� $ 25q�6!   $ 10��6.   #��z��6@   #��z��6j   #��z��6�   ._�5      �  5    "   �� 5!   &   $��80 �64   �� 5"   &   $
��auto �64   �� 5#   &   $��30 �64   .+�5&   "   � 	 5(   &   �� 5)   *   $��60 �6;   �� 5*   *   .+�5-   &   A� $

 logo��6R   $��50��6.   $��50��69   
������� 5.   *     5/   .   $	 320Q�6?   $ 2Q�6O   $ Silver��6_   $ 10Q�6n   51   '   A� 53   &   $��25��6.   $��25��69   ��55   *   �� 56   .   $ Uniform=�6�    69   �� *ImageSource+$ _CardControl��$ /assets/googledrive.png��$ /assets/googledrive.png��6�   59   '   �� 5=   &   $
��15,0q�60   $��1��6?   $��Center=�6O   $
��Left=�6j   �� 5>   *   �6/   �� *	DriveName+$ _CardControl��$ 
Drive Name��$ 
Drive Name���� 5?   *   �� 5@   *   $��12(�64   #��z��6B   .�6m   .�5A   *   �� $�Open folder��6.   5B   +   5D   '   5E   #   � 5G   "   $��1��6'   .+�5I   &   �� .+�5L   *   � $	��0,5q�6/   .+�5N   .   �� $
��70GB��68   �� 5P   .   $��100GB��68   $��Right=�6E   5R   +   � 5S   *   $ ProgressBar��66   $��5��6K   
�������
����� �$ 70Q�6}   #���  6�   6�   5T   '   5W   #   � 5Y   "   $��3��6'   .+�5Z   &   �� $ 
Horizontal=�61   $��Bottom=�6J   .+�5\   *   F� $ recent��6/   8��  8�� 6^   �� 5]   *   $ Recent��64   $	��5,0q�6E   
���������6d   �� *
Lastchange+$ _CardControl��$ last change��5_   '   5b   #   5f      5j       5l      P� 5n       �@d�	IsChecked$
 TrueY�6;   . �5p   "   ��  � ��
 ��� �6?   �� 5q   "    � ��$ 3q�6D   �� 5r   "    � ��
 �����6@   �� 5s   "    � ��
 �����6?   �� 5t   "   $ ProgressBar��6)    � �� �#FFC1076X   �� 5u   "   $ recent��6)    � ��
 �����6M   �� 5v   "   $ Recent��6)    � ��
 �����6S   �� 5y   "   $
 logo��6)    6M   Z�  �@J�Effect�� 5z   "    �@J�Effect 5|   &     5}   *   $ 1Q�6<   $ #bfe6fd��6L   $ 20Q�6\   5�   #   5�      5�      5�      5�      �� 5�   
   $ 	#FF06B025��67   �� 5�   
   $ 	#FFE6E6E6��69   �� 5�   
   $ 	#FFBCBCBC��65   �� 5�   
   " �6*   .�5�      ��  � ��8   6+   �� 5�       � ��8  6+   �� 5�       � ��8  6,   �� 5�       � ��$ 1q�60   �� 5�       � �� 5�      �� 5�      " �6&   .R�5�      � $ TemplateRoot��6     5�        5�   "   CommonStates��.! 5�   &     Determinate��62     5�   &   Indeterminate��." 5�   *   �� $# Forever��65   .��5�   .   U� $V$ P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6L   $% 	Animation��6�   .\�5�   2     $& 0��6G   $
' 0.25Q�6S     5�   2   $& 0:0:1��6G   $
' 0.25Q�6W     5�   2   $& 0:0:2��6G   $
' 0.25Q�6W   5�   /   *� 5�   .   $'$ !(UIElement.RenderTransformOrigin)�6K   $% 	Animation��6�   .'�5�   2     $( 0��6F   $) -0.5,0.5&�6R     5�   2   $( 0:0:1��6F   $) 0.5,0.5&�6V     5�   2   $( 0:0:2��6F   $) 1.5,0.5&�6V   5�   /   5�   +   5�   '   5�   #   .+�5�      �� #��z��6%   $ 2��6Q   #��z��6b   #��z��6�   �� 5�      $* 
PART_Track��6(   � 5�      $ PART_Indicator��6#   }�. $
��Left=�6O   .+�5�   "   �� $* 	Indicator��6,   #��z��6?   $+ 2��6c   $, 2��6o   �� 5�   "   $* 	Animation��6,   #��z��6?   $+ 2��6c   $, 2��6o   $- 0.5,0.5&�6{   z�5�   &   V� 5�   *   .~�5�   .   �� �� 5�   .   �� 5�   .   T� 5�   .   5�   +   5�   #   5�      5�       5�      P� 5�       �@�Orientation$ Vertical=�6=   . �5�   "   �� $ TemplateRoot��6D    �@�LayoutTransform 5�   &   �� 5�   *   $	. -90Q�6:   5�   #   5�      P� 5�       �@�IsIndeterminate . . �5�   "   �� $ 	Indicator��6?    � y�$ 	Collapsed=�6V   5�      5�      5�      5�      5�      .��5�      	� #��[  6   / 	� 	GroupName$
/ Card��6<   0 d� 	IsChecked0 6N   �� *	IsChecked+$ _CardControl��5�      