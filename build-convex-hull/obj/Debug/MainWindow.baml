   M S B A M L   `   `   `  ����  build-convex-hull    ConvexHull.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStyle$
  None=�5   	    � WindowState$ 	Maximized=�6    � 
ResizeMode$ NoResize=�64    � 	Resources 5         OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5	        $ 0��6'   $ 70Q�63     5
      $ 0:0:0.5��6'   $	 250Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 250Q�63     5      $ 0:0:0.5��6'   $ 70Q�69   5      5      5       � Triggers 5      :� 5   
   	 :� RoutedEvent$	 ButtonBase.Click��6   
 :� 
SourceName$
 ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5   
   $	 ButtonBase.Click��6   $
 ButtonCloseMenu��66   .[�5      �� #��[ 6   5      .��5      � .+�5   
   � $��30��6   $	��Top=�6   ���#0066cc.+�5      �� $��Convex hull��6   $��Center=�6*   $��Center=�6E   
�������$��15(�6u   �� 5       -   5          Exit#��[ 5       63   5!      � 5#   
   ���#111723$��Stretch=�6$   $��Stretch=�6B   $��	69 29 0 0q�6^   .+�5$      �� $!��Please select the algorithm��6   ���#2a3956$��Center=�6O   $��Center=�5%      $��25(�6+    � 5&      -   5          �Name$
 Main��5&        � NavigationUIVisibility$ Hidden=�6"   5'      � 5)   
   -   5         �Name$ GridMenu��5)      $��70��6!   $
��Left=�6,   ���#122d53.+�5*      �� .+�5+      � $	��150��6   ���#9B0122 J� RenderTransformOrigin$ 0.5,0.5&�69   .+�5,      �� -   5         ��Name$ ButtonOpenMenu��5,      $��60��65   $��60��6A   $��5q�6L   $��Right=�6W   $	��Top=�6s    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 5-      ���	#FF31577E��6c   Z� ��5.      Z� .��5/      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$
 Menu=�62   $��30��6>   $��30��6I   
�������6U   50      �� 51      -   5        $ ButtonCloseMenu��51      $y�	Collapsed=�66   $��60��6M   $��60��6Y   $��5q�6d   $��Right=�6o   $	��Top=�52      #��[ 65   ���	#FF31577E��53      Z� ��63   Z� .��54        $ 	ArrowLeft=�62   $��30��6C   $��30��6N   
�������6Z   55      56      �� 57      -   5         ��Name$ ListViewMenu��57      
�������$��Disabled=�6D   .@�58      �� -   5        $��60��58   #   .��59      ��  �� Orientation$ 
Horizontal=�6%   .+�5:        $ Pencil=�66   $��25��6D   $��25��6P   $��15 10q�6[   �� 5;      $��Jarvis's algorithm��6(   $��Center=�6B   $��20 10q�6]   $��15(�6l   5<      5=      �� 5>      -   5        $��60��5>   #   .��5?      �� $ 
Horizontal=�6%   .+�5@        $ AccessPoint=�66   $��25��6I   $��25��6U   $��15 10q�6`   �� 5A      $��Graham's algorithm��6(   $��Center=�6B   $��20 10q�6^   $��15(�6m   5B      5C      5D      5E      5F      5G      5H      