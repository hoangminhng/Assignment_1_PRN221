   M S B A M L   `   `   `  ����M  IWpfHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfHotelManagementWpfHotelManagement  5      (    "WpfHotelManagement.AdminManageRoom   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:WpfHotelManagement     5      $	��450��5      $	��800��6   .��5	      � .+�5
   
   �� .+�5      �� -   5        $��lblInstruction��5      
���**��$��DemiBold"�6=   $��Center=�6S   $��20(�5      $��Manage Room Information��6"   &   System.Windows.Controls.DataGrid  5      -   5        $��dgRooms��5          AutoGenerateColumns$  False��6&   $��10q�6B   $��1��5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Room ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *RoomId+  5      $ Room number��6)    6>   �� *
RoomNumber+  5      $ Detail Description��6)    6E   �� *RoomDetailDescription+ �� Mode$ TwoWay=�  5      $ Max Capacity��6)    6?   �� *RoomMaxCapacity+  5      $ Status��6)    69   �� *
RoomStatus+  5      $ Price Per Day��6)    6@   �� *RoomPricePerDay+  5      $ 	Room Type��6)    6<   �� *RoomTypeName+5      �� 5       �� Orientation$ Vertical=�6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��Room ID��6   $	��100��6.   �� 5      -   5        $��	txtRoomId��5      $
��Left=�6/   $��25��5      $	��300��6*    �� 
IsReadOnly$
 True��66   5       �� 5!      $ 
Horizontal=�6   .+�5"      �� $��Room Number��6   $	��100��62   �� 5#      -   5        $��txtRoomNumber��5#      $
��Left=�63   $��25��5$      $	��300��6*   66   5%      �� 5&      $ 
Horizontal=�6   .+�5'      �� $��Description��6   $	��100��62   �� 5(      -   5        $��txtDetailDescription��5(      $
��Left=�6:   $��25��5)      $	��300��6*   5*      �� 5+      $ 
Horizontal=�6   .+�5,      �� $��Capacity��6   $	��100��6/   �� 5-      -   5        $��txtMaxCapacity��5-      $
��Left=�64   $��25��5.      $	��300��6*   66   5/      �� 50      $ 
Horizontal=�6   .+�51      �� $��Status��6   $	��100��6-   �� 52      -   5        $��cbRoomStatus��52      $	��300��63   .@�53      ��  �� 
IsSelected$
 True��6'   .��69   	Available6D   �� 54      .��6'   Unavailable64   55      56      �� 57      $ 
Horizontal=�6   .+�58      �� $��Price��6   $	��100��6,   �� 59      -   5        $��txtPricePerDay��59      $
��Left=�64   $��25��5:      $	��300��6*   66   5;      �� 5<      $ 
Horizontal=�6   .+�5=      �� $��	Room Type��6   $	��100��60   �� 5>      -	   5        $��
cbRoomType��5>      $	��300��61   5?      5@      �� 5B      $ 
Horizontal=�6   .+�5C      �� -
   5        $��	btnCreate��5C      $��10q�6*   $��80��66   $��Create��6A   6R   �� 5D      -   5        $��	btnUpdate��5D      $��10q�6*   $��80��66   $��Update��6A   6R   �� 5E      -   5        $��	btnDelete��5E      $��10q�6*   $��80��66   $��Delete��6A   6R   5F      5G      5H      5I      