   M S B A M L   `   `   `  ����M  IMyProjectXMLDSM_vs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MyProjectXMLDSM_vsMyProjectXMLDSM_vs  5   	   M+clr-namespace:MyProjectXMLDSM_vs.ModelViewsMyProjectXMLDSM_vs.ModelViews  5   	   #    MyProjectXMLDSM_vs.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:MyProjectXMLDSM_vs     5   	   :vm+clr-namespace:MyProjectXMLDSM_vs.ModelViews     5   	     � 
ResizeMode$  NoResize=�5	   	    � Title$ 
ZplManager��5
   	   $	��650��6   $
��1000��6)    � DataContext 5      6   0MyProjectXMLDSM_vs.ModelViews.NavigatorModelView  5   
   .��5      �  � ShowGridLines$ False��6    � ColumnDefinitions 5   
   �� 5      $
��150* �6   6.   �� 5      $
��850* �6   6.    � RowDefinitions 5   
   �� 5      $	��20* �6   6+   �� 5      $
��300* �6   6,   .+�5   
   � $��1��6   $��0��6   
�������$��0,0,0,95q�6D   $��2��6V   .+�5      ��  �� Orientation$ Vertical=�6   .+�5      �� $��Printing��6   $	��100��6P   $��8q�6\   $��Impact)�6g   $��Center=�6{   $��48��6�    � Cursor$
 Hand��6�   ��6,   �� *ICitem01Command+��5      �� 5        �� 
TargetType" ��6*   .R�5!      �� #��z��6%   #��z��6O   #��z��5"   %   	 �� CornerRadius$	 10��6Y   ._�5#   "   �� $��Center=�63   $��Center=�6P   5$      5%      5'      �� 5)      $��	Preparing��6   $	��100��6Q   $��8q�6]   $��Impact)�6h   $��48��6|   $
 Hand��6�   ��6-   �� *ICitem02Command+��5*      �� 5+      " ��6*   .R�5,      �� #��z��6%   #��z��6O   #��z��5-   %   $	 10��6Y   ._�5.   "   �� $��Center=�63   $��Center=�6P   5/      50      52      �� 53      $��Setting��6   $	��100��6O   $��8q�6\   $��Impact)�6g   $��47��6{   $
 Hand��6�   ��6+   �� *ICitem03Command+��54      �� 55      " ��6*   .R�56      �� #��z��6%   #��z��6O   #��z��57   %   $	 10��6Y   ._�58   "   �� $��Center=�63   $��Center=�6P   59      5:      5<      5=      5K      � 5M   
   $��1��6   $��1��6   
�������$��0,0,0,34q�6D   .+�5N      �� -   5        
 ��Name$
 ICitem01��5N      $��5,5,5,5q�6S   ��6/   �� *SelectViewModel+6S   5O      5P      5Q      