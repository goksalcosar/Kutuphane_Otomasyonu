   M S B A M L   `   `   `  ����N  JKutuphaneOtomasyonu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:KutuphaneOtomasyonu.UserControls KutuphaneOtomasyonu.UserControls  5      S.clr-namespace:KutuphaneOtomasyonu.UserControls KutuphaneOtomasyonu.UserControls  5      5    /KutuphaneOtomasyonu.UserControls.UyeUserControl   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:KutuphaneOtomasyonu.UserControls     5      =UC.clr-namespace:KutuphaneOtomasyonu.UserControls     5      -   5        ���#353f59.��5
      �   � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $��3* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	Dtg_Liste��5      $��0��5         
IsReadOnly$
 True��6       	RowHeight$ 30Q�62      CanUserAddRows$ False��6A      CanUserSortColumns$
 True��6X      CanUserResizeColumns$ False��5         CanUserResizeRows$ False��60      AutoGenerateColumns$ False��6J   	   HeadersVisibility$	 Column=�6f      DataGridStyle#��[  5      $��Stretch=�6:   $	��Top=�6X   ��5   &   �� ��6>   Z� ��6T   Z� 
 � 	Resources
 5      )  #System.Windows.Controls.DataGridRow �� 
TargetType��%E   '        �� 5      "  6   .�5      -   5        5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 True��6A      Header$ ÖĞRENCİ ID��6S      MinWidth$ 30Q�5   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   ��  �� Path$ ID�   ElementStyle 5!      �� 5#      " ��6    .�5$      ��  �� Property � �� �� Value$
 Left=�6D   �� 5%       � ��$ Center=�6B   �� 5&       �@��Padding$ 5q�68   5'         	CellStyle 5+      �� 5,      *  $System.Windows.Controls.DataGridCell"  6    .�5-      ��  � �� �#6534ac6;   �� 5.       � ��
 �����6;   �� 5/       � �� �	#FF272C386<   �� 50       � ��$ 1,0,0,0q�6@    �� Triggers 52      P� 53   "    P� Property �@ 
IsSelected P� Value$
 True��6@   . �54   &   ��  � �� �	#FF4019796C   �� 55   &    � ��
 �����6C   �� 56   &    � �� �	#FF272C386D   �� 57   &    � ��$ 5,0,0,0q�6H   58   #   5:      5=        5?      $
 True��6J   $ İSİM SOYİSİM��6\   $	 131Q�5@   %    5?   %   �� $ IsimSoyisim� 5B      �� 5D      " ��6    .�5E      ��  � ��$
 Left=�6D   �� 5F       � ��$ Center=�6B   �� 5G       �@��Padding$ 5q�68   5H      5L        5N      $
 True��6B   $
 YAŞ��6T   $	 110Q�5O   %    5N   %   �� $	 Yas� 5Q      �� 5S      " ��6    .�5T      ��  � ��$
 Left=�6D   �� 5U       � ��$ Center=�6B   �� 5V       �@��Padding$ 5q�68   5W      5[        5]      $
 True��6C   $ TC NO��6U   $	 110Q�5^   %    5]   %   �� $
 TcNo� 5`      �� 5b      " ��6    .�5c      ��  � ��$
 Left=�6D   �� 5d       � ��$ Center=�6B   �� 5e       �@��Padding$ 5q�68   5f      5j        5l      $
 True��6H   $ 
TELEFON NO��6Z   $	 110Q�5m   %    5l   %   �� $ 	TelefonNo� 5o      �� 5q      " ��6    .�5r      ��  � ��$
 Left=�6D   �� 5s       � ��$ Center=�6B   �� 5t       �@��Padding$ 5q�68   5u      5y        5{      $
 True��6D   $ ADRES��6V   $	 166Q�5|   %    5{   %   �� $ Adres� 5~      �� 5�      " ��6    .�5�      ��  � ��$
 Left=�6D   �� 5�       � ��$ Center=�6B   �� 5�       �@��Padding$ 5q�68   5�      5�        5�      $
 True��6E   $ EPOSTA ADRESİ��6W   $	 150Q�5�   %    5�   %   �� $ Eposta� 5�      �� 5�      " ��6    .�5�      ��  � ��$
 Left=�6D   �� 5�       � ��$ Center=�6B   �� 5�       �@��Padding$ 5q�68   5�      5�      5�      � 5�   
   $��1��6    � ColumnDefinitions 5�      �� 5�      $	��300 �6#   �� 5�      $��* �6#   �� 5�      $��* �6#   .+�5�      �� $
��Auto=�6   $
��Auto=�6K   $��0��6}   .��5�      �� $
��Left=�6   $	��Top=�68   $��10q�6P   .+�5�      2   ,KutuphaneOtomasyonu.UserControls.OzelTextBox  -   5          Name$ txt_ID��5�   e   $	��250��6%   $��80��61      Caption$ ID��6=      Hint$ Öğrencin ID Bilgisi��6J   6e     5�      -   5        $ txt_AdSoyad��5�   r   $	��250��6%   $��80��61   $ İsim Soyisim��6=   $ Öğrenci İsim, Soyisimi��6T   6r     5�      -   5        $ txt_Yas��5�   b   $	��250��6%   $��80��61   $
 Yaş��6=   $ Öğrencinin Yaşı��6K   6b     5�      -   5        $ txt_TcNo��5�   f   $	��250��6%   $��80��61   $ Tc No��6=   $ Öğrencin Tc No'su��6M   6f     5�      -   5        $ 	txt_Adres��5�   d   $	��250��6%   $��80��61   $ Adres��6=   $ Öğrencin Adresi��6M   6d   5�      5�      �� 5�      $
��Auto=�6   $
��Auto=�6K   $��1��6}   .��5�      �� $
��Left=�6   $	��Top=�68   $��10q�6P   .+�5�        -	   5        $ 
txt_Eposta��5�   h   $	��250��6%   $��80��61   $ E-posta��6=   $ Öğrencin Epostası��6O   6h     5�      -
   5        $ txt_TelefonNo��5�   p   $	��250��6%   $��80��61   $ 
Telefon No��6=   $ Öğrencin Telefon No'su��6R   6p     5�      -   5        $ 
txt_Sil_ID��5�   {   $	��250��6%   $��80��61   $ Silinecek Olan ID��6=   $" Silinecek Öğrencinin ID'si��6Y   6{     5�      -   5        $ txt_Guncelle_ID��5�   x   $	��250��6%   $��80��61   $ Güncelle ID��6=   $&  Güncellenecek Öğreninin ID'si��6S   6x   5�      5�      �� 5�      $
��Auto=�6   $
��Auto=�6K   $��2��6}   .��5�      �� $��2��6   $
��Left=�6-   $	��Top=�6H   $��
30,50,0,10q�6`   .+�5�      �� -   5         ��Name$	 btn��5�   v   $��Kayıt��6   $��0,0,0,0q�6-     	btn_Style#��[ 6>   6v   �� 5�      -   5        $��	Güncelle��5�      $��0,20,0,0q�60   #��[ 6B   6e   �� 5�      -   5        $	��Sil��5�      $��0,20,0,0q�6+   #��[ 6=   6`   �� 5�      -   5        $��Listele��5�      $��0,20,0,0q�6/   #��[ 6A   6d   �� 5�      -   5        $��Temizle��5�      $��0,20,0,0q�6/   #��[ 6A   6d   5�      5�      5�      5�      5�      