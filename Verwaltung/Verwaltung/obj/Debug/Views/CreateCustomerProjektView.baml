   M S B A M L   `   `   `  ����E  AVerwaltung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Verwaltung.ViewsVerwaltung.Views  5      0    *Verwaltung.Views.CreateCustomerProjektView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Verwaltung.Views     5      $	��600��5      $	��800��6   .��5	      �   � ColumnDefinitions  5
   
   �� 5      $	��150 �6   �� 5      $	��200 �6   �� 5      $��50 �6   �� 5      $	��150 �6   �� 5      $	��200 �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   .+�5   
   �� $��0��6   $��0��6!   $
��Left=�61   $��Center=�6L   $
��Bold"�6g   $��Projekt erfassen��6y   �� 5    
   $��1��6   $��0��6!   $
��Left=�61   $��Center=�6L   $��Kunde��6g   �� 5!   
   $��1��6   $��1��6    ��60   �� *
TypItems+ �� SelectedItem 6Q   �� *SelectedTypItem+�� 5"   
   $��2��6   $��0��6!   $
��Left=�61   $��Center=�6L   $��Ansprechsperson��6g   �� 5#   
   $��2��6   $��1��6    ��60   �� *
TypItems+ 6Q   �� *SelectedTypItem+�� 5$   
   $��3��6   $��0��6!   $
��Left=�61   $��Center=�6L   $��Projektname��6g   �� 5%   
   $��3��6   $��1��6   ��6/   �� *Projektname+�� 5'   
   $��4��6   $��0��6!   $
��Left=�61   $��Center=�6L   $��	Ersteller��6g   �� 5(   
   $��4��6   $��1��6   {�.  ��6A   �� *
Benutzer+�� 5*   
   $��5��6   $��0��6!   $
��Left=�61   $��Center=�6L   $��Erfassungsdatum��6g   �� 5+   
   $��5��6   $��1��6   {�.  ��6A   �� *Erfassungsdatum+ �� StringFormat$ dd.MM.yyyy HH:mm:ss���� 5-   
   $��7��6   $��1��6   $��Speichern / Hinzufügen��6.   ��6O   �� *CmdSpeichern+5/      50      