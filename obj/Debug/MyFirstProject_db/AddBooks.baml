   M S B A M L   `   `   `  ����J  FMyFirstProject2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MyFirstProject2MyFirstProject2  5   	       MyFirstProject2.AddBooks   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MyFirstProject2     5   	     � Title$  AddBooks��5   	   $	��300��6   $	��300��6'    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ Times New Roman)�6+   �� 5       � ��$ 14(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 5q�6'   �� 5       � ��$ 5q�6(   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	booksGrid��5   /      AutoGenerateColumns .  $
��Auto=�6B   $
��Auto=�6t      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��6<   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 30 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id+6U     5      $	 
NameSource��6D   $	
 300 6X    6%   �� *
NameSource+6f   5      �� 5    
   $��1��6    �� Orientation$ 
Horizontal=�6"   .+�5!      �� -   5        $��Refresh��5!      .��6;   	Refresh6D   �� 5"      -   5        $	��Add��5"      .��63   Add68   �� 5#      -   5        $��UpDate��5#      .��69   UpDate6A   �� 5$      -   5         ��Name$ Remove��5$      $��Remove��6:   5%      5(      5*      