   M S B A M L   `   `   `  ����M  IWpfHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfHotelManagementWpfHotelManagement  5      0    *WpfHotelManagement.AdminManageCustomerInfo   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:WpfHotelManagement     5      $	��450��5      $	��800��6   .��5	      � .+�5
   
   �� .+�5      �� -   5        $��lblInstruction��5      
���**��$��DemiBold"�6=   $��Center=�6S   $��20(�5      $��Manage Customer��6"   &   System.Windows.Controls.DataGrid  5      -   5        $��dgCustomers��5          AutoGenerateColumns$  False��6*   $��10q�6h   $��1��5      ��5   F   �� *	Customers+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Customer ID��6)      
IsReadOnly$
 True��6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *
CustomerId+6]     5      $ 	Full Name��6)    6<   �� *CustomerFullName+  5      $ 	Telephone��6)    6<   �� *	Telephone+  5      $ Email��6)    68   �� *EmailAddress+  5      $ Date of birth��6)    6@   �� *CustomerBirthday+  5      $ Status��6)    69   �� *CustomerStatus+5      �� 5       �� Orientation$ Vertical=�6   .+�5      �� $ 
Horizontal=�6   .+�5      �� -   5        $��lblCustomerId��5      $��Customer ID��61   $	��100��6G   �� 5      -   5        $��txtCustomerId��5      $
��Left=�63   $��25��5      $	��300��6*    �� 
IsReadOnly$
 True��66   5      �� 5       $ 
Horizontal=�6   .+�5!      �� -   5        $��lblTelephone��5!      $��	Telephone��60   $	��100��6D   �� 5"      -   5        $��txtTelephone��5"      $
��Left=�62   $��25��5#      $	��300��6*   5$      �� 5%      $ 
Horizontal=�6   .+�5&      �� -   5        $��lblEmailAddress��5&      $��Email Address��63   $	��100��6K   �� 5'      -   5        $��txtEmailAddress��5'      $
��Left=�65   $��25��5(      $	��300��6*   5)      �� 5*      $ 
Horizontal=�6   .+�5+      �� -	   5        $��lblCustomerFullName��5+      $��	Full name��67   $	��100��6K   �� 5,      -
   5        $��txtCustomerFullName��5,      $
��Left=�69   $��25��5-      $	��300��6*   5.      �� 5/      $ 
Horizontal=�6   .+�50      �� -   5        $��lblCustomerBirthday��50      $��Birthday��67   $	��100��6J   (  "System.Windows.Controls.DatePicker  51      -   5        $��
dtBirthday��53   9   $	��300��51   !      SelectedDateFormat$
 Long=�6-      DisplayDateStart 1/01/0952   !   	   DisplayDateEnd	 12/31/096<   
   FirstDayOfWeek$
 Monday=�53   !   69   54      �� 55      $ 
Horizontal=�6   .+�56      �� -   5        $��lblPassword��56      $��Password��6/   $	��100��6B   �� 57      -   5        $��txtPassword��57      $
��Left=�61   $��25��58      $	��300��6*   59      5:      �� 5<      $ 
Horizontal=�6   .+�5=      �� -   5        $��	btnCreate��5=      $��10q�6*   $��80��66   $��Create��6A   6R   �� 5>      -   5        $��	btnUpdate��5>      $��10q�6*   $��80��66   $��Update��6A   6R   �� 5?      -   5        $��	btnDelete��5?      $��10q�6*   $��80��66   $��Delete��6A   6R   5@      5A      5B      5C      