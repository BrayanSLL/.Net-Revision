   M S B A M L   `   `   `  ����>  :Tp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Tp3Tp3  5   	       Tp3.Diaporama   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:Tp3     5   	   -   5          � Title$  	Diaporama��5   	   $	��450��6   $	��800��6(    � 	Resources 5	         VisibleToInvisible �� 
TargetName �� TargetProperty	 W� To g� Duration  InvisibleToVisible  VisibleToInvisible2  InvisibleToVisible2��%P  &	        &	 �     &	 �    &	 d    �� 5
   
   -   5        .��5      W� $ TransparentStop��6   $ Offset�6F    06i   $ 0:0:2D�6p   W� 5      $ 	BlackStop��6   $ Offset�6@    06c   $ 0:0:2D�6j   5      �� 5   
   -   5        .��5      W� $ TransparentStop��6   $ Offset�6F    16i   $ 0:0:2D�6p   W� 5      $ 	BlackStop��6   $ Offset�6@    16c   $ 0:0:2D�6j   5      �� 5   
   .��5      W� $ TransparentStop2��6   $ Offset�6G    16j   $ 0:0:2D�6q   W� 5      $ 
BlackStop2��6   $ Offset�6A    16d   $ 0:0:2D�6k   5      �� 5   
   .��5      W� $ TransparentStop2��6   $ Offset�6G    06j   $ 0:0:2D�6q   W� 5      $ 
BlackStop2��6   $ Offset�6A    06d   $ 0:0:2D�6k   5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   [�5      �� 5       #��[  6"   �� 5!      #��[ 6"   5#      .��5&      � .+�5'   
   �� -   5         ��Name$ Image2��5'      	 J� OpacityMask	 5(      �� 5)      
 �� 
StartPoint$	
 1,0&�6&    �� EndPoint$	 0,0&�67   .��5*      �  � Offset$ 0Q�6#    � Color$ Black��6.   -   5        
BlackStop2��5*   <   � 5+      $ 0Q�6#   $ Transparent��6.   -   5        TransparentStop2��5+   B   5,      5.      �� 5/   
   -   5        $ Image1��5/      	 50      �� 51      $	
 0,0&�6&   $	 1,0&�67   .��52      � $ 1Q�6#   $ Black��6.   -   5        	BlackStop��52   <   � 53      $ 1Q�6#   $ Transparent��6.   -	   5        TransparentStop��53   B   54      56      58      59      