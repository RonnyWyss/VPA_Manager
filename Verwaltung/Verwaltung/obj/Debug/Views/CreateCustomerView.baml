   M S B A M L   `   `   `  ����E  AVerwaltung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Verwaltung.ViewsVerwaltung.Views  5      )    #Verwaltung.Views.CreateCustomerView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      0localclr-namespace:Verwaltung.Views     5      $	��450��5      $	��800��6   .��5
      �   � ColumnDefinitions  5   
   �� 5      $	��150 �6   �� 5      $	��200 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��* �6   .+�5!   
   �� $��0��6   $��0��6!   $
��Left=�61   $��Center=�6L   $
��Bold"�6g   $��Mitarbeiter erstellen��6y   �� 5#   
   $��1��6   $��0��6!   $
��Left=�61   $��Center=�6L   $��Firma��6g   �� 5$   
   $��1��6   $��1��6    ��60   �� *
TypItems+ �� SelectedItem 6Q   �� *SelectedTypItem+�� 5&   
   $��2��6   $��0��6!   $
��Left=�61   $��Center=�6L   $��Anrede��6g   �� 5'   
   $��2��6   $��1��6    ��60   �� *
TypItems+ 6Q   �� *SelectedTypItem+�� 5)   
   $��3��6   $��0��6!   $
��Left=�61   $��Center=�6L   $��Mitarbeiter Name��6g   �� 5*   
   $��3��6   $��1��6   ��60   �� *
Nachname+�� 5,   
   $��4��6   $��0��6!   $
��Left=�61   $��Center=�6L   $��Mitarbeiter Vorname��6g   �� 5-   
   $��4��6   $��1��6   ��60   �� *	Vorname+�� 5/   
   $��5��6   $��0��6!   $
��Left=�61   $��Center=�6L   $��Position��6g   �� 50   
   $��5��6   $��1��6   ��60   �� *
Position+�� 52   
   $��6��6   $��0��6!   $
��Left=�61   $��Center=�6L   $��
Geburtstag��6g   �� 53   
   $��6��6   $��1��6   ��60   �� *
Geburtstag+�� 55   
   $��7��6   $��0��6!   $
��Left=�61   $��Center=�6L   $��Telefonnummer��6g   �� 56   
   $��7��6   $��1��6   ��60   �� *Telefonnummer+�� 58   
   $��8��6   $��0��6!   $
��Left=�61   $��Center=�6L   $��Mobilenummer��6g   �� 59   
   $��8��6   $��1��6   ��60   �� *Mobilenummer+�� 5;   
   $��9��6   $��0��6!   $
��Left=�61   $��Center=�6L   $��E-Mail��6g   �� 5<   
   $��9��6   $��1��6   ��60   �� *EMail+�� 5>   
   $��10��6   $��0��6"   $
��Left=�62   $��Center=�6M   $��Bemerkungen��6h   �� 5?   
   $��10��6   $��1��6    ��60   �� *Bemerkungen+�� 5A   
   $��11��6   $��0��6"   $
��Left=�62   $��Center=�6M   $��Erfassungsdatum��6h   �� 5B   
   $��11��6   $��1��6    {�.  $��Center=�6B   ��6]   �� *Erfassungsdatum+ �� StringFormat$ dd.MM.yyyy HH:mm:ss���� 5D   
   $��12��6   $��1��6   $��	Speichern��6/   ��6C   �� *CmdSpeichern+5E      5F      