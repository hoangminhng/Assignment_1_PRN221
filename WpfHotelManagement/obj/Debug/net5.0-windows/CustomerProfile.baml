   M S B A M L   `   `   `  ����M  IWpfHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfHotelManagementWpfHotelManagement  5      (    "WpfHotelManagement.CustomerProfile   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:WpfHotelManagement     5      $	��450��5      $	��800��6   .��5	      � .+�5
   
   ��   �� Orientation$  Vertical=�6   $
��Left=�5      $	��800��60   .+�5      �� -   5        $��lblInstruction��5      
���**��$��DemiBold"�6=   $��Center=�6S   $��20(�5      $��Customer Profile��6"   �� 5      $  
Horizontal=�6   .+�5      �� -   5        $��lblTelephone��5      $��	Telephone��6,   $	��100��6@   �� 5      -   5        $��txtTelephone��5      $
��Left=�6.   $��25��5      $	��300��6&   5      �� 5      $  
Horizontal=�6   .+�5      �� -   5        $��lblEmailAddress��5      $��Email Address��6/   $	��100��6G   �� 5      -   5        $��txtEmailAddress��5      $
��Left=�61   $��25��5      $	��300��6&   5      �� 5      $  
Horizontal=�6   .+�5      �� -   5        $��lblCustomerFullName��5      $��	Full name��63   $	��100��6G   �� 5      -   5        $��txtCustomerFullName��5      $
��Left=�65   $��25��5      $	��300��6&   5      �� 5      $  
Horizontal=�6   .+�5      �� -   5        $��lblCustomerBirthday��5      $��Birthday��63   $	��100��6F   (  "System.Windows.Controls.DatePicker  5      -	   5        $��
dtBirthday��5!   5   $	��300��5         SelectedDateFormat$
 Long=�6)      DisplayDateStart 1/01/095          DisplayDateEnd 12/31/0968      FirstDayOfWeek$ Monday=�5!      65   5"      �� 5$      $  
Horizontal=�6   $
��Left=�62   $��10q�6M   .+�5%      �� -
   5         ��Name$ 	btnUpdate��5%      $
��10 0q�6,   $��70��6:   $��Update��6E   6V   5&      5'      5(      5)      