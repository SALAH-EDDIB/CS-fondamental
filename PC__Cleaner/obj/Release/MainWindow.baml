   M S B A M L   `   `   `  ���� F  BPC__Cleaner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PC__CleanerPC__Cleaner      PC__Cleaner.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:PC__Cleaner       � Icon$  /assets/broom.png�� � Title$ 
DotCleaner��$	��600��$	��760��$
��1300��$
��1100�� � 	Resources    MenuButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius � ColumnDefinitions
	 � Tag
 �� Triggers P� Property P� Value  CardButtonStyle � RowDefinitions3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Color   
BlurRadius�� %�  &	        7F�&	 �    7F��� " d�.���  � ��
 �������  � ��
 �������  � ��$ Center=���  � ��$ 50����  � ��$ 14(���  � ��$ 	20,0,-2,0q���  � �� �� " d�.R��� $ 	10,0,0,10��#��z��#��z��._��  �� $��55 ��� .+�F� $��18��#��z	 #��z��8��  �� $��1��$
��Left=�$��Center=�#��z��
 P�  �@d�	IsChecked$
 TrueY�. ���  � �� �#E1E4E6��  � �� �#1abc9c��  � ��$ SemiBold"��� " ��.���  � �� �#1abc9c��  � ��
 �������  � ��$	 270����  � ��$	 250����  � ��$ 0q���  � �� �� " ��.R��� $ 10��#��z��#��z��#��z��._�� $��	0,80,0,40q� �� �� .+�F� $��70��#��z	 #��z��8��  �� $��1��$��Center=�$��Center=�#��z��
 P�  �@J�IsMouseOver . . ���  � ��
 �������  � ��$ 3q���  � �� �#1abc9c��  � �� �#1abc9c��  �@J�Effect   $ 1Q�$ #bfe6fd��$ 20Q�.��� 
������� �� $	��250 ��� .+��  �� $	��200���� $
��auto ��� .+��  �� $��80 ��� .+��� $��Right=�$��50��$��/assets/broom.png���� $��1��$��24(����#1abc9c$��
PC-CLEANER��$
��Left=�$��Center=��� $��Bottom=�$	��200�����#1abc9c�� $��1��$
��0,50q�.+�	� -    	�Name$	 btn��#��[  $��VUE D'ENSEMBLE�� 
 screen#	 [ 	� -   #��[  $��ANALYSER�� 
 search#	 [ 	� -   $
 btn2��#��[  $��
HISTORIQUE�� 
 recent#	 [ 	� #��[  $��OPTIONS��  settings#	 [ �� $��2��$��25,40q�$��Bottom=�$��15(�$��SITE WEB��$��50�� ��%I  '��       �� " ��.���  � �� �#1abc9c��  � ��
 �������  � �� �#1abc9c��  � �� �� " ��.R��� $ 10��#��z��#��z��#��z��._��� $��1��$��Center=�$��Center=�#��z��
 P�  �@J�IsMouseOver . . ���  � ��
 ���� ��  � �� �#1abc9c��  � ��$ 4q� � -     �Name$ frame��$��1��  � NavigationUIVisibility$ Hidden=�