   M S B A M L   `   `   `  ����D  @Minecraft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Minecraft	Minecraft  5   	       Minecraft.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Minecraft     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��4* �6   �� 5      $��3* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Job Assignments��6   $��18(�6*   $
��20,0q�68   $��Center=�5      $��Bottom=�6$   �� 5   
   $��1��6   $	��Top=�6"   $��20q�6:   .+�5      �� -   5         ��Name$ jobSelector��5      $��18(�6,    �� SelectedIndex$ 0��6:   $��0,0,0,20q�6L   .@�5      �� $��Miner��6   �� 5      $��
Blacksmith��6   �� 5      $��Villager��6   5      �� 5      -   5        $!��Assign this job to a player��5      $
��18px(�6;   6K   5      �� 5!   
   -   5        $��2��5!      $��Work the next shift��6   $
��18px(�6<   $��20q�5"   #   �� 5$   
   $��Admin's Report��6   $��1��6)   $��18(�69   $
��20,0q�6G   $��Bottom=�5%   
   $��Center=�6%   �� 5'   
   -   5         ��Name$ statusReport��5(       �� 
IsReadOnly$
 True��6   $��1��5)      $��2��6   $��1��6#   $��20q�63   5*      5,      