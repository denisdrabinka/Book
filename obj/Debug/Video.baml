   M S B A M L   `   `   `  ����J  FMyFirstProject2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MyFirstProject2MyFirstProject2  5   	       MyFirstProject2.Video   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MyFirstProject2     5   	   -   5          � Title$  Video��5   	   $	��700��6   $
��1050��6$   .��5
      � -   5         �Name$ 
LayoutRoot��5
      .+�5   
   r� -   5         r�Name$ media1��5       r� Stretch$ Uniform=�6'    r� LoadedBehavior$ Manual=�6Z   �� 5   
   -   5         ��Name$ 
playButton��5      $
��Play��6%   $��Bottom=�6M   $
��Left=�6h   $��40��6�   $��25��6�   �� 5   
   -   5        $ pauseButton��5      $��Pause��6&   $��Bottom=�6Q   $
��Left=�6l   $��40��6�   $��25��6�   $��40 0 0 0q�6�   �� 5   
   -   5        $ 
stopButton��5      $
��Stop��6%   $��Bottom=�6N   $
��Left=�6i   $��40��6�   $��25��6�   $��80 0 0 0q�6�   �� 5   
   -   5        $ backwardsButton��5      $��-��6*   $��Bottom=�6U   $
��Left=�6p   $��40��6�   $��25��6�   $��	120 0 0 0q�6�   �� 5   
   -   5        $ forwardButton��5      $��+��6(   $��Bottom=�6Q   $
��Left=�6l   $��40��6�   $��25��6�   $��	160 0 0 0q�6�   �� 5   
   $��Громкость��6   $��Bottom=�6%   $
��Left=�6@   $��	240 0 0 4q�6[   �� 5   
   -	   5         ��Name$ slider1��5      $��20��6"   $��Bottom=�6.   $
��Left=�6I   $	��100��6d   $��	307,0,0,4q�6q    � Minimum$ 0Q�6�    � Maximum$ 1Q�6�   	 � Value$		 0.5Q�6�   6�   �� 5   
   -
   5        $ slider2��5      $��20��6"   $��Bottom=�6.   $��0 0 0 30q�6I   
 J� Opacity$	
 0.5Q�6�   �� 5   
   -   5        $ sliderback2��5      $��20��6&   $��Bottom=�62   $��0 0 0 30q�6M    J� IsHitTestVisible .  6`   �� 5   
   -   5         ��Name$
 time��5      $��00:00��6"   $	��Top=�6/   5      5      