   M S B A M L   `   `   `  ����  chargesystem%    chargesystem.MaintainChargeForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  维修费用��5   	   $	��400��6   $	��500��6#   .��5      � .+�5	      �� 
���   �$��1q�6'   $��86��6;   $��	12,3,16,0q�6G   $	��Top=�6Z   &   System.Windows.Controls.DataGrid  5
   
   $��31,143.687,25,77.313q�6   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6V      CanUserSortColumns .     CanUserResizeColumns .    CanUserReorderColumns .     CanUserResizeRows .    AutoGenerateColumns .     CanUserAddRows .  ��62   ��  �� Mode$ OneWay=�	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 报修时间��6!      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 60   �� *M_Time+6]     5      $
 	报修人��6%    . $ * 6`    63   �� *M_Name+6`     5      $
 费用出处��6%    . $ * 6g    63   �� *M_Feederivate+6g     5      $
 金额��6%    . $ * 6_    62   �� *M_Fee+6_   5      �� 5      $��Right=�6   $
��Wrap=�62   $��公司总费用：��6F   $	��Top=�6T   $��0,126,128,0q�6l   �� 5      $��Right=�6   $
��Wrap=�62   $	��231��6F   $	��Top=�6Q   $��
0,126,70,0q�6i   �� 5      $��Right=�6   $
��Wrap=�62   $	��元��6F   $	��Top=�6O   $��
0,126,54,0q�6g   �� 5      -   5        $��确定��5      $
��Left=�6    $��Bottom=�6N   $��75��6i   $��84,0,0,39.313q�6t   �� 5      $��打印��6   $��Right=�6    $��Bottom=�6<   $��75��6W   $��0,0,143,39.313q�6b   �� 5      
���   �$��1q�6"   $��12,101,13,24q�66   5      5      