   M S B A M L   `   `   `  ����W  SModelViewViewModel Voorbeeld, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:ModelViewViewModel_Voorbeeld.Stap3"ModelViewViewModel_Voorbeeld.Stap3  5   	   4    .ModelViewViewModel_Voorbeeld.Stap3.PersoonView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:ModelViewViewModel_Voorbeeld.Stap3     5   	     � Title$  PersoonView��5   	   $	��200��6   $	��500��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��Naam:��6   $��0��6!   $��0��6.   $��5q�6>   �� 5   
   -   5        $��txtNaam��5      $��Hier komt de naam��6!   $��0��6:   $��1��6G   $��5q�6W   �� 5   
   -   5        $��txbErrorNaam��5      $�� ��6(   $��0��60   $��2��6=   �� 5   
   $��	Leeftijd:��6   $��1��6%   $��0��62   $��5q�6B   �� 5   
   -   5        $��txtLeeftijd��5      $��Hier komt de leeftijd��6%   $��1��5      $��1��6   $��5q�6/   �� 5   
   -   5        $��txbErrorLeeftijd��5      $�� ��6,   $��1��64   $��2��6A   �� 5   
   $��
Mannelijk:��6   $��2��6&   $��0��63   $��5q�6C   �� 5   
   -   5        $��IsMannelijk��5      $��2��6'   $��1��64   $��5q�6D   �� 5   
   -   5        $��	btnUpdate��5      $��Update��6"   $��3��5       $��1��6   $��5q�6.   �� 5!   
   -   5        $��btnToon��5!      $
��Toon��6    $��4��5#      $��0��6   $��5q�6.   �� 5%   
   -   5        $��btnVeranderInCode��5%      $��Verander in Code��6*   $��4��5'      $��1��6   $��5q�6.   5*      5+      