   M S B A M L   `   `   `  ����I  EcleanerUpdater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:cleanerUpdatercleanerUpdater  5   	       cleanerUpdater.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:cleanerUpdater     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	     � Title$  
MainWindow��5	   	   $	��340��6   $	��270��6)    � 
ResizeMode$ NoResize=�5
   	    � WindowState$ Normal=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   
������ 
������  � Icon$ /assets/broom.png��5   	   .��5      �� ���#1E77C7._�5   
   �  � RowDefinitions 5      �� 5      $
��1.5* �6    �� 5      �� 5      .+�5      � $��Center=�6    � ColumnDefinitions 5      �� 5"      �� 5$      .+�5(      �� $��Right=�6   $��50��65   $��/assets/broom.png��6@   �� 5*      $��1��5+      $��24(�5,      
�������$��
PC-CLEANER��5.      $
��Left=�5/      $��Center=�50      51      "  FontAwesome.WPF.ImageAwesome  53      $��1��6   $��57��6+      Icon$ Spinner=�66   	   
Foreground
	 �����
   Spin
 .    SpinDuration$	 1.4Q�6e   �� 55      $��2��6   $��Updating...��6%   $��24(�68   
�������$��Center=�6Y   $��14q�6v   59      5<      5=      