   M S B A M L   `   `   `  ���� F  BPC__Cleaner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PC__CleanerPC__Cleaner      PC__Cleaner.Page1   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     +localclr-namespace:PC__Cleaner       N� Title$  Page1�� � 	Resources    CardButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius � RowDefinitions
 � Tag	 �� Triggers
 P� Property P� Value3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Color   
BlurRadius  ProgressBar.Progress �� Color  ProgressBar.Background  ProgressBar.Border  ProgressBarStyle1 �Name'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard g� RepeatBehavior �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value8  2System.Windows.Media.Animation.EasingPointKeyFrame $� KeyTime $� Value ��Name �� RadiusX �� RadiusY J� RenderTransformOrigin �� 
TargetName  �� Angle��%�  &	        7F�&	     &	     &	 /    &	 D    7  7  7  �� " ��.���  � �� �#1abc9c��  � ��
 �������  � ��$	 270����  � ��$	 250����  � ��$ 0q���  � �� �� " ��.R��� $ 10��#��z��#��z��#��z��._�� $��	0,80,0,40q� �� �� .+�F� $��70��#��z #��z��8��  �� $��1��$��Center=�$��Center=�#��z��	 P� 
 �@J�IsMouseOver . . ���  � ��
 �������  � ��$ 3q���  � �� �#1abc9c��  � �� �#1abc9c��  �@J�Effect   $ 1Q�$ #bfe6fd��$ 20Q��� $ 	#FF06B025���� $ 	#FFE6E6E6���� $ 	#FFBCBCBC���� " �.���  � ��8   ��  � ��8  ��  � ��8  ��  � ��$ 1q���  � �� �� " �.R�� $ TemplateRoot��   CommonStates��.   Determinate��  Indeterminate��. �� $ Forever��.��U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�$ 	Animation��.\�  $ 0��$
 0.25Q�  $ 0:0:1��$
 0.25Q�  $ 0:0:2��$
 0.25Q�*� $' !(UIElement.RenderTransformOrigin)�$ 	Animation��.'�  $ 0��$ -0.5,0.5&�  $ 0:0:1��$ 0.5,0.5&�  $ 0:0:2��$ 1.5,0.5&�.+��� #��z��$ 2��#��z��#��z���� $ 
PART_Track��� $ PART_Indicator��}�. $
��Left=�.+��� $ 	Indicator��$ 2��$ 2��#��z���� $ 	Animation��$ 2��$ 2��#��z��$ 0.5,0.5&�z�V� .~��� �� �� T� 	 P� 
 �@�Orientation$ Vertical=�. ��� $ TemplateRoot�� �@�LayoutTransform �� $	  -90Q�P� 
 �@�IsIndeterminate . . ��� $ 	Indicator�� � y�$ 	Collapsed=�.��� $��1�����#E1E4E6 �� $
��1.7* ��� $��3* ��� .+�� ! � ColumnDefinitions! �� �� $	��300 �.+��� $��60,0,0,0q�$��Center=�$
��Left=�.+��� $��27(����#1abc9c$!��Analyser du PC nécessaire ��$��0,0,0,25q��� $��19(����#1abc9c�� $��SemiBold"�.�Espase à nettoyer : �� -   " ��Name$" analyseResult��$��17(�.�À déterminer par analyser�� $��19(����#1abc9c�� $��SemiBold"�.�Dérniére analyse : �� -   $
" date��$��17(�.�
08.06.2020�� $��19(����#1abc9c�� $��SemiBold"�.�Dérniére MAJ : �� $��17(�.�
08.06.2020� -   # �Name$	# bar��$��7�����#1abc9c���#1abc9c$y�Hidden=�#���  �� -   $ ��Name$$ analysetext��$��19(����#1abc9c�� -   $��1��$��
40,40,40,0q�$��15(�$��Center=�$��ANALYSER��$��50�� ��%e  '��       �� " ��.���  � ��
 ���� ��  � �� �#1abc9c��  � ��$ 4q���  � �� �#1abc9c��  � �� �� " ��.R��� $ 10��#��z��#��z��#��z��._��� $��1��$��Center=�$��Center=�#��z��	 P� 
 �@J�IsMouseOver . . ���  � �� �#1abc9c��  � ��
 �������  � �� �#1abc9c�� $��Bottom=�$��Center=�$	��600�����#1abc9c� $��1��! �� �� �� .+��� -   #��[  $��20(�$��Right=�$��NETTOYER�� 	 broom# [ �� -   $��1��#��[  $��20(�$��
HISTORIQUE��  history# [ �� -   $��2��#��[  $��20(�$
��Left=�$��MISE À JOUR��  maj# [ �� $��1��$��Bottom=�$��Center=�$	��600�����#1abc9c�� $��	60,50,0,0q�$��2��$��19(����#1abc9c$O��IPC-CLEANER est un logiciel made in Youcode qui respecte votre vie privée��