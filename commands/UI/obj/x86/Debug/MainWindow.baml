   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   @       UI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   UIclr-namespace:UI     6@     � Title$  
MainWindow��6\   $	��350��6o   $	��525��6|    � 	Resources 5         UI.CustomCommand   CustomCommand��%   &	          5      6   5      .��5      �� .+�5   
   �� -   5        $��	TheButton��5      $
��Help��6"   ��61   ��  �� RelativeSource �� *Self+ �� Path$ Command.Text��� 5	   
   $��Paste��6   ��6!   ��  �� ElementName$ textBox����6O   ��  �� *Self+$ Command.Text��� 5
   
   $	��Cut��6   ��6   �� $ textBox����6M   ��  �� *Self+$ Command.Text��� 5   
   #��[  6   ��6F   �� $ textBox����6t   ��  �� *Self+$ Command.MyCustomString��� 5   
   -   5        $��textBox��5      5      5      